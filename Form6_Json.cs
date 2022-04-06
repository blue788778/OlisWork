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

namespace OlisWork
{
    public partial class Form6_Json : Form
    {
        string path = @"C:\Users\Oli\Desktop\1.json";
        string jsonFile;

        public Form6_Json()
        {
            InitializeComponent();
        }

        public class NameJ
        {
            public string Name;
        }

        public void Write()
        {
            //NameJ name = new NameJ();
            //name.Name = textBoxJWrite.Text;

            NameJ nameJ = new NameJ()
            {
                Name = textBoxJWrite.Text,
            };
            var name = JObject.FromObject(nameJ);

            string output = JsonConvert.SerializeObject(name);
            File.WriteAllText(path, jsonFile +$"[{ "," + "\r\n" + output}]");
        }

        public void Read()
        {
            textBoxJRead.Text = "";

            jsonFile = File.ReadAllText(path);

            //List<NameJ> NameJ = JsonConvert.DeserializeObject<List<NameJ>>(jsonFile);

            //NameJ nameJ = new NameJ();

            //for (int i = 0; i <= NameJ.Count - 1; i++)
            //{
            //    textBoxJRead.Text += NameJ[i].Name.ToString() + Environment.NewLine;
            //}

            JArray jsonArray = JArray.Parse(jsonFile);

            for (int i = 0; i <= jsonArray.Count - 1; i++)
            {
                textBoxJRead.Text += jsonArray[i].ToString() + "," + "\r\n";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Read();
            Write();
        }
    }
}
