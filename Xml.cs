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
        XmlDocument Document = new XmlDocument();
        string Xml_FilePath = @"C:/Users/Oli/Desktop/test.xml";
        string MyText;


        public Xml()
        {
            InitializeComponent();
        }


        // 按鈕寫入讀取
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

                    // 生成小節點
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
                WriteLog.WriteLogg(ex, "write() Xml寫入錯誤");
            }
        }


        // 讀取XML檔案
        public void read()
        {
            try
            {
                XmlReader reader = XmlReader.Create(Xml_FilePath);
                {
                    // Bool值，確認文件是否包含XML
                    while (reader.Read())
                    {
                        // 檢查文件中是否有任何起始元素
                        if (reader.IsStartElement())
                        {
                            // 判斷元素的欄位名 
                            switch (reader.Name.ToString())
                            {
                                case "Name":
                                    MyText = reader.ReadString();
                                    txtRead.Text += MyText + Environment.NewLine;
                                    break;
                                case "Age":
                                    MyText = reader.ReadString();
                                    txtRead.Text += MyText + Environment.NewLine;
                                    break;
                            }
                        }
                    }
                }
                // 清除Document
                Document.Clone();
                // 清除reader
                reader.Close();
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogg(ex, "read() Xml讀取錯誤");
            }
        }
    }
}
