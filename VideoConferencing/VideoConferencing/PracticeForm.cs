#region Pratice Area
///<summary>
/// Pratice From to pratice all the new things for the Video Conferencing VP project
/// </summary>
#endregion

using System;
using System.Windows.Forms;

#region Aforge Library
///<summary>
/// Listed By Muhammah Junaid
/// </summary>
using AForge;
using AForge.Controls;
using AForge.Video;
using AForge.Video.DirectShow;
#endregion

#region DirectX Library
/// <summary>
/// Listed By Muhammah Junaid
/// </summary>
using DShowNET;
using DirectX.Capture;
using System.Drawing;
#endregion

namespace VideoConferencing
{
    public partial class PracticeForm : Form
    {
        //private FilterInfoCollection VideoDevices;
        //private VideoCaptureDevice captureVideo;

        Capture camCapture = null;
        Filters filterDevice = null;
        int cameraDeviceNo;
        public PracticeForm()
        {
            InitializeComponent();
            cameraDeviceNo = 0;
        }
       
        private void bt_record_Click(object sender, EventArgs e)
        {
            filterDevice = new Filters();

            showVideo(cameraDeviceNo);
        }

        private void showVideo(int cameraDeviceNo)
        {
            camCapture = new Capture(filterDevice.VideoInputDevices[0], filterDevice.AudioInputDevices[0]);
            camCapture.PreviewWindow = panel1;
            //camCapture
            camCapture.Start();


            //captureVideo = new VideoCaptureDevice(VideoDevices[cb_videoDevicesList.SelectedIndex].MonikerString);
            //captureVideo.NewFrame += new NewFrameEventHandler(captureVideo_newFrame);
        }

        private void captureVideo_newFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap video = (Bitmap) eventArgs.Frame.Clone();
            pictureBox1.Image = video;
        }

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            camCapture.Stop();
            camCapture.Dispose();
            //if (captureVideo.IsRunning)
            //{
            //    captureVideo.Stop();
            //}
        }
        //
        // listing all the video cam devices connected to the system at the moment 
        //
        private void PracticeForm_Load(object sender, EventArgs e)
        {
            //VideoDevices = new FilterInfoCollection(AForge.Video.DirectShow.FilterCategory.VideoInputDevice);
            //foreach (AForge.Video.DirectShow.FilterInfo VidDevices in VideoDevices)
            //{
            //    cb_videoDevicesList.Items.Add(VidDevices.Name);
            //}
            //cb_videoDevicesList.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterDevice = new Filters();
            //foreach (Filters device in filterDevice)
            //{

            //}
            showVideo(cameraDeviceNo);
        }
    }
}
