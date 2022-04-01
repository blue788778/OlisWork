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
        string fp = @"C:\Users\Oli\Desktop\1.json";

        public Form6_Json()
        {
            InitializeComponent();
        }

        public class NameJ
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
        }
        
        //public static object Read(string fp)
        //{
            
        //    Object obj = JsonConvert.DeserializeObject<NameJ>(File.ReadAllText(fp));
        //    return obj;
        //}
        
        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(fp);
            
            string json = sr.ReadToEnd();

            NameJ name = JsonConvert.DeserializeObject<NameJ>(json);

            MessageBox.Show(name.ToString());
        }
    }
}
