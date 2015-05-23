namespace VideoConferencing
{
    partial class P2P
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_startVoice = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.text_Voice_SendingPort = new System.Windows.Forms.TextBox();
            this.text_IP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_stopCamera = new System.Windows.Forms.Button();
            this.bt_startCamera = new System.Windows.Forms.Button();
            this.Capturing = new System.Windows.Forms.Timer(this.components);
            this.text_Camera_send_port = new System.Windows.Forms.TextBox();
            this.L_About = new System.Windows.Forms.Label();
            this.WebCamCapture = new WebCam_Capture.WebCamCapture();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_startVoice
            // 
            this.bt_startVoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_startVoice.Location = new System.Drawing.Point(195, 237);
            this.bt_startVoice.Name = "bt_startVoice";
            this.bt_startVoice.Size = new System.Drawing.Size(89, 24);
            this.bt_startVoice.TabIndex = 0;
            this.bt_startVoice.Text = "Start Talking";
            this.bt_startVoice.Click += new System.EventHandler(this.bt_startVoice_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_stop.Location = new System.Drawing.Point(195, 267);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(89, 24);
            this.bt_stop.TabIndex = 1;
            this.bt_stop.Text = "Stop Voice";
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // text_Voice_SendingPort
            // 
            this.text_Voice_SendingPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_Voice_SendingPort.Location = new System.Drawing.Point(68, 269);
            this.text_Voice_SendingPort.Name = "text_Voice_SendingPort";
            this.text_Voice_SendingPort.Size = new System.Drawing.Size(104, 20);
            this.text_Voice_SendingPort.TabIndex = 12;
            this.text_Voice_SendingPort.Text = "9000";
            // 
            // text_IP
            // 
            this.text_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_IP.Location = new System.Drawing.Point(100, 5);
            this.text_IP.Name = "text_IP";
            this.text_IP.Size = new System.Drawing.Size(256, 20);
            this.text_IP.TabIndex = 10;
            this.text_IP.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Voice Port";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Talk With (IP)";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(36, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "My Camera";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(252, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Remote Camera";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Video Port";
            // 
            // bt_stopCamera
            // 
            this.bt_stopCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_stopCamera.Location = new System.Drawing.Point(296, 267);
            this.bt_stopCamera.Name = "bt_stopCamera";
            this.bt_stopCamera.Size = new System.Drawing.Size(84, 24);
            this.bt_stopCamera.TabIndex = 26;
            this.bt_stopCamera.Text = "Stop Camera";
            this.bt_stopCamera.Click += new System.EventHandler(this.bt_stopCamera_Click);
            // 
            // bt_startCamera
            // 
            this.bt_startCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_startCamera.Location = new System.Drawing.Point(296, 235);
            this.bt_startCamera.Name = "bt_startCamera";
            this.bt_startCamera.Size = new System.Drawing.Size(84, 24);
            this.bt_startCamera.TabIndex = 25;
            this.bt_startCamera.Text = "Start Camera";
            this.bt_startCamera.Click += new System.EventHandler(this.bt_startCamera_Click);
            // 
            // Capturing
            // 
            this.Capturing.Tick += new System.EventHandler(this.Capturing_Tick);
            // 
            // text_Camera_send_port
            // 
            this.text_Camera_send_port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_Camera_send_port.Location = new System.Drawing.Point(68, 243);
            this.text_Camera_send_port.Name = "text_Camera_send_port";
            this.text_Camera_send_port.Size = new System.Drawing.Size(104, 20);
            this.text_Camera_send_port.TabIndex = 27;
            this.text_Camera_send_port.Text = "8000";
            // 
            // L_About
            // 
            this.L_About.AutoSize = true;
            this.L_About.Location = new System.Drawing.Point(18, 297);
            this.L_About.Name = "L_About";
            this.L_About.Size = new System.Drawing.Size(0, 13);
            this.L_About.TabIndex = 29;
            // 
            // WebCamCapture
            // 
            this.WebCamCapture.CaptureHeight = 240;
            this.WebCamCapture.CaptureWidth = 320;
            this.WebCamCapture.FrameNumber = ((ulong)(0ul));
            this.WebCamCapture.Location = new System.Drawing.Point(17, 17);
            this.WebCamCapture.Name = "WebCamCapture";
            this.WebCamCapture.Size = new System.Drawing.Size(342, 252);
            this.WebCamCapture.TabIndex = 0;
            this.WebCamCapture.TimeToCapture_milliseconds = 100;
            this.WebCamCapture.ImageCaptured += new WebCam_Capture.WebCamCapture.WebCamEventHandler(this.WebCamCapture_ImageCaptured);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.Location = new System.Drawing.Point(229, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(12, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // P2P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 332);
            this.Controls.Add(this.L_About);
            this.Controls.Add(this.text_Camera_send_port);
            this.Controls.Add(this.bt_stopCamera);
            this.Controls.Add(this.bt_startCamera);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_Voice_SendingPort);
            this.Controls.Add(this.text_IP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_startVoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "P2P";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P2P Video/Voice Conference System - By FADI Abdel-qader";
            this.Load += new System.EventHandler(this.P2P_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Button bt_startVoice;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Voice_SendingPort;
        private System.Windows.Forms.TextBox text_IP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_stopCamera;
        private System.Windows.Forms.Button bt_startCamera;
        private WebCam_Capture.WebCamCapture webCamCapture1;
        private System.Windows.Forms.Timer Capturing;
        private System.Windows.Forms.TextBox text_Camera_send_port;
        private System.Windows.Forms.Label L_About;
        //private System.ComponentModel.IContainer components;
        #endregion

        private WebCam_Capture.WebCamCapture WebCamCapture;
    }
}