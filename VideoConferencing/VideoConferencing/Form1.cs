using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public partial class Main_Form : Form
    {
        //private FilterInfoCollection VideoDevices;
        //private VideoCaptureDevice captureVideo;

        Capture camCapture = null;
        Filters filterDevice = null;
        int cameraDeviceNo;

        public Main_Form()
        {
            InitializeComponent();

        }

        /// <summary>
        /// TabPage Menu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //ToolStripMenuItem Contacts, ToolStripMenu SubItem Add
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_tabPage_Menu_Delete.Visible = false;
            panel_tabPage_Menu_View.Visible = false;
            panel_tabPage_Menu_Add.Visible = true;
        }

        // ToolStripMenuItem Contacts, ToolStripMenu SubItem View

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_tabPage_Menu_Delete.Visible = false;
            panel_tabPage_Menu_Add.Visible = false;
            panel_tabPage_Menu_View.Visible = true;
        }

        // ToolStripMenuItem Contacts, ToolStripMenu SubItem Delete

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_tabPage_Menu_View.Visible = false;
            panel_tabPage_Menu_Add.Visible = false;
            panel_tabPage_Menu_Delete.Visible = true;
        }

        //
        //Call button to start the video conference
        //
        private void bt_call_panel_CallMenu_Click(object sender, EventArgs e)
        {
            filterDevice = new Filters();
            //foreach (Filters device in filterDevice)
            //{

            //}
            showVideo(cameraDeviceNo);
        }

        //showVideo Method for assignment

        private void showVideo(int cameraDeviceNo)
        {
            camCapture = new Capture(filterDevice.VideoInputDevices[0], filterDevice.AudioInputDevices[0]);
            camCapture.PreviewWindow = panel_CallMenu_host;
            //camCapture
            camCapture.Start();


            //captureVideo = new VideoCaptureDevice(VideoDevices[cb_videoDevicesList.SelectedIndex].MonikerString);
            //captureVideo.NewFrame += new NewFrameEventHandler(captureVideo_newFrame);
        }

        //
        //Disconnet button to stop the video conferencing
        //
        private void bt_disconnect_panel_CallMenu_Click(object sender, EventArgs e)
        {
            camCapture.Stop();
            camCapture.Dispose();
        }
        //
        //To stop the video conferencing 
        //and release the resources if the disconnet button is not pressed
        //
        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            camCapture.Stop();
            camCapture.Dispose();
        }

        private void bt_panel_tabPage_Menu_Contacts_View_Click(object sender, EventArgs e)
        {
            panel_CallMenu.Visible = true;
        }
    }
}
