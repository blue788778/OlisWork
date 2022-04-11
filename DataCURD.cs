using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using WindowsFormsApp1;

namespace OlisWork
{
    public partial class DataCURD : Form
    {
        SqlConnection con = new SqlConnection("Data Source=PC-OLI;Initial Catalog=WorkDataControl_Student;Integrated Security=True");
        int Mar;
        int StuId;
        

        public DataCURD()
        {
            InitializeComponent();
        }


        private void dataCURD_Load(object sender, EventArgs e)
        {
            // 更新畫面資料
            load_Update();
        }


        // 顯示資料，在更新資料後也跟著更新畫面上資料
        public void load_Update()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Close();

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvShow.DataSource = dt;
            }
            catch (Exception ex)
            {
                WriteLog.WriteLogg(ex, "load_Update() 連接DB顯示資料錯誤");
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
                if(txtStuID.Text!= null &&txtName.Text!= null && cboGrade.SelectedItem != null)
                {
                    // 判斷學號欄位是否為數字
                    if(int.TryParse(txtStuID.Text, out StuId) == true)
                    {
                        string insert_data = $"INSERT INTO Student VALUES ({txtStuID.Text}, {txtName.Text}, {cboGrade.Text}, {Mar})";          // 使用到SqlCURD

                        new SqlCURD(insert_data);

                        MessageBox.Show("Good!");

                        // 新增後更新畫面上資料
                        load_Update();
                    }
                    else
                    {
                        MessageBox.Show("檢查學號");
                    }
                }
                else
                {
                    MessageBox.Show("請確認欄位");
                }
            }
            catch (Exception ex)
            {
                WriteLog.WriteLogg(ex, "btnAdd_Click() 新增資料錯誤");
            }
        }


        // 在textBox_StuID 輸入學號後按下刪除按鈕刪除該Student資料
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // 判斷有無輸入學號欄位
                if(txtStuID.TextLength != 0)
                {
                    // 判斷學號欄位是否為數字
                    if (int.TryParse(txtStuID.Text, out StuId) == true)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE Student WHERE StuID = @StuID", con);
                        cmd.Parameters.AddWithValue("@StuID", int.Parse(txtStuID.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Nice!");
                        // 刪除後更新畫面上資料
                        load_Update();
                    }
                    else
                    {
                        MessageBox.Show("請確認學號");
                    }
                }
                else
                {
                    MessageBox.Show("Bad!");
                }
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogg(ex, "btnDelete_Click() 刪除資料錯誤");
            }
            con.Close();
        }


        // 按下編輯按鈕後編輯Student資料
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (chkMarried.Checked)
            {
                Mar = 1;
            };
            
            // 判斷欄位是否輸入
            if(txtStuID.TextLength != 0 && txtName.TextLength != 0 && cboGrade.SelectedItem != null)
            {
                try
                {
                    string edit_data = $"UPDATE Student SET Name = '{txtName.Text}', Grade = '{cboGrade.SelectedItem}', Married = '{Mar}' WHERE StuID = '{txtStuID.Text}'";
                    new SqlCURD(edit_data);

                    MessageBox.Show("Bravo!");
                    // 編輯後更新畫面上資料
                    load_Update();
                }
                catch (Exception ex)
                {
                    WriteLog.WriteLogg(ex, "btnEdit_Click() 編輯資料錯誤");
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
                        // 判斷學號欄位是否為數字
                        if (int.TryParse(txtStuID.Text, out StuId) == true)
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand($"SELECT * FROM Student WHERE StuID = '{txtStuID.Text}'", con);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            con.Close();

                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt.Rows.Count != 0)
                            {
                                txtName.Text = dt.Rows[0][1].ToString();
                                cboGrade.Text = dt.Rows[0][2].ToString();
                                chkMarried.Checked = Boolean.Parse(dt.Rows[0][3].ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("檢查學號");
                        }
                    }
                    else
                    {
                        MessageBox.Show("請輸入學號");
                    }
                }
                catch (Exception ex)
                {
                    WriteLog.WriteLogg(ex, "txt_StuID_KeyDown() 搜尋資料錯誤");
                }
            }
        }
    }
}
