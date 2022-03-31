using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OlisWork
{
    public partial class Form6 : Form
    {

        string txt_FilePath = "";                          // 用來記錄當前開啟檔案路徑
        public Form6()
        {
            InitializeComponent();
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            if (fileStream == null)                                            // 判斷有無資料夾
            {
                if (txt_FilePath == "")                                        // 判斷資料夾內有無資料
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "文字檔案(*.txt)|*.txt";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txt_FilePath = saveFileDialog.FileName; // 創一個檔案
                        fileStream = new FileStream(txt_FilePath, FileMode.Create);
                        fileStream.Close();

                        // * 寫入檔案的方法 *
                        //using (StreamWriter sw = File.AppendText(txt_FilePath))            // using引用，只能在{}裡，處理完就會自動消失，不需Close他 / Append方法將資料存至最後方，使用Systeam.Writer方法會覆寫
                        //{
                        //    sw.Write(textBoxWrite.Text);
                        //    sw.Write(Environment.NewLine);                                 // 換行
                        //}
                        //using (StreamWriter sw = new StreamWriter(txt_FilePath, true))       // 一開始輸入內容
                        //{
                        //    sw.WriteLine(textBoxWrite.Text);
                        //}
                    }
                    else
                    {
                        MessageBox.Show("請開啟txt檔案");
                    }
                }
                string text = textBoxWrite.Text;
                string read = "";
                using(StreamReader sr = new StreamReader(txt_FilePath))
                {
                    read = sr.ReadToEnd();
                }
                File.WriteAllText(txt_FilePath, text+ Environment.NewLine + read );

                ReadTxt();

                MessageBox.Show("Gooddddddddddddddddd !");
            }
        }
        // 在TextBox_Read下讀取檔案的文字內容
        void ReadTxt()
        {
            string line;
            if (textBoxRead.Text.Length != 0)                                  // 判斷裡面有幾個字元，用做判斷有無資料
            {
                textBoxRead.Text = "";
            }
            StreamReader sr = new StreamReader(txt_FilePath);                // StreamReader 逐行讀取文字內容，根據自訂存檔的那個檔案路徑
            while ((line = sr.ReadLine()) != null)                           // 當檔案內文字的行不=NULL時，逐行往下去讀取
            {
                textBoxRead.Text += line + Environment.NewLine;              // 寫入至TextBox_Read上
            }
            sr.Close();

            // * Read讀取反轉 *
            //string[] lines = File.ReadAllLines(txt_FilePath);                  // File.ReadAllLines()方法逐行讀取文字檔案，ReadAllLines()是傳回一個字串陣列
            //Array.Reverse(lines);                                              // 反轉陣列Array
            //for(int i = 0; i <= lines.Length - 1; i++)                         // Length -1 是陣列時使用，字串不用
            //{
            //    textBoxRead.Text += lines[i] + Environment.NewLine;
            //}
        }
    }
}