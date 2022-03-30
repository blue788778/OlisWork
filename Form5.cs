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

        private void Form5_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = new VideoCaptureDevice(videoDevices[selectedDeviceIndex].MonikerString);      // 連接攝像頭。
            videoSource.VideoResolution = videoSource.VideoCapabilities[selectedDeviceIndex];
            videoSourcePlayer1.VideoSource = videoSource;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            videoSourcePlayer1.Start();
        }
    }
}
