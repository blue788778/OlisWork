using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace OlisWork
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=PC-OLI;Initial Catalog=WorkDataControl_Student;Integrated Security=True");
        int Mar = 0;

    public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            Load_Update();
        }

        // 在更新資料後也跟著更新畫面上資料
        public void Load_Update()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        // 新增按鈕按下後新增Student資料
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (checkBox_Mar.Checked)
            {
                Mar = 1;
            };

            string insert_data = $"insert into Student values ({textBox_StuID.Text},{textBox_Name.Text} ,{comboBox_Grade.Text}, {Mar})";      // 使用到SqlCURD
            
            try
            {
                new SqlCURD(insert_data);

                MessageBox.Show("Good!");

                Load_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace.ToString());
            }
        }

        // 在textBox_StuID 輸入學號後按下刪除按鈕刪除該Student資料
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete Student where StuID = @StuID", con);
                cmd.Parameters.AddWithValue("@StuID", int.Parse(textBox_StuID.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Nice!");

                Load_Update();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace.ToString());
            }
            con.Close();
        }

        // 按下編輯按鈕後編輯Student資料
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (checkBox_Mar.Checked)
            {
                Mar = 1;
            };
            
            string edit_data = $"update Student set Name = '{textBox_Name.Text}', Grade = '{comboBox_Grade.SelectedItem}', Married = '{Mar}' where StuID = '{textBox_StuID.Text}'";
            
            try
            {
                new SqlCURD(edit_data);

                MessageBox.Show("Brave!");

                Load_Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace.ToString());
            }
        }

        // 在textBox_StuID 輸入學號後KeyDown(按下Enter)把該Student資料填入到 Textbox、ComboBox、CheckBox中做搜尋
        private void textBox_StuID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"select * from Student where StuID = '{textBox_StuID.Text}'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    con.Close();
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count != 0)
                    {
                        textBox_Name.Text = dt.Rows[0][1].ToString();
                        comboBox_Grade.Text = dt.Rows[0][2].ToString();
                        checkBox_Mar.Checked = Boolean.Parse(dt.Rows[0][3].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace.ToString());
                }
            }
        }
    }
}
