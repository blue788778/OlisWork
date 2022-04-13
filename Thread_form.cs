using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace OlisWork
{
    public partial class Thread_form : Form
    {
        Thread myThread = null;
        ThreadBrowse_form myThreadBrowse = null;


        public Thread_form()
        {
            InitializeComponent();
        }


        // 新建執行緒
        private void threadNew()
        {
            try
            {
                // 執行新建執行緒
                myThread = new Thread(new ThreadStart(new_form));
                myThread.SetApartmentState(ApartmentState.STA);
                myThread.Start();
            }
            catch (Exception ex)
            {
                WriteLog.OliWriteLog(ex, "threadNew() 新建執行緒錯誤, myThread:" + myThread);
            }
        }


        // 將資料傳至NEW Browse物件
        public void new_form()
        {
            try
            {
                if(txtUrl.Text.Length != 0)
                {
                    myThreadBrowse = new ThreadBrowse_form(txtUrl.Text);
                    myThreadBrowse.ShowDialog();
                }
                else
                {
                    MessageBox.Show("請輸入網址");
                }

            }
            catch(Exception ex)
            {
                WriteLog.OliWriteLog(ex, "new_form() 傳資料至New Browse錯誤, myThreadBrowse:" + myThreadBrowse);
            }
        }


        // 按下生成按鈕開始執行緒
        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                // 執行新建執行緒
                threadNew();
            }
            catch (Exception ex)
            {
                WriteLog.OliWriteLog(ex, "btn_Click() 開始執行緒錯誤");
            }
        }


        // 按下Enter開始執行緒
        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    // 執行新建執行緒
                    threadNew();
                }
            }
            catch (Exception ex)
            {
                WriteLog.OliWriteLog(ex, "txtUrl_KeyDown() 開始執行緒錯誤");
            }
        }
    }
}
