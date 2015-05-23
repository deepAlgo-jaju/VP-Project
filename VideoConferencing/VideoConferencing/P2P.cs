using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Voice;

namespace VideoConferencing
{
    public partial class P2P : Form
    {
        public P2P()
        {
            InitializeComponent();
        }


        private WaveOutPlayer m_Player;
        private WaveInRecorder m_Recorder;
        private FifoStream m_Fifo = new FifoStream();
        private Socket r;
        private Thread t;
        private bool connected = false;
        private byte[] m_PlayBuffer;
        private byte[] m_RecBuffer;
        TcpClient myclient;
        MemoryStream ms;
        NetworkStream myns;
        BinaryWriter mysw;
        Thread myth;
        TcpListener mytcpl;
        NetworkStream ns;
        Socket mysocket;

        #region Voice_In()
        private void Voice_In()
        {
            byte[] br;
            r.Bind(new IPEndPoint(IPAddress.Any, int.Parse(text_Voice_SendingPort.Text)));
            while (true)
            {
                br = new byte[16384];
                r.Receive(br);
                m_Fifo.Write(br, 0, br.Length);
            }
        }
        #endregion
        #region Voice_Out()

        private void Voice_Out(IntPtr data, int size)
        {
            try
            {
                //for Recorder
                if (m_RecBuffer == null || m_RecBuffer.Length < size)
                    m_RecBuffer = new byte[size];
                System.Runtime.InteropServices.Marshal.Copy(data, m_RecBuffer, 0, size);
                //Microphone ==> data ==> m_RecBuffer ==> m_Fifo
                r.SendTo(m_RecBuffer, new IPEndPoint(IPAddress.Parse(text_IP.Text), int.Parse(text_Voice_SendingPort.Text)));
            }
            catch (Exception) { }
        }

        #endregion

        private void P2P_Load(object sender, EventArgs e)
        {
            // Voice Thread
            r = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            t = new Thread(new ThreadStart(Voice_In));
            t.IsBackground = true;

            // Video Thread
            myth = new Thread(new System.Threading.ThreadStart(Start_Receiving_Video_Conference)); // Start Thread Session
            myth.IsBackground = true;
            myth.Start(); // Start Receiveing Camera
        }

        private void Start_Receiving_Video_Conference()
        {
            try
            {

                // Open The Port
                mytcpl = new TcpListener(int.Parse(text_Camera_send_port.Text));
                mytcpl.Start();                      // Start Listening on That Port

                while (true)
                {
                    try
                    {
                        mysocket = mytcpl.AcceptSocket();        // Accept Any Request From Client and Start a Session
                        ns = new NetworkStream(mysocket);    // Receives The Binary Data From Port
                        pictureBox2.Image = Image.FromStream(ns);
                    }
                    catch (Exception) { }
                }
            }
            catch (Exception) { }
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            Stop();
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

        private void bt_startVoice_Click(object sender, EventArgs e)
        {
            if (connected == false)
            {
                t.Start();
                connected = true;
            }

            Start();
        }

        private void Start()
        {
            Stop();
            try
            {
                WaveFormat fmt = new WaveFormat(22050, 8, 1);
                m_Player = new WaveOutPlayer(0, fmt, 16384, 3, new BufferFillEventHandler(Filler));
                m_Recorder = new WaveInRecorder(-1, fmt, 16384, 3, new BufferDoneEventHandler(Voice_Out));
            }
            catch
            {
                Stop();
                throw;
            }
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
            this.pictureBox1.Image = e.WebCamImage;
        }
        private void Capturing_Tick(object sender, System.EventArgs e)
        {
            Start_Sending_Video_Conference(text_IP.Text, int.Parse(text_Camera_send_port.Text));
        }

        private void Start_Sending_Video_Conference(string remote_IP, int port_number)
        {
            try
            {
                ms = new MemoryStream();// Store it in Binary Array as Stream
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
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

    }
}
