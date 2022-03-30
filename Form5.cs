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
        bool isStart = false;

        private void Form5_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = new VideoCaptureDevice(videoDevices[selectedDeviceIndex].MonikerString);      // 連接攝像頭。
            videoSource.VideoResolution = videoSource.VideoCapabilities[selectedDeviceIndex];
            videoSourcePlayer1.VideoSource = videoSource;
            for (int i = 0; i < videoSource.VideoCapabilities.Length; i++)
            {
                //string resolution = "Resolution Number" + Convert.ToString(i);
                string resolution_size = videoSource.VideoCapabilities[i].FrameSize.ToString();
                comboBox1.Items.Add(resolution_size);
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isStart == true)
            {
                videoSourcePlayer1.Stop();
            }
            isStart = true;
            videoSource.VideoResolution = videoSource.VideoCapabilities[comboBox1.SelectedIndex];
            videoSourcePlayer1.VideoSource = videoSource;
            videoSourcePlayer1.Start();

        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            videoSourcePlayer1.Start();
        }

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
            if (saveFileDialog.ShowDialog() == DialogResult.OK)                // ShowDialog()-呼叫對話方塊 / DialogResult.OK-對話方塊的傳回值
            {
                bitmap.Save(saveFileDialog.FileName);                          // 儲存檔案
                bitmap.Dispose();
            }
        }
    }
}
