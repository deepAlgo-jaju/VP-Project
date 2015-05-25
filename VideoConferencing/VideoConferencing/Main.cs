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

//#region Viscom Library
/////<summary>
///// Listed By Muhammah Junaid
///// </summary>
//using AxVideoChatSenderLib;
//using AxVideoChatReceiverLib;
//#endregion

#region DirectX Library
/// <summary>
/// Listed By Muhammah Junaid
/// </summary>

using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Net;
using Voice;
using System.Threading;
using DirectX.Capture;
using DirectX;
using DShowNET;
#endregion

namespace VideoConferencing
{
    public partial class Main_Form : Form
    {
        #region old variables
        //private FilterInfoCollection VideoDevices;
        //private VideoCaptureDevice captureVideo;

        //AxVideoChatSender hostVideo = null;
        //AxVideoChatReceiver remoteVideo = null;
        //Capture camCapture = null;
        //Filters filterDevice = null;
        int cameraDeviceNo;
        private bool videoRunning;
        string userName;
        bool _sendingConnectedAudioStream;
        bool _sendingConnectedVideoStream;
        bool _recevingConnectedAudioStream;
        bool _recevingConnectedVideoStream;
        int SendingVideoPort;
        int RecievingVideoPort;
        int SendingControlsPort;
        int RecievingControlsPort;
        int SendingVoicePort;
        int RecievingVoicePort;
        #endregion

        #region New variables For WebCam_Capture Library Use
        //private WaveOutPlayer m_Player;
        //private WaveInRecorder m_Recorder;
       // private FifoStream m_Fifo = new FifoStream();
        private Socket socket;
        private Thread voiceth;
        private bool connected = false;
        //private byte[] m_PlayBuffer;
        //private byte[] m_RecBuffer;
        TcpClient myclient;
        MemoryStream ms;
        NetworkStream myns;
        BinaryWriter mysw;
        Thread videoth;
        TcpListener mytcpl;
        NetworkStream ns;
        Socket mysocket;
        #endregion

        #region old code
        public Main_Form(string userName)
        {
            InitializeComponent();
            this.userName = userName;

            capture = new Capture(filters.VideoInputDevices[0], filters.AudioInputDevices[0]);
            // assign the send axVideo panel to the hostVideo object
            //hostVideo = axVideoChatSender1;
            //remoteVideo = axVideoChatReceiver1;

            //_sendingConnectedAudioStream = false;
            //_sendingConnectedAudioStream = false;

            //if (userName == "user1")
            //{
            //    this.Text = "Peer1";
            //    SendingVideoPort = 50000;
            //    RecievingVideoPort = 50001;
            //    SendingControlsPort = 50002;
            //    RecievingControlsPort = 50003;
            //    SendingVoicePort = 50006;
            //    RecievingVoicePort = 50007;
            //}
            //else if (userName == "user2")
            //{
            //    this.Text = "Peer2";
            //    SendingVideoPort = 50001;
            //    RecievingVideoPort = 50000;
            //    SendingControlsPort = 50003;
            //    RecievingControlsPort = 50002;
            //    SendingVoicePort = 50007;
            //    RecievingVoicePort = 50006;
            //}

            if (userName == "user1")
            {
                //r = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                //t = new Thread(new ThreadStart(Voice_In));
                PeerIP_TXT.Text = "169.254.170.108";
            }
            else if (userName == "user2")
            {
                //r = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                //t = new Thread(new ThreadStart(Voice_In));
                PeerIP_TXT.Text = "169.254.98.87";
            }
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
            //startHostVideo();
        }
        //
        //Stop button to start the video conference
        //
        private void StopCall_Call_View_panel_Click(object sender, EventArgs e)
        {
            //StopVideoConferencing();
        }

        //
        //  Stop method of stop the video conferecning
        //
        //private void StopVideoConferencing()
        //{
        //    //stop sending audio stream
        //    if (hostVideo.SendAudioStream)
        //    {
        //        hostVideo.SendAudioStream = false;
        //        hostVideo.TabStop = true;
        //    }

        //    //stop sending video steam
        //    if (hostVideo.SendVideoStream)
        //    {
        //        hostVideo.SendVideoStream = false;
        //        hostVideo.TabStop = true;
        //    }

        //    //stop receving audio stream
        //    if (remoteVideo.ReceiveAudioStream)
        //    {
        //       remoteVideo.ReceiveAudioStream = false;
        //    }

        //    //stop receving audio stream
        //    if (remoteVideo.ReceiveVideoStream)
        //    {
        //        remoteVideo.ReceiveVideoStream = false;
        //    }
        //}


        ////
        //// Viscom Receive Remote Video
        ////
        //private void receiveRemoteVideo()
        //{
        //    //
        //    // Viscom Remote Video
        //    //
        //    if (userName == "user1")
        //    {
        //        //remote audio streaming method
        //        remoteAudioStreaming();

        //        //remote video streaming method
        //        remoteVideoSteaming();

        //        //remote ip getting method
        //        remoteIPListening();
        //    }
        //    else if (userName == "user2")
        //    {
        //        //remote audio streaming method
        //        remoteAudioStreaming();

        //        //remote video streaming method
        //        remoteVideoSteaming();

        //        //remote ip getting method
        //        remoteIPListening();
        //    }

        //}

        ////
        //// Remote IP Configuration
        ////
        //private void remoteIPListening()
        //{
        //    if (userName == "user1")
        //    {

        //        remoteVideo.Listen("127.0.0.1", 1245);
        //    }
        //    else
        //    {
        //        remoteVideo.Listen("127.0.0.1", 1234);
        //    }
        //}

        ////
        //// Remote Start video Receving 
        ////
        //private void remoteVideoSteaming()
        //{
        //    _recevingConnectedVideoStream = true;
        //    remoteVideo.ReceiveVideoStream = true;
        //}

        ////
        //// Remote Start audio Receving 
        ////
        //private void remoteAudioStreaming()
        //{
        //    _recevingConnectedAudioStream = true;
        //    remoteVideo.ReceiveAudioStream = true;
        //}



        ////
        //// Viscom Host Video
        ////
        //private void startHostVideo()
        //{
        //    if (userName == "user1")
        //    {
        //        //selecting the Camera Device 
        //        hostCamDevice();

        //        //Selecting the Audio Device
        //        hostAudioDevice();

        //        //Setting the video format
        //        hostCamFormat();

        //        //Setting the audio format
        //        hostAudioFormat();

        //        //getting the remote IP
        //        getRemoteIPConfiguration();

        //        //starting the audio transmission of Host
        //        hostStartAudioStreaming();

        //        //starting the video transmission of host
        //        hostStartVideoStreaming();

        //    }
        //    else if (userName == "user2")
        //    {
        //        //selecting the Camera Device 
        //        hostCamDevice();

        //        //Selecting the Audio Device
        //        hostAudioDevice();

        //        //Setting the video format
        //        hostCamFormat();

        //        //Setting the audio format
        //        hostAudioFormat();

        //        //getting the remote IP
        //        getRemoteIPConfiguration();

        //        //starting the audio transmission of Host
        //        hostStartAudioStreaming();

        //        //starting the video transmission of host
        //        hostStartVideoStreaming();
        //    }

        //}

        ////
        //// Host start sending Video streaming
        ////
        //private void hostStartVideoStreaming()
        //{
        //    _sendingConnectedVideoStream = true;
        //    hostVideo.SendVideoStream = true;

        //    //MemoryStream ms = new MemoryStream();

        //    //Socket _sendToUser2 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        //    //IPEndPoint sending_end_point = new IPEndPoint(IPAddress.Parse("127.0.0.1"), SendingVideoPort);

        //    //pictureBoxPeer1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

        //    //hostVideo.
        //}

        ////
        //// Host start sending Audio streaming
        ////
        //private void hostStartAudioStreaming()
        //{
        //    _sendingConnectedAudioStream = true;
        //    hostVideo.SendAudioStream = true;
        //}

        ////
        //// Host getting the IP details of the remote
        ////
        //private void getRemoteIPConfiguration()
        //{

        //    if (userName == "user1")
        //    {

        //        hostVideo.Connect("127.0.0.1", 1234);
        //    }
        //    else
        //    {
        //        hostVideo.Connect("127.0.0.1", 1245);
        //    }

        //}


        ////
        //// host Audio Device Format
        ////
        //private void hostAudioFormat()
        //{
        //    hostVideo.AudioComplexity = 0;
        //    hostVideo.AudioQuality = 8;
        //}


        ////
        //// host Video Device Format 
        ////
        //private void hostCamFormat()
        //{
        //    hostVideo.VideoFormat = 0;
        //    hostVideo.FrameRate = 30;
        //    hostVideo.VideoBitrate = 1280000;
        //}


        ////
        //// host Audio Device Seletion Procedure
        ////
        //private void hostAudioDevice()
        //{
        //    hostVideo.AudioDevice = 0;
        //}

        ////
        //// host Video Device Seletion Procedure
        ////
        //private void hostCamDevice()
        //{
        //    if (userName == "user1")
        //    {
        //        hostVideo.VideoDevice = 0;
                
        //    }
        //    else
        //    {
        //        int videdDeviceCount = hostVideo.GetVideoDeviceCount();
        //        //Console.WriteLine(arr);
        //        //MessageBox.Show(arr.ToString());
        //        //Console.ReadLine();
        //        hostVideo.VideoDevice = 0;
        //    }

        //}



        ////showVideo Method for assignment

        //private void showVideo(int cameraDeviceNo)
        //{
        //    //camCapture = new Capture(filterDevice.VideoInputDevices[0], filterDevice.AudioInputDevices[0]);
        //    ////camCapture.PreviewWindow = panel_CallMenu_host;
        //    ////camCapture
        //    //camCapture.Start();
        //    //videoRunning = true;

        //    //captureVideo = new VideoCaptureDevice(VideoDevices[cb_videoDevicesList.SelectedIndex].MonikerString);
        //    //captureVideo.NewFrame += new NewFrameEventHandler(captureVideo_newFrame);
        //}

        ////
        ////Disconnet button to stop the video conferencing
        ////
        //private void bt_disconnect_panel_CallMenu_Click(object sender, EventArgs e)
        //{
        //    receiveRemoteVideo();
        //    //camCapture.Stop();
        //    //camCapture.Dispose();
        //}
        ////
        ////To stop the video conferencing 
        ////and release the resources if the disconnet button is not pressed
        ////
        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
              //camCapture.Stop();
              ////camCapture.Dispose();
            
        }

        private void bt_panel_tabPage_Menu_Contacts_View_Click(object sender, EventArgs e)
        {
            //panel_CallMenu.Visible = true;
            if (userName == "user1")
            {
                //pnl_user1.Visible = true;
                pnl_directXCall.Visible = true;
            }
            else if(userName == "user2")
            {
                //pnl_user2.Visible = true;
                pnl_directXCall.Visible = true;
            }
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
            //stopHostSendingPacket();
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
                //remoteVideo.Disconnect();
            }
        }


        //
        // Method to stop the sending part video call of Peer 1
        //
        private void stopPeer1HostVideoCall()
        {
            //stopHostSendingPacket();
        }

        //
        // to stop host call of peer 1
        //
        //private void stopHostSendingPacket()
        //{
        //    if (_sendingConnectedVideoStream && _sendingConnectedAudioStream)
        //    {
        //        hostVideo.Disconnect();
        //    }
            
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //short num = hostVideo.GetVideoDeviceCount();
            //string name = hostVideo.GetVideoDeviceName(1);
            //MessageBox.Show("Video Device No : " + num + "\n Name of device : " + name);
        }

        #endregion

        #region Webcam_capture and Voice DLL


        //#region Voice_In()
        //private void Voice_In()
        //{
        //    //if (userName == "user1")
        //    //{
        //    //    byte[] br;
        //    //    socket.Bind(new IPEndPoint(IPAddress.Any, 7000));
        //    //    while (true)
        //    //    {
        //    //        br = new byte[16384];
        //    //        socket.Receive(br);
        //    //        m_Fifo.Write(br, 0, br.Length);
        //    //    }
        //    //}
        //    //else if (userName == "user2")
        //    //{
        //    //    byte[] br;
        //    //    socket.Bind(new IPEndPoint(IPAddress.Any, 5000));
        //    //    while (true)
        //    //    {
        //    //        br = new byte[16384];
        //    //        socket.Receive(br);
        //    //        m_Fifo.Write(br, 0, br.Length);
        //    //    }
        //    //}
        //}
        //#endregion
        //#region Voice_Out()

        //private void Voice_Out(IntPtr data, int size)
        //{
        //    //if (userName == "user1")
        //    //{
        //    //    try
        //    //    {
        //    //        //for Recorder
        //    //        if (m_RecBuffer == null || m_RecBuffer.Length < size)
        //    //            m_RecBuffer = new byte[size];
        //    //        System.Runtime.InteropServices.Marshal.Copy(data, m_RecBuffer, 0, size);
        //    //        //Microphone ==> data ==> m_RecBuffer ==> m_Fifo
        //    //        socket.SendTo(m_RecBuffer, new IPEndPoint(IPAddress.Parse(text_IP.Text), 5000));
        //    //    }
        //    //    catch (Exception e)
        //    //    {

        //    //    }
        //    //}
        //    //else if (userName == "user2")
        //    //{
        //    //    try
        //    //    {
        //    //        //for Recorder
        //    //        if (m_RecBuffer == null || m_RecBuffer.Length < size)
        //    //            m_RecBuffer = new byte[size];
        //    //        System.Runtime.InteropServices.Marshal.Copy(data, m_RecBuffer, 0, size);
        //    //        //Microphone ==> data ==> m_RecBuffer ==> m_Fifo
        //    //        socket.SendTo(m_RecBuffer, new IPEndPoint(IPAddress.Parse(text_IP.Text), 7000));
        //    //    }
        //    //    catch (Exception e)
        //    //    {

        //    //    }
        //    //}
        //}


        //#endregion

        
      
        //private void Stop()
        //{
        //    //if (m_Player != null)
        //    //    try
        //    //    {
        //    //        m_Player.Dispose();
        //    //    }
        //    //    finally
        //    //    {
        //    //        m_Player = null;
        //    //    }
        //    //if (m_Recorder != null)
        //    //    try
        //    //    {
        //    //        m_Recorder.Dispose();
        //    //    }
        //    //    finally
        //    //    {
        //    //        m_Recorder = null;
        //    //    }
        //    //m_Fifo.Flush(); // clear all pending data
        //}

       

        //private void Start()
        //{
        //    //Stop();
        //    //try
        //    //{
        //    //    WaveFormat fmt = new WaveFormat(22050, 8, 1);
        //    //    m_Player = new WaveOutPlayer(0, fmt, 16384, 3, new BufferFillEventHandler(Filler));
        //    //    m_Recorder = new WaveInRecorder(-1, fmt, 16384, 3, new BufferDoneEventHandler(Voice_Out));
        //    //}
        //    //catch
        //    //{
        //    //    Stop();
        //    //    throw;
        //    //}
        //}

        //private void Filler(IntPtr data, int size)
        //{
        //    //if (m_PlayBuffer == null || m_PlayBuffer.Length < size)
        //    //    m_PlayBuffer = new byte[size];
        //    //if (m_Fifo.Length >= size)
        //    //    m_Fifo.Read(m_PlayBuffer, 0, size);
        //    //else
        //    //    for (int i = 0; i < m_PlayBuffer.Length; i++)
        //    //        m_PlayBuffer[i] = 0;
        //    //System.Runtime.InteropServices.Marshal.Copy(m_PlayBuffer, 0, data, size);
        //    //// m_Fifo ==> m_PlayBuffer==> data ==> Speakers
        //}

        private void bt_stopCamera_Click(object sender, EventArgs e)
        {
            this.WebCamCapture.Stop();
            Capturing.Enabled = false;
        }

        private void bt_startCamera_Click(object sender, EventArgs e)
        {
            this.WebCamCapture.TimeToCapture_milliseconds = 1;
            this.WebCamCapture.Start(0);
            Capturing.Enabled = true;
        }

        private void WebCamCapture_ImageCaptured(object source, WebCam_Capture.WebcamEventArgs e)
        {
            this.pb_host.Image = e.WebCamImage;
        }
        private void Capturing_Tick(object sender, System.EventArgs e)
        {
            Start_Sending_Video_Conference(text_IP.Text, int.Parse(text_Camera_send_port.Text));
        }

        private void Start_Sending_Video_Conference(string remote_IP, int port_number)
        {
            if (userName == "user1")
            {
                port_number = 6000;
                try
                {
                    ms = new MemoryStream();// Store it in Binary Array as Stream
                    pb_host.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] arrImage = ms.GetBuffer();
                    myclient = new TcpClient(remote_IP, port_number);//Connecting with server
                    myns = myclient.GetStream();
                    mysw = new BinaryWriter(myns);
                    mysw.Write(arrImage);//send the stream to above address
                    ms.Close();
                    mysw.Close();
                    myns.Close();
                    myclient.Close();
                }
                catch (Exception)
                {
                }
            }
            else if (userName == "user2")
            {
                port_number = 8000;
                try
                {
                    ms = new MemoryStream();// Store it in Binary Array as Stream
                    pb_host.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] arrImage = ms.GetBuffer();
                    myclient = new TcpClient(remote_IP, port_number);//Connecting with server
                    myns = myclient.GetStream();
                    mysw = new BinaryWriter(myns);
                    mysw.Write(arrImage);//send the stream to above address
                    ms.Close();
                    mysw.Close();
                    myns.Close();
                    myclient.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void Start_Receiving_Video_Conference()
        {
            try
            {
                if (userName == "user1")
                {
                    // Open The Port
                    mytcpl = new TcpListener(8000);
                    mytcpl.Start();                      // Start Listening on That Port

                    while (true)
                    {
                        try
                        {
                            mysocket = mytcpl.AcceptSocket();        // Accept Any Request From Client and Start a Session
                            ns = new NetworkStream(mysocket);    // Receives The Binary Data From Port
                            pb_remote.Image = Image.FromStream(ns);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }
                }

                else if (userName == "user2")
                {
                    // Open The Port
                    mytcpl = new TcpListener(6000);
                    mytcpl.Start();                      // Start Listening on That Port

                    while (true)
                    {
                        try
                        {
                            mysocket = mytcpl.AcceptSocket();        // Accept Any Request From Client and Start a Session
                            ns = new NetworkStream(mysocket);    // Receives The Binary Data From Port
                            pb_remote.Image = Image.FromStream(ns);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }
                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            } 
        }


        private void WebCamCapture_ImageCaptured_1(object source, WebCam_Capture.WebcamEventArgs e)
        {
            this.pb_host.Image = e.WebCamImage;
        }

        private void bt_receiving_Click(object sender, EventArgs e)
        {
            //// Voice Thread
            //socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //voiceth = new Thread(new ThreadStart(Voice_In));
            //voiceth.IsBackground = true;

            // Video Thread
            videoth = new Thread(new System.Threading.ThreadStart(Start_Receiving_Video_Conference)); // Start Thread Session
            videoth.IsBackground = true;
            videoth.Start(); // Start Receiveing Camera
        }

        #endregion

        #region New Variables for Voice Library Use

        private Socket r;
        private Thread t;
        //private WaveOutPlayer m_Player;
        //private WaveInRecorder m_Recorder;
        //private FifoStream m_Fifo = new FifoStream();

        //private byte[] m_PlayBuffer;
        //private byte[] m_RecBuffer;

        #endregion
       
        #region

        #endregion

        #region webcam
        private void bt_startVoice_Click(object sender, EventArgs e)
        {
            //if (connected == false)
            //{
            //    t.Start();
            //    connected = true;
            //}

            //Start();
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            //Stop();
        }

        private void bt_ReceivingAudio_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Variables for Direct X 

        Thread ServerThread;
        private Capture capture = null;
        private Filters filters = new Filters();
        Socket server_sock;
        bool stoped = false;

        bool isSending = false;


        #endregion

        #region Direct X Video

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //t.Abort();
            //r.Close();
            //Stop();
            try
            {
                t.Abort();
                r.Close();
                Stop();
            }
            catch (Exception) { }

            try
            {
                if (userName == "user1")
                {
                    ServerAudioThreadPeer1.Abort();
                }
                else if (userName == "user2")
                {
                    ServerAudioThreadPeer2.Abort();
                }
            }
            catch (Exception) { }


            try
            {
                isSending = false;
                server_sock.Close();
                ServerThread.Abort();
            }
            catch (Exception) { }

            try
            {
                capture.PreviewWindow = null;
                if (capture != null)
                    capture.Stop();
            }
            catch (Exception) { }
            stoped = true;
        }

        private void CaptureDone(System.Drawing.Bitmap e)
        {
            try
            {
                this.pictureBox.Image = e;
                //MemoryStream ms = new MemoryStream();
                //pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //byte[] buffer = ms.GetBuffer();
                if (isSending)
                    ThreadPool.QueueUserWorkItem(new WaitCallback(SendVideoBuffer), pictureBox.Image);
            }
            catch (Exception) { }
        }

        void SendVideoBuffer(object bufferIn)
        {
            try
            {
                TcpClient tcp = new TcpClient(PeerIP_TXT.Text, 6000);
                NetworkStream ns = tcp.GetStream();
                Image buffer = (Image)bufferIn;
                buffer.Save(ns, System.Drawing.Imaging.ImageFormat.Jpeg);
                ns.Close();
                tcp.Close();
            }
            catch (Exception) { }
        }

        private void bt_endCall_Click(object sender, EventArgs e)
        {
            pnl_coverRemoteVideo.Visible = true;
            try
            {
                isSending = false;
                server_sock.Close();
                ServerThread.Abort();
            }
            catch (Exception) { }

            try
            {
                capture.PreviewWindow = null;
                if (capture != null)
                    capture.Stop();
            }
            catch (Exception) { }
            stoped = true;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            ServerThread = new Thread(new ThreadStart(server));
            ServerThread.IsBackground = true;
            ServerThread.Start();

            if (capture != null)
            {
                capture.FrameRate = 15;
                capture.FrameSize = new Size(320, 240);
            }

            if (userName == "user1")
            {
                ServerAudioThreadPeer1 = new Thread(new ThreadStart(audioServer));
                ServerAudioThreadPeer1.IsBackground = true;
                ServerAudioThreadPeer1.Start();
                connected = true;
                r = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            }
            else if (userName == "user2")
            {
                ServerAudioThreadPeer2 = new Thread(new ThreadStart(audioServer));
                ServerAudioThreadPeer2.IsBackground = true;
                ServerAudioThreadPeer2.Start();
                connected = true;
                r = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            }
        }


        void server()
        {
            try
            {
                server_sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server_sock.Bind(new IPEndPoint(IPAddress.Any, 6000));
                server_sock.Listen(-1);

                while (true)
                {
                    try
                    {
                        Socket new_socket = server_sock.Accept();
                        NetworkStream ns = new NetworkStream(new_socket);
                        pictureBox_Remote.Image = Image.FromStream(ns);
                        ns.Close();
                        new_socket.Close();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            catch (Exception) { }

        }

        private void bt_startCall_Click(object sender, EventArgs e)
        {
            try
            {
                // Start Capturing

                if (capture != null)
                {
                    if (capture.PreviewWindow != panelVideo)
                    {
                        capture.PreviewWindow = panelVideo;
                    }
                    capture.FrameEvent2 += new Capture.HeFrame(CaptureDone);
                    capture.GrapImg();

                    PeerIP_TXT.Enabled = false;
                    bt_startCall.Enabled = false;
                    
                    isSending = true;

                }


            }
            catch (Exception) { }
        }
        #endregion

        #region Direct X Audio
        #endregion
        Thread ServerAudioThreadPeer1 ;
        Thread ServerAudioThreadPeer2 ;
        Socket serverAudio_sock=null;

        private void audioServer()
        {
            if (userName == "user1")
            {
                try
                {
                    byte[] br;
                   
                    r.Bind(new IPEndPoint(IPAddress.Any, 3000)); //receving port
                    while (true)
                    {
                        br = new byte[16384];
                        r.Receive(br);
                        m_Fifo.Write(br, 0, br.Length);
                    }
                }
                catch (Exception) { }
            }

            else if (userName == "user2")
            {
                try
                {
                    byte[] br;
                    //r = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    r.Bind(new IPEndPoint(IPAddress.Any, 4000)); //receving port
                    while (true)
                    {
                        br = new byte[16384];
                        r.Receive(br);
                        m_Fifo.Write(br, 0, br.Length);
                    }
                }
                catch (Exception) { }
            }

        }

        private void Voice_Out(IntPtr data, int size)
        {
            if (userName == "user1")
            {
                //for Recorder
                if (m_RecBuffer == null || m_RecBuffer.Length < size)
                    m_RecBuffer = new byte[size];
                System.Runtime.InteropServices.Marshal.Copy(data, m_RecBuffer, 0, size);
                //Microphone ==> data ==> m_RecBuffer ==> m_Fifo
                r.SendTo(m_RecBuffer, new IPEndPoint(IPAddress.Parse(this.PeerIP_TXT.Text), 4000));
            }
            else if (userName == "user2")
            {
                //for Recorder
                if (m_RecBuffer == null || m_RecBuffer.Length < size)
                    m_RecBuffer = new byte[size];
                System.Runtime.InteropServices.Marshal.Copy(data, m_RecBuffer, 0, size);
                //Microphone ==> data ==> m_RecBuffer ==> m_Fifo
                r.SendTo(m_RecBuffer, new IPEndPoint(IPAddress.Parse(this.PeerIP_TXT.Text), 3000));
            }
        }

        private WaveOutPlayer m_Player;
        private WaveInRecorder m_Recorder;
        private FifoStream m_Fifo = new FifoStream();

        private byte[] m_PlayBuffer;
        private byte[] m_RecBuffer;

        private void bt_peer1_startAudio_Click(object sender, EventArgs e)
        {
            //if (connected == false)
            //{
            //    t.Start();
            //    connected = true;
            //}

            Start();
        }

        private void Start()
        {
            Stop();
            try
            {
                WaveFormat fmt = new WaveFormat(44100, 16, 2);
                m_Player = new WaveOutPlayer(-1, fmt, 16384, 3, new BufferFillEventHandler(Filler));
                m_Recorder = new WaveInRecorder(-1, fmt, 16384, 3, new BufferDoneEventHandler(Voice_Out));
            }
            catch
            {
                Stop();
                throw;
            }
        }

        private void Stop()
        {
            if (m_Player != null)
                try
                {
                    m_Player.Dispose();
                }
                finally
                {
                    m_Player = null;
                }
            if (m_Recorder != null)
                try
                {
                    m_Recorder.Dispose();
                }
                finally
                {
                    m_Recorder = null;
                }
            m_Fifo.Flush(); // clear all pending data
        }

        private void Filler(IntPtr data, int size)
        {
            if (m_PlayBuffer == null || m_PlayBuffer.Length < size)
                m_PlayBuffer = new byte[size];
            if (m_Fifo.Length >= size)
                m_Fifo.Read(m_PlayBuffer, 0, size);
            else
                for (int i = 0; i < m_PlayBuffer.Length; i++)
                    m_PlayBuffer[i] = 0;
            System.Runtime.InteropServices.Marshal.Copy(m_PlayBuffer, 0, data, size);
            // m_Fifo ==> m_PlayBuffer==> data ==> Speakers
        }

        private void bt_peer1_endAudio_Click(object sender, EventArgs e)
        {
            Stop();
        }
    }
}