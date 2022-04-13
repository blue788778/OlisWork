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
    public partial class Json_form : Form
    {
        NameJson MyNameJ = null;
        JArray JsonArray = null;
        string Output = "";
        string Path = @"C:\Users\Oli\Desktop\1.json";
        string JsonFile = "";


        public Json_form()
        {
            InitializeComponent();
        }


        // JSON Name class
        public class NameJson
        {
            public string Name;
        }


        // 將資料寫入JSON檔
        public void write()
        {
            //NameJson myjobject = new NameJson();
            //myjobject.Name = textBoxJWrite.Text;

            try
            {
                MyNameJ = new NameJson()
                {
                    Name = txtJWrite.Text,
                };

                var myjobject = JObject.FromObject(MyNameJ);                   // JObject用來操作JSON物件，FromObject(nameJ)是要轉化的對象，返回一個JObject物件
                Output = JsonConvert.SerializeObject(myjobject);               // 序列化

                File.WriteAllText(Path, $"[{txtJRead.Text+ Output}]");

                txtJWrite.Text = "";                                           // 清空資料

                // 讀取資料
                read();
            }
            catch (Exception ex)
            {
                WriteLog.OliWriteLog(ex, "write() 寫入JSON錯誤, Output:" + Output);
            }
        }


        // 從JSON檔案中讀取
        public void read()
        {
            txtJRead.Text = "";

            try
            {
                if (Path != null)
                {
                    JsonFile = File.ReadAllText(Path);
                    JsonArray = JArray.Parse(JsonFile);                        // JArry是JSON的陣列

                    // JsonArray陣列中有無資料
                    for (int i = 0; i <= JsonArray.Count - 1; i++)
                    {
                        txtJRead.Text += JsonArray[i].ToString() + "," + "\r\n";
                    }
                }
                else
                {
                    MessageBox.Show("Create");
                }
            }
            catch(Exception ex)
            {
                WriteLog.OliWriteLog(ex, "read() 讀取JSON錯誤, JsonFile:" + JsonFile);
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
