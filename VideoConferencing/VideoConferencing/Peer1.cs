﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoConferencing
{
    public partial class Peer1 : Form
    {
        public Peer1()
        {
            InitializeComponent();
        }


        #region WebCam API
        const short WM_CAP = 1024;
        const int WM_CAP_DRIVER_CONNECT = WM_CAP + 10;
        const int WM_CAP_DRIVER_DISCONNECT = WM_CAP + 11;
        const int WM_CAP_EDIT_COPY = WM_CAP + 30;
        const int WM_CAP_SET_PREVIEW = WM_CAP + 50;
        const int WM_CAP_SET_PREVIEWRATE = WM_CAP + 52;
        const int WM_CAP_SET_SCALE = WM_CAP + 53;
        const int WS_CHILD = 1073741824;
        const int WS_VISIBLE = 268435456;
        const short SWP_NOMOVE = 2;
        const short SWP_NOSIZE = 1;
        const short SWP_NOZORDER = 4;
        const short HWND_BOTTOM = 1;
        [System.Runtime.InteropServices.DllImport("user32", EntryPoint = "SendMessageA")]
        static extern int SendMessage(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.AsAny)]
            object lParam);
        [System.Runtime.InteropServices.DllImport("user32", EntryPoint = "SetWindowPos")]
        static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);
        [System.Runtime.InteropServices.DllImport("user32")]
        static extern bool DestroyWindow(int hndw);
        [System.Runtime.InteropServices.DllImport("avicap32.dll")]
        static extern int capCreateCaptureWindowA(string lpszWindowName, int dwStyle, int x, int y, int nWidth, short nHeight, int hWndParent, int nID);
        [System.Runtime.InteropServices.DllImport("avicap32.dll")]
        static extern bool capGetDriverDescriptionA(short wDriver, string lpszName, int cbName, string lpszVer, int cbVer);

        #endregion

        int iDevice = 0;
        int hHwnd;

        TcpClient myclient;
        MemoryStream ms;
        NetworkStream myns;
        BinaryWriter mysw;
        Thread myth;
        TcpListener mytcpl;
        Socket mysocket;
        NetworkStream ns;

        /// <summary>
        /// To start the host video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_startCapturing_Click(object sender, EventArgs e)
        {
            bt_stopCapturing.Enabled = true;
            iDevice = int.Parse(device_number_textBox.Text);
            OpenPreviewWindow();
        }

        /// <summary>
        /// Call the API and passing the values
        /// </summary>
        private void OpenPreviewWindow()
        {
            int iHeight = 320;
            int iWidth = 200;
            // 
            //  Open Preview window in picturebox
            // 
            hHwnd = capCreateCaptureWindowA(iDevice.ToString(), (WS_VISIBLE | WS_CHILD), 0, 0, 640, 480, picCapture.Handle.ToInt32(), 0);
            // 
            //  Connect to device
            // 
            if (SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) == 1)
            {
                // 
                // Set the preview scale
                // 
                SendMessage(hHwnd, WM_CAP_SET_SCALE, 1, 0);
                // 
                // Set the preview rate in milliseconds
                // 
                SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0);
                // 
                // Start previewing the image from the camera
                // 
                SendMessage(hHwnd, WM_CAP_SET_PREVIEW, 1, 0);
                // 
                //  Resize window to fit in picturebox
                // 
                SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, iWidth, iHeight, (SWP_NOMOVE | SWP_NOZORDER));
            }
            else
            {
                // 
                //  Error connecting to device close window
                //  
                DestroyWindow(hHwnd);
            }
        }

        /// <summary>
        /// Calling the method to stop the host video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_stopCapturing_Click(object sender, EventArgs e)
        {
            ClosePreviewWindow();
        }

        /// <summary>
        /// Stoping the host video
        /// </summary>
        private void ClosePreviewWindow()
        {
            // 
            //  Disconnect from device
            // 
            SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0);
            // 
            //  close window
            // 
            DestroyWindow(hHwnd);
        }

        /// <summary>
        /// Start Revicing the Remote video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_startListening_Click(object sender, EventArgs e)
        {
            myth = new Thread(new System.Threading.ThreadStart(Start_Receiving_Video_Conference)); // Start Thread Session
            myth.Start(); // Start Receiveing Camera
        }

        /// <summary>
        /// Start Receving the Remote Video through socket
        /// </summary>
        private void Start_Receiving_Video_Conference()
        {
            try
            {

                // Open The Port
                mytcpl = new TcpListener(5000);
                mytcpl.Start();						 // Start Listening on That Port
                mysocket = mytcpl.AcceptSocket();		 // Accept Any Request From Client and Start a Session
                ns = new NetworkStream(mysocket);	 // Receives The Binary Data From Port

                picture_comming.Image = Image.FromStream(ns);
                mytcpl.Stop();							 // Close TCP Session

                if (mysocket.Connected == true)		     // Looping While Connected to Receive Another Message 
                {
                    while (true)
                    {
                        Start_Receiving_Video_Conference();				 // Back to First Method
                    }
                }
                myns.Flush();

            }
            catch (Exception)
            {
                myth.Abort();
            }
        }


        /// <summary>
        /// Start sending the host video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_startSending_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }


        /// <summary>
        /// Start sending the host video to the remote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            Start_Sending_Video_Conference(IP_textBox.Text, 6000);
        }

        /// <summary>
        /// Start sending the video to the remote
        /// </summary>
        /// <param name="remote_IP"></param>
        /// <param name="port_number"></param>
        private void Start_Sending_Video_Conference(string remote_IP, int port_number)
        {
            try
            {

                ms = new MemoryStream();// Store it in Binary Array as Stream


                IDataObject data;
                Image bmap;

                //  Copy image to clipboard
                SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0);

                //  Get image from clipboard and convert it to a bitmap
                data = Clipboard.GetDataObject();

                if (data.GetDataPresent(typeof(System.Drawing.Bitmap)))
                {
                    bmap = ((Image)(data.GetData(typeof(System.Drawing.Bitmap))));
                    bmap.Save(ms, ImageFormat.Bmp);
                }


                picCapture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
              //  byte[] arrImage = ms.GetBuffer();
                myclient = new TcpClient(remote_IP, port_number);//Connecting with server
                myns = myclient.GetStream();
                mysw = new BinaryWriter(myns);
                //mysw.Write(arrImage);//send the stream to above address
                ms.Flush();
                mysw.Flush();
                myns.Flush();
                ms.Close();
                mysw.Close();
                myns.Close();
                myclient.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Video Conference Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Peer1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bt_stopCapturing.Enabled)
            {
                ClosePreviewWindow();
            }
        }
    }
}
