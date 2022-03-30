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
    public partial class Form1 : Form
    {

        Graphics graphics;
        int FirstPointX, FirstPointY;                                          // FirstPointX, FirstPointY 是繪圖起點的座標(X,Y)，MouseDown事件發生時的預設位置
        Pen pen;
        string select;                                                         // 右鍵選擇時能夠做判斷

        public Form1()
        {
            InitializeComponent();
            SetBitmap();                                                       // 一開始就把Bitmap建立好
        }

        // 建立一個繪圖用的Bitmap
        public void SetBitmap()
        {
            drawPanel.Image = new Bitmap(800, 600);                            // 建立一個800x600的點陣圖做DrawPanel的Image
            graphics = Graphics.FromImage(drawPanel.Image);                    // 宣告一個graphics的繪圖物件(Graphics)，會執行繪圖動作在DrawPanel.Image(pictureBox工具)
            graphics.Clear(Color.White);                                       // 使用graphics將Image清除為白底
        }

        // 小畫家塗鴉時滑鼠壓下後的起點
        private void Draw_FirstPoint_Down(object sender, MouseEventArgs e)
        {
            pen = new Pen(colorDialog1.Color, int.Parse(toolStripComboBox1.Text));       // 宣告新畫筆(new Pen)，顏色來自colorDialog1的Color屬性，筆的粗細來自下拉選單(toolStripComboBox1)的文字
            
            if (e.Button == MouseButtons.Left)
            {
                switch (select)                                                // 判斷有無右鍵選擇過形狀
                {
                    case "Elselected":                                         // 選擇是圓形的話
                        
                        graphics.DrawEllipse(pen, e.X, e.Y, 40, 40);           // 繪圖物件graphics畫一個圓形(DrawEllipse)，使用上述之新畫筆，位置為滑鼠點擊(e.X,e.Y)位置，大小40x40
                        drawPanel.Refresh();                                   // 更新(Refresh)容器內的影像內容
                        break;

                    case "Reselected":                                         // 選擇是方形的話

                        graphics.DrawRectangle(pen, e.X, e.Y, 50, 50);         // 繪圖物件graphics畫一個方形(DrawRectangle)，使用上述之新畫筆，位置為滑鼠點擊(e.X,e.Y)位置，大小50x50
                        drawPanel.Refresh();                                   // 更新(Refresh)容器內的影像內容
                        break;

                    default:
                        FirstPointX = e.X;                                     // 繪製線條時滑鼠線條的第一個位置
                        FirstPointY = e.Y;
                        break;
                }
            }
        }
        // 塗鴉時壓下滑鼠後繼續壓住到新的一點
        private void Draw_ToNewPoint_Move(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)                                 // 判斷壓下的是不是左鍵
            {
                switch (select)
                {
                    case "Elselected":
                        break;
                    case "Reselected":
                        break;
                    default:
                        pen = new Pen(colorDialog1.Color, int.Parse(toolStripComboBox1.Text));     // 宣告新畫筆(new Pen)，顏色來自colorDialog1的Color屬性，筆的粗細來自下拉選單(toolStripComboBox1)的文字

                        graphics.DrawLine(pen, FirstPointX, FirstPointY, e.X, e.Y);      // 繪圖物件graphics畫一個線段(DrawLine)，使用上述之新畫筆，起點為(FirstPointX, FirstPointY)到(e.X, e.Y)

                        FirstPointX = e.X;                                               // 畫完後將終點變成新的起點(FirstPointX = e.X、FirstPointY = e.Y)
                        FirstPointY = e.Y;

                        drawPanel.Refresh();                                             // 更新(Refresh)容器內的影像內容
                        break;
                }
            }
        }
        
        // 彈出右鍵菜單
        private void MenuCircle_Up(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip_Circle.Show(drawPanel, e.Location);           // 菜單Show在右鍵的位置上
            }
        }

        // 右鍵菜單點擊圓形時
        private void ToolStripMenuItem_Round_Click(object sender, EventArgs e)
        {
            select = "Elselected";                                             // //設一個Elselected能做判斷
        }

        // 右鍵菜單點方形時
        private void ToolStripMenuItem_Rect_Click(object sender, EventArgs e)
        {
            select = "Reselected";                                             // 設一個Reselected能做判斷
        }

        // 將ColorDialog選色方塊顯示出來供使用者選色
        private void SetPenColorItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();           
        }
    }
}
