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
    public partial class DynamicNew_form : Form
    {
        int Counter = 1;
        Panel MyPan = null;
        Label MyLbl = null;
        Button MyBtn = null;
        string MyBtnSplit = "";


        public DynamicNew_form()
        {
            InitializeComponent();
        }


        // 按下按鈕動態產生Panel(含Label、button)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Counter; i++)
                {
                    // 產生Panel在預設的Panel上
                    MyPan = new Panel();
                    MyPan.Size = new Size(700, 50);
                    MyPan.Location = new Point(0, 100 * i);
                    MyPan.BackColor = Color.Gray;
                    MyPan.Name = "pan_" + Counter;
                    panShow.Controls.Add(MyPan);

                    // 產生Label在產生出的Panel上
                    MyLbl = new Label();
                    MyLbl.AutoSize = true;
                    MyLbl.Size = new Size(20, 20);
                    MyLbl.Location = new Point();
                    MyLbl.Name = "lbl_" + Counter;
                    MyLbl.Text = MyLbl.Name;
                    MyPan.Controls.Add(MyLbl);

                    // 產生Button在產生出的Panel上
                    MyBtn = new Button();
                    MyBtn.Size = new Size(100, 50);
                    MyBtn.Location = new Point(500, 0);
                    MyBtn.Name = "btn_" + Counter;
                    MyBtn.Text = MyBtn.Name;
                    MyPan.Controls.Add(MyBtn);

                    // button 的事件委派 click 事件
                    MyBtn.Click += dynamic_btn_Click;
                }
                Counter++;

                //// 滾輪滑動
                //this.panShow.AutoScroll = true;
                //Point newPoint = new Point(0, this.panShow.Height - panShow.AutoScrollPosition.Y);
                //this.panShow.AutoScrollPosition = newPoint;
            }
            catch (Exception ex)
            {
                WriteLog.OliWriteLog(ex, "btnAdd_Click() 動態產生錯誤, MyPan.Name:" + MyPan.Name + ", MyLbl.Name:" + MyLbl.Name + ", MyBtn.Name:" + MyBtn.Name);
            }
        }


        // 產生動態產生的Button事件
        private void dynamic_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // 內部轉換方法
                Button button = (Button)sender;
                // 分割成陣列 button_1, 條件用 ('_'), ["button" , "1"]
                MyBtnSplit = button.Text.Split('_')[1];

                // 在預設的Panel上產生物件的Item
                foreach (Control item in panShow.Controls)
                {
                    if (item.Name.Contains(MyBtnSplit))
                    {
                        // 在創建的Panel上產生物件的Item
                        foreach (Control item2 in item.Controls)
                        {
                            if (item2.Name.Contains("label"))
                            {
                                MyBtnSplit = item2.Text;
                            }
                        }
                    }
                }
                MessageBox.Show(MyBtnSplit);
            }
            catch(Exception ex)
            {
                WriteLog.OliWriteLog(ex, "dynamic_btn_Click() 產生動態產生事件錯誤, MyBtnSplit:" + MyBtnSplit);
            }
        }
    }
}
