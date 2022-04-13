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
using WindowsFormsApp1;

namespace OlisWork
{
    public partial class Txt_form : Form
    {
        SaveFileDialog SaveFileDialog = null;
        string TxtFilePath = "";                                               // 用來記錄當前開啟檔案路徑
        string TextLline = "";
        string MyText = "";
        string MyRead = "";


        public Txt_form()
        {
            InitializeComponent();
        }


        // 寫入Txt文件
        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fileStream = null;

                if (fileStream == null)                                        // 判斷有無資料夾
                {
                    if (TxtFilePath == "")                                     // 判斷資料夾內有無資料
                    {
                        SaveFileDialog = new SaveFileDialog();
                        SaveFileDialog.Filter = "文字檔案(*.txt)|*.txt";
                        if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            TxtFilePath = SaveFileDialog.FileName;             // 創一個檔案
                            fileStream = new FileStream(TxtFilePath, FileMode.Create);
                            fileStream.Close();

                            // * 寫入檔案的方法 *
                            //using (StreamWriter sw = File.AppendText(txt_FilePath))              // using引用，只能在{}裡，處理完就會自動消失，不需Close他 / Append方法將資料存至最後方，使用Systeam.Writer方法會覆寫
                            //{
                            //    sw.Write(textBoxWrite.Text);
                            //    sw.Write(Environment.NewLine);                                   // 換行
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

                    MyText = txtWrite.Text;
                    MyRead = "";

                    using (StreamReader sr = new StreamReader(TxtFilePath))
                    {
                        MyRead = sr.ReadToEnd();
                    }
                    File.WriteAllText(TxtFilePath, MyText + Environment.NewLine + MyRead);

                    // 讀取Txt
                    readTxt();

                    MessageBox.Show("寫入成功!");
                }
            }
            catch (Exception ex)
            {
                WriteLog.OliWriteLog(ex, "btnWrite_Click() Txt寫入錯誤, TxtFilePath:" + TxtFilePath + ", MyText:" + MyText);
            }
        }


        // 在TextBox_Read下讀取檔案的文字內容
        void readTxt()
        {
            try
            {
                if (txtRead.Text.Length != 0)                                  // 判斷裡面有幾個字元，用做判斷有無資料
                {
                    txtRead.Text = "";
                }
                StreamReader sr = new StreamReader(TxtFilePath);               // StreamReader 逐行讀取文字內容，根據自訂存檔的那個檔案路徑
                while ((TextLline = sr.ReadLine()) != null)                    // 當檔案內文字的行不=NULL時，逐行往下去讀取
                {
                    txtRead.Text += TextLline + Environment.NewLine;           // 寫入至TextBox_Read上
                }
                sr.Close();

                // * Read讀取反轉 *
                //string[] lines = File.ReadAllLines(txt_FilePath);            // File.ReadAllLines()方法逐行讀取文字檔案，ReadAllLines()是傳回一個字串陣列
                //Array.Reverse(lines);                                        // 反轉陣列Array
                //for(int i = 0; i <= lines.Length - 1; i++)                   // Length -1 是陣列時使用，字串不用
                //{
                //    textBoxRead.Text += lines[i] + Environment.NewLine;
                //}
            }
            catch(Exception ex)
            {
                WriteLog.OliWriteLog(ex, "readTxt() Txt讀取錯誤, TxtFilePath:" + TxtFilePath);
            }
        }
    }
}