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
using WindowsFormsApp1;

namespace OlisWork
{
    public partial class Xml : Form
    {
        public Xml()
        {
            InitializeComponent();
        }
        
        XmlDocument Document = new XmlDocument();
        string Xml_FilePath = @"C:/Users/Oli/Desktop/test.xml";


        // 按鈕事件
        private void btn_Click(object sender, EventArgs e)
        { 
            // 寫進XML文件
            write();

            // 讀取XML文件
            read();          
        }
        

        // 寫入XML檔案
        public void write()
        {
            try
            {
                // 如果沒有XML檔會創建
                if (!File.Exists(Xml_FilePath))
                {
                    // 生成根節點
                    XmlNode node = Document.CreateNode(XmlNodeType.Element, "test", "");
                    Document.AppendChild(node);
                    
                    // 生成子節點
                    XmlElement element = Document.CreateElement("Name");
                    element.InnerText = txtWrite.Text;
                    node.AppendChild(element);

                    // 生成子節點
                    XmlElement element2 = Document.CreateElement("Age");
                    element2.InnerText = txtWrite.Text;
                    node.AppendChild(element2);

                    Document.Save(@"C:/Users/Oli/Desktop/test.xml");
                }
                else
                {
                    // Load載入XML
                    Document.Load(Xml_FilePath);

                    // SelectSingleNode尋找節點
                    XmlNode node = Document.SelectSingleNode("test");

                    //建立小節點
                    XmlElement Name = Document.CreateElement("Name");
                    Name.InnerText = txtWrite.Text;
                    node.AppendChild(Name);
                    XmlElement Age = Document.CreateElement("Age");
                    Age.InnerText = txtWrite.Text;
                    node.AppendChild(Age);

                    Document.Save(Xml_FilePath);

                    // 清空XML
                    Document.Clone();
                }
                MessageBox.Show("GDDDD");
            }
            catch (Exception ex)
            {
                WriteLog.WriteLogg(ex, "Xml寫入", "");
            }
        }


        // 讀取XML檔案
        public void read()
        {
            string text;

            try
            {
                XmlReader reader = XmlReader.Create(Xml_FilePath);
                {
                    // BOOL值，確認文件是否包含XML
                    while (reader.Read())
                    {
                        // 檢查文件中是否有任何起始元素
                        if (reader.IsStartElement())
                        {
                            // 判斷元素的欄位名 
                            switch (reader.Name.ToString())
                            {
                                case "Name":
                                    text = reader.ReadString();
                                    txtRead.Text += text + Environment.NewLine;
                                    break;
                                case "Age":
                                    text = reader.ReadString();
                                    txtRead.Text += text + Environment.NewLine;
                                    break;
                            }
                        }
                    }
                }
                // 清除Document
                Document.Clone();
                reader.Close();
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogg(ex, "Xml讀取", "");
            }
        }
    }
}
