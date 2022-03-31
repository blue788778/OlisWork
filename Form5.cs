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

namespace OlisWork
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;
        int selectedDeviceIndex = 0;

        // 開啟視窗時載入，預設的資料、處理
        private void Form5_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = new VideoCaptureDevice(videoDevices[selectedDeviceIndex].MonikerString);      // 連接鏡頭，使用預設本機的鏡頭
            videoSource.VideoResolution = videoSource.VideoCapabilities[selectedDeviceIndex];           // 解析度，使用預設本機鏡頭的解析度
            videoSourcePlayer1.VideoSource = videoSource;
            for (int i = 0; i < videoSource.VideoCapabilities.Length; i++)                              // 將本機鏡頭支援的解析度加入至ComBox的選項
            {
                string resolution_size = videoSource.VideoCapabilities[i].FrameSize.ToString();
                comboBox1.Items.Add(resolution_size);
            }
        }
        
        // 選擇解析度，選擇解析度好後會關閉鏡頭(需在按Open按鈕重開)
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            videoSource.VideoResolution = videoSource.VideoCapabilities[comboBox1.SelectedIndex];       // 選擇的解析度會=ComboBox的選項
            videoSourcePlayer1.VideoSource = videoSource;                                               // 綁定裝置的內容
            videoSourcePlayer1.Stop();

        }

        // 按下Open按鈕後開啟鏡頭
        private void button_Open_Click(object sender, EventArgs e)
        {
            videoSourcePlayer1.Start();
        }

        // 按下拍照Pic按鈕後將圖片檔案儲存至使用者選擇的位置
        private void button_Pic_Click(object sender, EventArgs e)
        {
            if (videoSource == null)
            {
                return;
            }
            Bitmap bitmap = videoSourcePlayer1.GetCurrentVideoFrame();
            string fileName = "Work" + DateTime.Now.ToString("yyyy-MM-dd") + ".jpg";    // 自訂檔案預設名字
            SaveFileDialog saveFileDialog = new SaveFileDialog();              // 給使用者選取儲存檔案的位置 / SaveFileDialog()-初始化這個類別的新執行個體
            saveFileDialog.FileName = fileName;                                // 存檔時檔案名字=檔案預設名字
            saveFileDialog.Filter = "jpeg (*.jpeg)|*.jpeg";                    // 預設檔案類型使用JPEG
            if (saveFileDialog.ShowDialog() == DialogResult.OK)                // ShowDialog()-呼叫對話方塊 / DialogResult.OK-對話方塊的傳回值
            {
                bitmap.Save(saveFileDialog.FileName);                          // 儲存檔案
                bitmap.Dispose();
            }
        }

        // 關閉視窗後也關閉使用的鏡頭
        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            videoSourcePlayer1.Stop();
        }
    }
}
