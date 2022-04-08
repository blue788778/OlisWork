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
                    Name = textBoxJWrite.Text,
                };
                var name = JObject.FromObject(nameJ);                          // JObject用來操作JSON物件，FromObject(nameJ)是要轉化的對象，返回一個JObject物件

                string output = JsonConvert.SerializeObject(name);             // 序列化
                File.WriteAllText(path, JsonFile + $"[{ "," + "\r\n" + output}]");
            }
            catch (Exception ex)
            {
                WriteLog.WriteLogg(ex, "寫入JSON", "");
            }
        }


        // 從JSON檔案中讀取
        public void read()
        {
            textBoxJRead.Text = "";

            try
            {
                JsonFile = File.ReadAllText(path);

                //List<NameJ> NameJ = JsonConvert.DeserializeObject<List<NameJ>>(jsonFile);

                //NameJ nameJ = new NameJ();

                //for (int i = 0; i <= NameJ.Count - 1; i++)
                //{
                //    textBoxJRead.Text += NameJ[i].Name.ToString() + Environment.NewLine;
                //}

                JArray jsonarray = JArray.Parse(JsonFile);                     // JArry是JSON的陣列

                // JsonArray陣列中有無資料
                for (int i = 0; i <= jsonarray.Count - 1; i++)                 // 查看陣列中有無資料
                {
                    textBoxJRead.Text += jsonarray[i].ToString() + "," + "\r\n";
                }
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogg(ex, "讀取JSON", "");
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // 讀取JSON文件
            read();
            // 寫入JSON文件
            write();
        }
    }
}
