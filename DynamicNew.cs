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
    public partial class DynamicNew : Form
    {
        int Counter = 1;


        public DynamicNew()
        {
            InitializeComponent();
        }


        // 按下按鈕動態產生Panel(含Label、button)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Panel myPan = new Panel();
            Label myLbl = new Label();
            Button myBtn = new Button();

            try
            {
                for (int i = 0; i < Counter; i++)
                {
                    // 產生Panel在預設的Panel上
                    myPan.Size = new Size(700, 50);
                    myPan.Name = "panel_" + Counter;
                    myPan.Location = new Point(0, 100 * i);
                    myPan.BackColor = Color.Gray;
                    panShow.Controls.Add(myPan);

                    // 產生Label在產生出的Panel上
                    myLbl = new Label();
                    myLbl.AutoSize = true;
                    myLbl.Size = new Size(20, 20);
                    myLbl.Location = new Point();
                    myLbl.Name = "label_" + Counter;
                    myLbl.Text = myLbl.Name;
                    myPan.Controls.Add(myLbl);

                    // 產生Button在產生出的Panel上
                    myBtn = new Button();
                    myBtn.Size = new Size(100, 50);
                    myBtn.Location = new Point(500, 0);
                    myBtn.Name = "button_" + Counter;
                    myBtn.Text = myBtn.Name;
                    myPan.Controls.Add(myBtn);

                    // button 的事件委派 click 事件
                    myBtn.Click += dynamic_btn_Click;
                }
                Counter++;

                //// 滾輪滑動
                //this.panShow.AutoScroll = true;
                //Point newPoint = new Point(0, this.panShow.Height - panShow.AutoScrollPosition.Y);
                //this.panShow.AutoScrollPosition = newPoint;
            }
            catch (Exception ex)
            {
                WriteLog.WriteLogg(ex, "btnAdd_Click() 動態產生錯誤");
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
                string btnSplit = button.Text.Split('_')[1];

                // 在預設的Panel上產生物件的Item
                foreach (Control item in panShow.Controls)
                {
                    if (item.Name.Contains(btnSplit))
                    {
                        // 在創建的Panel上產生物件的Item
                        foreach (Control item2 in item.Controls)
                        {
                            if (item2.Name.Contains("label"))
                            {
                                btnSplit = item2.Text;
                            }
                        }
                    }
                }
                MessageBox.Show(btnSplit);
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogg(ex, "dynamic_btn_Click() 產生動態產生事件錯誤");
            }
        }
    }
}
