using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using WindowsFormsApp1;

namespace OlisWork
{
    public partial class Json : Form
    {
        string path = @"C:\Users\Oli\Desktop\1.json";
        string JsonFile;


        public Json()
        {
            InitializeComponent();
        }


        // JSON Name class
        public class NameJ
        {
            public string Name;
        }


        // 將資料寫入JSON檔
        public void write()
        {
            //NameJ name = new NameJ();
            //name.Name = textBoxJWrite.Text;

            try
            {
                NameJ nameJ = new NameJ()
                {
                    Name = txtJWrite.Text,
                };

                var name = JObject.FromObject(nameJ);                          // JObject用來操作JSON物件，FromObject(nameJ)是要轉化的對象，返回一個JObject物件
                string output = JsonConvert.SerializeObject(name);             // 序列化

                File.WriteAllText(path, $"[{txtJRead.Text+ output}]");

                txtJWrite.Text = "";                                           // 清空資料

                // 讀取資料
                read();
            }
            catch (Exception ex)
            {
                WriteLog.WriteLogg(ex, "write() 寫入JSON錯誤", "");
            }
        }


        // 從JSON檔案中讀取
        public void read()
        {
            txtJRead.Text = "";

            try
            {
                if (path != null)
                {
                    JsonFile = File.ReadAllText(path);

                    JArray jsonarray = JArray.Parse(JsonFile);                     // JArry是JSON的陣列
                    // JsonArray陣列中有無資料
                    for (int i = 0; i <= jsonarray.Count - 1; i++)
                    {
                        txtJRead.Text += jsonarray[i].ToString() + "," + "\r\n";
                    }
                }
                else
                {
                    MessageBox.Show("Create");
                }
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogg(ex, "read() 讀取JSON錯誤", "");
            }
        }


        // 按鈕寫入讀取
        private void btn_Click(object sender, EventArgs e)
        {
            // 讀取JSON文件
            read();

            // 寫入JSON文件
            write();
        }
    }
}
