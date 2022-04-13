using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using WindowsFormsApp1;

namespace OlisWork
{
    public partial class DataCURD_form : Form
    {
        SqlConnection con = new SqlConnection("Data Source=PC-OLI;Initial Catalog=WorkDataControl_Student;Integrated Security=True");
        int Mar = 0;
        int StuID = 0;
        

        public DataCURD_form()
        {
            InitializeComponent();
        }


        // 初始設定
        private void dataCURD_Load(object sender, EventArgs e)
        {
            // 更新畫面資料
            load_Update();
        }


        // 處理完資料清空至預設欄位值
        private void textClear()
        {
            txtStuID.Text = "";
            txtName.Text = "";
            cboGrade.SelectedIndex = 0;
            Mar = 0;
        }


        // 顯示資料，在更新資料後也跟著更新畫面上資料
        public void load_Update()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvShow.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                WriteLog.OliWriteLog(ex, "load_Update() 連接DB顯示資料錯誤");
            }
        }


        // 新增按鈕按下後新增Student資料
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (chkMarried.Checked)
            {
                Mar = 1;
            };

            try
            {
                // 判斷欄位是否輸入
                if(txtStuID.Text!= null && txtName.Text.Length > 0 && cboGrade.SelectedItem != null)
                {
                    // 判斷學號輸入是否重複
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Student WHERE StuID = '" + txtStuID.Text + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
 
                    // 判斷學號欄位是否為數字且不重複
                    if(int.TryParse(txtStuID.Text, out StuID) == true && dr.Read() == false)
                    {
                        // 使用到類別SqlCURD方法
                        string insert_data = $"INSERT INTO Student VALUES ('{txtStuID.Text}', '{txtName.Text}', '{cboGrade.Text}', '{Mar}')";
                        new SqlCURD(insert_data);

                        MessageBox.Show("新增成功!");

                        // 成功後關閉 dr.Read()方法連線
                        dr.Close();
                        con.Close();

                        // 新增後更新畫面上資料
                        load_Update();
                    }
                    else
                    {
                        // 失敗後關閉連線
                        dr.Close();
                        con.Close();

                        MessageBox.Show("檢查學號!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("請確認欄位輸入!");
                }
                // 清空欄位
                textClear();
            }
            catch (Exception ex)
            {
                WriteLog.OliWriteLog(ex, "btnAdd_Click() 新增資料錯誤, txtStuID.Text:" + txtStuID.Text + ", txtName.Text:" + txtName.Text + ", cboGrade.Text:" + cboGrade.Text + ", Mar:" + Mar);
            }
        }


        // 在textBox_StuID 輸入學號後按下刪除按鈕刪除該Student資料
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // 判斷有無輸入學號欄位
                if(txtStuID.TextLength > 0)
                {
                    // 判斷學號輸入是否重複
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Student Where StuID = '" + txtStuID.Text + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    // 判斷學號欄位是否為數字及已存在之學號
                    if (int.TryParse(txtStuID.Text, out StuID) == true && dr.Read() == true)
                    {
                        // 先關閉dr連線
                        dr.Close();

                        SqlCommand cmdDel = new SqlCommand("DELETE Student WHERE StuID = @StuID", con);
                        cmdDel.Parameters.AddWithValue("@StuID", int.Parse(txtStuID.Text));
                        cmdDel.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("刪除成功!");

                        // 學號欄位編輯成功後開放
                        txtStuID.Enabled = true;

                        // 刪除後更新畫面上資料
                        load_Update();
                    }
                    else
                    {
                        // 失敗後關閉連線
                        con.Close();

                        MessageBox.Show("請確認學號!");
                    }
                }
                else
                {
                    MessageBox.Show("請輸入學號!");
                }
                // 清空欄位
                textClear();
            }
            catch(Exception ex)
            {
                WriteLog.OliWriteLog(ex, "btnDelete_Click() 刪除資料錯誤, txtStuID.Text:" + txtStuID.Text);
            }
        }


        // 按下編輯按鈕後編輯Student資料
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (chkMarried.Checked)
            {
                Mar = 1;
            };
            
            // 判斷欄位是否輸入
            if(txtStuID.Text.Length > 0 && txtName.Text.Length > 0 && cboGrade.SelectedItem != null)
            {
                try
                {
                    // 使用到類別SqlCURD方法
                    string edit_data = $"UPDATE Student SET Name = '{txtName.Text}', Grade = '{cboGrade.SelectedItem}', Married = '{Mar}' WHERE StuID = '{txtStuID.Text}'";
                    new SqlCURD(edit_data);

                    MessageBox.Show("編輯成功!");

                    // 學號欄位編輯成功後開放
                    txtStuID.Enabled = true;

                    // 清空欄位
                    textClear();

                    // 編輯後更新畫面上資料
                    load_Update();
                }
                catch (Exception ex)
                {
                    WriteLog.OliWriteLog(ex, "btnEdit_Click() 編輯資料錯誤, txtStuID.Text:" + txtStuID.Text + "txtName.Text:" + txtName.Text + "cboGrade.Text:" + cboGrade.Text + "Mar:" + Mar);
                }
            }
        }


        // 在textBox_StuID 輸入學號後KeyDown(按下Enter)把該Student資料填入到 Textbox、ComboBox、CheckBox中做搜尋
        private void txt_StuID_KeyDown(object sender, KeyEventArgs e)
        {
            // 如果壓下的是ENTER
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    // 判斷有無輸入學號
                    if(txtStuID.TextLength != 0)
                    {
                        // 判斷學號輸入是否重複
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Student Where StuID = '" + txtStuID.Text + "'", con);
                        SqlDataReader dr = cmd.ExecuteReader();

                        // 判斷學號欄位是否為數字及已存在之學號
                        if (int.TryParse(txtStuID.Text, out StuID) == true && dr.Read() == true)
                        {
                            // 先關閉dr連線
                            dr.Close();

                            SqlCommand cmdView = new SqlCommand($"SELECT * FROM Student WHERE StuID = '{txtStuID.Text}'", con);
                            SqlDataAdapter da = new SqlDataAdapter(cmdView);

                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            con.Close();

                            // 如果資料存在就帶上欄位
                            if (dt.Rows.Count != 0)
                            {
                                txtName.Text = dt.Rows[0][1].ToString();
                                cboGrade.Text = dt.Rows[0][2].ToString();
                                chkMarried.Checked = Boolean.Parse(dt.Rows[0][3].ToString());

                                // 唯讀學號欄位不能更改
                                txtStuID.Enabled = false;
                            }
                        }
                        else
                        {
                            // 失敗後關閉連線
                            con.Close();

                            MessageBox.Show("請確認學號!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("請輸入學號!");
                    }
                }
                catch (Exception ex)
                {
                    WriteLog.OliWriteLog(ex, "txt_StuID_KeyDown() 搜尋資料錯誤, txtStuID.Text:" + txtStuID.Text + "txtName.Text:" + txtName.Text + "cboGrade.Text:" + cboGrade.Text + "Mar:" + Mar);
                }
            }
        }
    }
}
