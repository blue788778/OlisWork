using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlisWork
{
    public partial class Form3 : Form
    {
        int counter = 1;
        int i = 0;

        public Form3()
        {
            InitializeComponent();
        }

        // 按下按鈕動態產生Panel(含Label、button)
        private void button_Add_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            Button button = new Button();
            Label label = new Label();

            try
            {

                for (i = 0; i < counter; i++)
                {
                    panel.Size = new Size(700, 50);
                    panel.Name = "panel_" + counter;
                    panel.Location = new Point(0, 100 * i);
                    panel.BackColor = Color.Gray;
                    panel1.Controls.Add(panel);

                    label = new Label();
                    label.AutoSize = true;
                    label.Size = new Size(20, 20);
                    label.Location = new Point();
                    label.Name = "label_" + counter;
                    label.Text = label.Name;
                    panel.Controls.Add(label);

                    button = new Button();
                    button.Size = new Size(100, 50);
                    button.Location = new Point(500, 0);
                    button.Name = "button_" + counter;
                    button.Text = button.Name;
                    panel.Controls.Add(button);

                    button.Click += dynamic_button_Click;      // button 的事件委派 click 事件
                }
                counter++;

                // 滾輪滑動
                this.panel1.AutoScroll = true;
                Point newPoint = new Point(0, this.panel1.Height - panel1.AutoScrollPosition.Y);
                this.panel1.AutoScrollPosition = newPoint;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 動態產生的Button事件
        private void dynamic_button_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;                // 內部轉換方法
                string n = button.Text.Split('_')[1];          // 分割成陣列 button_1, 條件用 ('_'), ["button" , "1"]
                foreach (Control item in panel1.Controls)
                {
                    if (item.Name.Contains(n))
                    {
                        foreach (Control item2 in item.Controls)
                        {
                            if (item2.Name.Contains("label"))
                            {
                                n = item2.Text;
                            }
                        }
                    }
                }
                MessageBox.Show(n);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
