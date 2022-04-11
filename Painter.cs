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
    public partial class Painter : Form
    {
        Graphics MyGraphics;
        Pen myPen;
        int FirstPointX, FirstPointY;                                                                   // FirstPointX, FirstPointY 是繪圖起點的座標(X,Y)，MouseDown事件發生時的預設位置
        int FirstX, FirstY, EndX, EndY;
        string ShapeSelect;                                                                             // 右鍵選擇時能夠做判斷


        public Painter()
        {
            InitializeComponent();
            setBitmap();                                                                                // 一開始就把Bitmap建立好
        }
        

        // 建立一個繪圖用的Bitmap
        public void setBitmap()
        {
            panDraw.Image = new Bitmap(800, 600);                                                       // 建立一個800x600的點陣圖做DrawPanel的Image
            MyGraphics = Graphics.FromImage(panDraw.Image);                                             // 宣告一個graphics的繪圖物件(Graphics)，會執行繪圖動作在DrawPanel.Image(pictureBox工具)
            MyGraphics.Clear(Color.White);                                                              // 使用graphics將Image清除為白底
        }


        // 小畫家塗鴉時滑鼠壓下後的起點
        private void panDraw_firstpoint_Down(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    FirstPointX = e.X;                                                                  // 繪製時滑鼠線條的第一個位置
                    FirstPointY = e.Y;
                }
            }
            catch (Exception ex)
            {
                WriteLog.WriteLogg(ex, "panDraw_firstpoint_Down() 塗鴉起始點錯誤");
            }
        }


        // 塗鴉時壓下滑鼠後繼續壓住到新的一點
        private void panDraw_tonewpoint_Move(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)                                                      // 判斷壓下的是不是左鍵
                {
                    // 判斷選擇的形狀
                    switch (ShapeSelect)
                    {
                        case "Elselected":                                                              // 選擇是圓形的話
                            break;

                        case "Reselected":                                                              // 選擇是方形的話
                            break;

                        default:
                            MyGraphics.DrawLine(myPen, FirstPointX, FirstPointY, e.X, e.Y);             // 繪圖物件graphics畫一個線段(DrawLine)，使用上述之新畫筆，起點為(FirstPointX, FirstPointY)到(e.X, e.Y)

                            FirstPointX = e.X;                                                          // 畫完後將終點變成新的起點(FirstPointX = e.X、FirstPointY = e.Y)
                            FirstPointY = e.Y;

                            panDraw.Refresh();                                                          // 更新(Refresh)容器內的影像內容
                            break;
                    }
                }
                FirstX = e.X;
                FirstY = e.Y;
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogg(ex, "panDraw_tonewpoint_Move() 塗鴉移動至結束點錯誤");
            }
        }


        // 彈出右鍵菜單
        private void menuShape_Up(object sender, MouseEventArgs e)
        {
            try
            {
                myPen = new Pen(colorDialog1.Color, int.Parse(toolStripComboBox1.Text));                // 宣告新畫筆(new Pen)，顏色來自colorDialog1的Color屬性，筆的粗細來自下拉選單(toolStripComboBox1)的文字
                EndX = FirstX - FirstPointX;
                EndY = FirstY - FirstPointY;

                if (e.Button == MouseButtons.Right)                                                     // 如果按的是右鍵
                {
                    ctms_Circle.Show(panDraw, e.Location);                                              // 菜單Show在右鍵的位置上
                }
                else
                {
                    switch (ShapeSelect)                                                                // 選擇的形狀
                    {
                        case "Elselected":
                            MyGraphics.DrawEllipse(myPen, FirstPointX, FirstPointY, EndX, EndY);
                            panDraw.Refresh();
                            break;

                        case "Reselected":
                            MyGraphics.DrawRectangle(myPen, FirstPointX, FirstPointY, EndX, EndY);
                            panDraw.Refresh();
                            break;
                        case "Lineselected":
                            MyGraphics.DrawLine(myPen, FirstPointX, FirstPointY, FirstX, FirstY);
                            panDraw.Refresh();
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogg(ex, "menuShape_Up() 彈出右鍵視窗選擇錯誤");
            }
        }


        // 右鍵菜單點擊圓形時
        private void tspMenu_Round_Click(object sender, EventArgs e)
        {
            ShapeSelect = "Elselected";                                                                 //設一個Elselected能做判斷
        }


        // 右鍵菜點擊方形時
        private void tspMenu_Rect_Click(object sender, EventArgs e)
        {
            ShapeSelect = "Reselected";                                                                 // 設一個Reselected能做判斷
        }


        // 右鍵菜單點擊線條時
        private void tspMenuLine_Click(object sender, EventArgs e)
        {
            ShapeSelect = "Lineselected";
        }


        // 將ColorDialog選色方塊顯示出來供使用者選色
        private void SetPenColorItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}
