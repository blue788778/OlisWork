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
    public partial class ThreadBrowse : Form
    {
        public ThreadBrowse(string url)
        {
            InitializeComponent();
            try
            {
                // 開啟網址
                open(url);
            }
            catch (Exception ex)
            {
                WriteLog.WriteLogg(ex, "開啟網址", "");
            }
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
                WriteLog.WriteLogg(ex, "前往網址", "");
            }
        }

        private void ThreadBrowse_FormClosed(object sender, FormClosedEventArgs e)
        {
            webBrowser.Dispose();
        }
    }
}
