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
    public partial class Thread : Form
    {
        public Thread()
        {
            InitializeComponent();
        }


        // 按下生成按鈕開始執行緒
        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                // 新建執行緒
                System.Threading.Thread myThread = new System.Threading.Thread(new ThreadStart(new_form));
                myThread.SetApartmentState(ApartmentState.STA);
                myThread.Start();
            }
            catch (Exception ex)
            {
                WriteLog.WriteLogg(ex, "開始執行緒", "");
            }
        }


        // 將資料傳至NEW Browse物件
        public void new_form()
        {
            ThreadBrowse myThreadBrowse = new ThreadBrowse(txtUrl.Text);
            myThreadBrowse.ShowDialog();
        }
    }
}
