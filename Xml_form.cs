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
    public partial class Xml_form : Form
    {
        XmlDocument Document = new XmlDocument();
        string Xml_FilePath = @"C:/Users/Oli/Desktop/test.xml";
        string MyText = "";


        public Xml_form()
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
                    XmlElement nameXml = Document.CreateElement("Name");
                    nameXml.InnerText = txtWrite.Text;
                    node.AppendChild(nameXml);
                    XmlElement ageXml = Document.CreateElement("Age");
                    ageXml.InnerText = txtWrite.Text;
                    node.AppendChild(ageXml);

                    Document.Save(@"C:/Users/Oli/Desktop/test.xml");
                }
                else
                {
                    // Load載入XML
                    Document.Load(Xml_FilePath);

                    // SelectSingleNode尋找節點
                    XmlNode node = Document.SelectSingleNode("test");

                    // 生成子節點
                    XmlElement nameXml = Document.CreateElement("Name");
                    nameXml.InnerText = txtWrite.Text;
                    node.AppendChild(nameXml);
                    XmlElement ageXml = Document.CreateElement("Age");
                    ageXml.InnerText = txtWrite.Text;
                    node.AppendChild(ageXml);

                    Document.Save(Xml_FilePath);

                    // 清空XML
                    Document.Clone();
                }
                MessageBox.Show("GDDDD");
            }
            catch (Exception ex)
            {
                WriteLog.OliWriteLog(ex, "write() Xml寫入錯誤, Xml_FilePath:" + Xml_FilePath + ", InnerText" + txtWrite.Text);
            }
        }


        // 讀取XML檔案
        public void read()
        {
            try
            {
                //XmlReader reader = XmlReader.Create(Xml_FilePath);
                //{
                //    // Bool值，確認文件是否包含XML
                //    while (reader.Read())
                //    {
                //        // 檢查文件中是否有任何起始元素
                //        if (reader.IsStartElement())
                //        {
                //            // 判斷元素的欄位名 
                //            switch (reader.Name.ToString())
                //            {
                //                case "Name":
                //                    MyText = reader.ReadString();
                //                    txtRead.Text += MyText + Environment.NewLine;
                //                    break;

                //                case "Age":
                //                    MyText = reader.ReadString();
                //                    txtRead.Text += MyText + Environment.NewLine;
                //                    break;

                //                default:
                //                    break;
                //            }
                //        }
                //    }
                //}
                //// 清除Document
                //Document.Clone();
                //// 清除reader
                //reader.Close();

                MyText = File.ReadAllText(Xml_FilePath);
                txtRead.Text = MyText;
            }
            catch (Exception ex)
            {
                WriteLog.OliWriteLog(ex, "read() Xml讀取錯誤, Xml_FilePath:" + Xml_FilePath);
            }
        }
    }
}
