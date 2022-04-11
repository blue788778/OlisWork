using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Controls;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using WindowsFormsApp1;

namespace OlisWork
{
    public partial class WebCam : Form
    {
        public WebCam()
        {
            InitializeComponent();
        }


        FilterInfoCollection VideoDevices;
        VideoCaptureDevice VideoSource;
        int SelectedDeviceIndex = 0;


        // 開啟視窗時載入，預設的資料、處理
        private void webCam_Load(object sender, EventArgs e)
        {
            try
            {
                /// TEST
                //int a = 1;
                //int b = a / 0;

                if(VideoDevices != null)
                {
                    VideoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                    VideoSource = new VideoCaptureDevice(VideoDevices[SelectedDeviceIndex].MonikerString);       // 連接鏡頭，使用預設本機的鏡頭
                    VideoSource.VideoResolution = VideoSource.VideoCapabilities[SelectedDeviceIndex];            // 解析度，使用預設本機鏡頭的解析度
                    vspShow.VideoSource = VideoSource;

                    // 將本機鏡頭支援的解析度加入至ComBox的選項
                    for (int i = 0; i < VideoSource.VideoCapabilities.Length; i++)
                    {
                        string resolution_size = VideoSource.VideoCapabilities[i].FrameSize.ToString();
                        cboResolution.Items.Add(resolution_size);
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                WriteLog.WriteLogg(ex, "webCam_Load() 鏡頭資料載入錯誤");
            }
        }
        

        // 選擇解析度，選擇解析度好後會關閉鏡頭(需在按Open按鈕重開)
        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                VideoSource.VideoResolution = VideoSource.VideoCapabilities[cboResolution.SelectedIndex];    // 選擇的解析度會=ComboBox的選項
                vspShow.VideoSource = VideoSource;                                                           // 綁定裝置的內容
                vspShow.Stop();
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogg(ex, "cbo_SelectedIndexChanged() 裝置解析度錯誤");
            }
        }


        // 按下Open按鈕後開啟鏡頭
        private void btn_Open_Click(object sender, EventArgs e)
        {
            try
            {
                if(VideoDevices != null)
                {
                    vspShow.Start();
                }
                else
                {
                    MessageBox.Show("本機無鏡頭");
                }
            }
            catch (Exception ex)
            {
                WriteLog.WriteLogg(ex, "btn_Open_Click() 開啟鏡頭錯誤");
            }
        }


        // 按下拍照Pic按鈕後將圖片檔案儲存至使用者選擇的位置
        private void btn_Pic_Click(object sender, EventArgs e)
        {
            try
            {
                if (VideoSource == null)
                {
                    return;
                }

                Bitmap bitmap = vspShow.GetCurrentVideoFrame();
                string fileName = "Work" + DateTime.Now.ToString("yyyy-MM-dd") + ".jpg";           // 自訂檔案預設名字
                SaveFileDialog saveFileDialog = new SaveFileDialog();                              // 給使用者選取儲存檔案的位置 / SaveFileDialog()-初始化這個類別的新執行個體
                saveFileDialog.FileName = fileName;                                                // 存檔時檔案名字=檔案預設名字
                saveFileDialog.Filter = "jpeg (*.jpeg)|*.jpeg";                                    // 預設檔案類型使用JPEG

                if (saveFileDialog.ShowDialog() == DialogResult.OK)                                // ShowDialog()-呼叫對話方塊 / DialogResult.OK-對話方塊的傳回值
                {
                    bitmap.Save(saveFileDialog.FileName);                                          // 儲存檔案
                    bitmap.Dispose();
                }
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogg(ex, "btn_Pic_Click() 儲存檔案錯誤");
            }
        }


        // 關閉視窗後也關閉使用的鏡頭
        private void webCam_Closed(object sender, FormClosedEventArgs e)
        {
            try
            {
                vspShow.Stop();
            }
            catch(Exception ex)
            {
                WriteLog.WriteLogg(ex, "webCam_Closed() 關閉視窗/鏡頭錯誤");
            }
        }
    }
}
