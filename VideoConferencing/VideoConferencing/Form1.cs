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

#region Viscom Library
///<summary>
/// Listed By Muhammah Junaid
/// </summary>
using AxVideoChatSenderLib;
using AxVideoChatReceiverLib;
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

        AxVideoChatSender hostVideo = null;
        AxVideoChatReceiver remoteVideo = null;
        Capture camCapture = null;
        Filters filterDevice = null;
        int cameraDeviceNo;
        private bool videoRunning;
        string userName;
        bool _sendingConnectedAudioStream;
        bool _sendingConnectedVideoStream;
        bool _recevingConnectedAudioStream;
        bool _recevingConnectedVideoStream;

        public Main_Form(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            
            // assign the send axVideo panel to the hostVideo object
            hostVideo = axVideoChatSender1;
            remoteVideo = axVideoChatReceiver1;

            _sendingConnectedAudioStream = false;
            _sendingConnectedAudioStream = false;
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
            if (userName == "user1")
            {
                cb_panel_tabPage_Menu_Contact_View.Items.Add("User2");
            }
            else 
            {
                cb_panel_tabPage_Menu_Contact_View.Items.Add("User1");
            }
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
            //filterDevice = new Filters();
            //foreach (Filters device in filterDevice)
            //{

            //}
            //showVideo(cameraDeviceNo);
            startHostVideo();
        }
        //
        //Stop button to start the video conference
        //
        private void StopCall_Call_View_panel_Click(object sender, EventArgs e)
        {
            StopVideoConferencing();
        }

        //
        //  Stop method of stop the video conferecning
        //
        private void StopVideoConferencing()
        {
            //stop sending audio stream
            if (hostVideo.SendAudioStream)
            {
                hostVideo.SendAudioStream = false;
                hostVideo.TabStop = true;
            }

            //stop sending video steam
            if (hostVideo.SendVideoStream)
            {
                hostVideo.SendVideoStream = false;
                hostVideo.TabStop = true;
            }

            //stop receving audio stream
            if (remoteVideo.ReceiveAudioStream)
            {
               remoteVideo.ReceiveAudioStream = false;
            }

            //stop receving audio stream
            if (remoteVideo.ReceiveVideoStream)
            {
                remoteVideo.ReceiveVideoStream = false;
            }
        }


        //
        // Viscom Receive Remote Video
        //
        private void receiveRemoteVideo()
        {
            //
            // Viscom Remote Video
            //
            if (userName == "user1")
            {
                //remote audio streaming method
                remoteAudioStreaming();

                //remote video streaming method
                remoteVideoSteaming();

                //remote ip getting method
                remoteIPListening();
            }
            else if (userName == "user2")
            {
                //remote audio streaming method
                remoteAudioStreaming();

                //remote video streaming method
                remoteVideoSteaming();

                //remote ip getting method
                remoteIPListening();
            }

        }

        //
        // Remote IP Configuration
        //
        private void remoteIPListening()
        {
            if (userName == "user1")
            {

                remoteVideo.Listen("127.0.0.1", 1245);
            }
            else
            {
                remoteVideo.Listen("127.0.0.1", 1234);
            }
        }

        //
        // Remote Start video Receving 
        //
        private void remoteVideoSteaming()
        {
            _recevingConnectedVideoStream = true;
            remoteVideo.ReceiveVideoStream = true;
        }

        //
        // Remote Start audio Receving 
        //
        private void remoteAudioStreaming()
        {
            _recevingConnectedAudioStream = true;
            remoteVideo.ReceiveAudioStream = true;
        }



        //
        // Viscom Host Video
        //
        private void startHostVideo()
        {
            if (userName == "user1")
            {
                //selecting the Camera Device 
                hostCamDevice();

                //Selecting the Audio Device
                hostAudioDevice();

                //Setting the video format
                hostCamFormat();

                //Setting the audio format
                hostAudioFormat();

                //getting the remote IP
                getRemoteIPConfiguration();

                //starting the audio transmission of Host
                hostStartAudioStreaming();

                //starting the video transmission of host
                hostStartVideoStreaming();

            }
            else if (userName == "user2")
            {
                //selecting the Camera Device 
                hostCamDevice();

                //Selecting the Audio Device
                hostAudioDevice();

                //Setting the video format
                hostCamFormat();

                //Setting the audio format
                hostAudioFormat();

                //getting the remote IP
                getRemoteIPConfiguration();

                //starting the audio transmission of Host
                hostStartAudioStreaming();

                //starting the video transmission of host
                hostStartVideoStreaming();
            }

        }

        //
        // Host start sending Video streaming
        //
        private void hostStartVideoStreaming()
        {
            _sendingConnectedVideoStream = true;
            hostVideo.SendVideoStream = true;
        }

        //
        // Host start sending Audio streaming
        //
        private void hostStartAudioStreaming()
        {
            _sendingConnectedAudioStream = true;
            hostVideo.SendAudioStream = true;
        }

        //
        // Host getting the IP details of the remote
        //
        private void getRemoteIPConfiguration()
        {

            if (userName == "user1")
            {

                hostVideo.Connect("127.0.0.1", 1234);
            }
            else
            {
                hostVideo.Connect("127.0.0.1", 1245);
            }

        }


        //
        // host Audio Device Format
        //
        private void hostAudioFormat()
        {
            hostVideo.AudioComplexity = 0;
            hostVideo.AudioQuality = 8;
        }


        //
        // host Video Device Format 
        //
        private void hostCamFormat()
        {
            hostVideo.VideoFormat = 0;
            hostVideo.FrameRate = 30;
            hostVideo.VideoBitrate = 1280000;
        }


        //
        // host Audio Device Seletion Procedure
        //
        private void hostAudioDevice()
        {
            hostVideo.AudioDevice = 0;
        }

        //
        // host Video Device Seletion Procedure
        //
        private void hostCamDevice()
        {
            if (userName == "user1")
                hostVideo.VideoDevice = 0;
            else
            {
                int videdDeviceCount = hostVideo.GetVideoDeviceCount();
                //Console.WriteLine(arr);
                //MessageBox.Show(arr.ToString());
                //Console.ReadLine();
                hostVideo.VideoDevice = 0;
            }

        }



        //showVideo Method for assignment

        private void showVideo(int cameraDeviceNo)
        {
            //camCapture = new Capture(filterDevice.VideoInputDevices[0], filterDevice.AudioInputDevices[0]);
            ////camCapture.PreviewWindow = panel_CallMenu_host;
            ////camCapture
            //camCapture.Start();
            //videoRunning = true;

            //captureVideo = new VideoCaptureDevice(VideoDevices[cb_videoDevicesList.SelectedIndex].MonikerString);
            //captureVideo.NewFrame += new NewFrameEventHandler(captureVideo_newFrame);
        }

        //
        //Disconnet button to stop the video conferencing
        //
        private void bt_disconnect_panel_CallMenu_Click(object sender, EventArgs e)
        {
            receiveRemoteVideo();
            //camCapture.Stop();
            //camCapture.Dispose();
        }
        //
        //To stop the video conferencing 
        //and release the resources if the disconnet button is not pressed
        //
        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
              //camCapture.Stop();
              //camCapture.Dispose();
            
        }

        private void bt_panel_tabPage_Menu_Contacts_View_Click(object sender, EventArgs e)
        {
            panel_CallMenu.Visible = true;
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form Login_Form = new Login_Form();
            Login_Form.ShowDialog();
        }

        //
        // stop button to stop the video call
        //
        private void bt_stop_call_Menu_Click(object sender, EventArgs e)
        {
            if(userName== "user1")
            {
                stopPeer1HostVideoCall();
                stopPeer1RemoteVideoCall();
            }
            else
            {
                stopPeer2HostVideoCall();
                stopPeer2RemoteVideoCall();
            }
        }

        private void stopPeer2RemoteVideoCall()
        {
            stopHostRecevingPacket();
        }

        private void stopPeer2HostVideoCall()
        {
            stopHostSendingPacket();
        }

        //
        // Method to stop the receving video call of Peer 1
        //
        private void stopPeer1RemoteVideoCall()
        {
            stopHostRecevingPacket();
        }


        //
        // Method to stop the receving part video call of Peer 1
        //
        private void stopHostRecevingPacket()
        {
            if(_recevingConnectedVideoStream && _recevingConnectedAudioStream)
            {
                remoteVideo.Disconnect();
            }
        }


        //
        // Method to stop the sending part video call of Peer 1
        //
        private void stopPeer1HostVideoCall()
        {
            stopHostSendingPacket();
        }

        //
        // to stop host call of peer 1
        //
        private void stopHostSendingPacket()
        {
            if (_sendingConnectedVideoStream && _sendingConnectedAudioStream)
            {
                hostVideo.Disconnect();
            }
            
        }
    }
}