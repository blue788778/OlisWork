using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
namespace OlisWork
{
    public partial class ThreadBrowse_form : Form
    {
        public ThreadBrowse_form(string url)
        {
            InitializeComponent();

            // 開啟網址
            open(url);
        }


        // 前往輸入框中的網址
        public void open(string url)
        {
            try
            {
                // 與Thread form上new_form方法聯繫
                webBrowser.Navigate(new Uri(url));
            }
            catch(Exception ex)
            {
                WriteLog.OliWriteLog(ex, "open() 前往網址錯誤");
            }
        }


        // 關閉執行緒
        private void threadBrowse_FormClosed(object sender, FormClosedEventArgs e)
        {
            webBrowser.Dispose();
        }
    }
}
