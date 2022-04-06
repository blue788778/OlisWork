using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace OlisWork
{
    public partial class Form6_XML : Form
    {
        public Form6_XML()
        {
            InitializeComponent();
        }
        
        XmlDocument document = new XmlDocument();
        string xml_FilePath = @"C:/Users/Oli/Desktop/test.xml";

        private void button1_Click(object sender, EventArgs e)
        { 
            write();
            read();          
        }
        
        public void write()
        {
            try
            {
                if (!File.Exists(xml_FilePath))
                {

                    XmlNode node = document.CreateNode(XmlNodeType.Element, "test", "");
                    document.AppendChild(node);

                    XmlElement element = document.CreateElement("Name");
                    element.InnerText = textBoxWrite.Text;
                    node.AppendChild(element);

                    XmlElement element2 = document.CreateElement("Age");
                    element2.InnerText = textBoxWrite.Text;
                    node.AppendChild(element2);

                    document.Save(@"C:/Users/Oli/Desktop/test.xml");
                }
                else
                {
                    // Load載入XML
                    document.Load(xml_FilePath);

                    // SelectSingleNode尋找節點
                    XmlNode node = document.SelectSingleNode("test");

                    //建立小節點
                    XmlElement Name = document.CreateElement("Name");
                    Name.InnerText = textBoxWrite.Text;
                    node.AppendChild(Name);
                    XmlElement Age = document.CreateElement("Age");
                    Age.InnerText = textBoxWrite.Text;
                    node.AppendChild(Age);

                    document.Save(xml_FilePath);

                    // 清空XML
                    document.Clone();
                }
                MessageBox.Show("GDDDD");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void read()
        {
            string text;

            try
            {
                XmlReader reader = XmlReader.Create(xml_FilePath);
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            //return only when you have START tag  
                            switch (reader.Name.ToString())
                            {
                                case "Name":
                                    text = reader.ReadString();
                                    textBoxRead.Text += text + Environment.NewLine;
                                    break;
                                case "Age":
                                    text = reader.ReadString();
                                    textBoxRead.Text += text + Environment.NewLine;
                                    break;
                            }
                        }
                    }
                }
                document.Clone();
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
