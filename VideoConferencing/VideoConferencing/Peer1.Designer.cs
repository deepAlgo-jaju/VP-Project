namespace VideoConferencing
{
    partial class Peer1 
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.IP_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_startListening = new System.Windows.Forms.Button();
            this.bt_startSending = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picture_comming = new System.Windows.Forms.PictureBox();
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.bt_startCapturing = new System.Windows.Forms.Button();
            this.bt_stopCapturing = new System.Windows.Forms.Button();
            this.device_number_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_comming)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // IP_textBox
            // 
            this.IP_textBox.Location = new System.Drawing.Point(77, 372);
            this.IP_textBox.Name = "IP_textBox";
            this.IP_textBox.Size = new System.Drawing.Size(161, 20);
            this.IP_textBox.TabIndex = 13;
            this.IP_textBox.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Remot IP";
            // 
            // bt_startListening
            // 
            this.bt_startListening.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_startListening.Location = new System.Drawing.Point(344, 369);
            this.bt_startListening.Name = "bt_startListening";
            this.bt_startListening.Size = new System.Drawing.Size(75, 23);
            this.bt_startListening.TabIndex = 17;
            this.bt_startListening.Text = "Listener";
            this.bt_startListening.UseVisualStyleBackColor = true;
            this.bt_startListening.Click += new System.EventHandler(this.bt_startListening_Click);
            // 
            // bt_startSending
            // 
            this.bt_startSending.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_startSending.Location = new System.Drawing.Point(247, 370);
            this.bt_startSending.Name = "bt_startSending";
            this.bt_startSending.Size = new System.Drawing.Size(91, 23);
            this.bt_startSending.TabIndex = 18;
            this.bt_startSending.Text = "Start Sending";
            this.bt_startSending.UseVisualStyleBackColor = true;
            this.bt_startSending.Click += new System.EventHandler(this.bt_startSending_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picture_comming
            // 
            this.picture_comming.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picture_comming.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture_comming.Location = new System.Drawing.Point(139, 175);
            this.picture_comming.Name = "picture_comming";
            this.picture_comming.Size = new System.Drawing.Size(246, 189);
            this.picture_comming.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_comming.TabIndex = 12;
            this.picture_comming.TabStop = false;
            // 
            // picCapture
            // 
            this.picCapture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picCapture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCapture.Location = new System.Drawing.Point(139, 89);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(102, 80);
            this.picCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCapture.TabIndex = 6;
            this.picCapture.TabStop = false;
            // 
            // bt_startCapturing
            // 
            this.bt_startCapturing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_startCapturing.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_startCapturing.Location = new System.Drawing.Point(247, 89);
            this.bt_startCapturing.Name = "bt_startCapturing";
            this.bt_startCapturing.Size = new System.Drawing.Size(112, 32);
            this.bt_startCapturing.TabIndex = 9;
            this.bt_startCapturing.Text = "Start Capturing";
            this.bt_startCapturing.Click += new System.EventHandler(this.bt_startCapturing_Click);
            // 
            // bt_stopCapturing
            // 
            this.bt_stopCapturing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_stopCapturing.Enabled = false;
            this.bt_stopCapturing.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_stopCapturing.Location = new System.Drawing.Point(247, 127);
            this.bt_stopCapturing.Name = "bt_stopCapturing";
            this.bt_stopCapturing.Size = new System.Drawing.Size(112, 32);
            this.bt_stopCapturing.TabIndex = 11;
            this.bt_stopCapturing.Text = "Stop Capturing";
            this.bt_stopCapturing.Click += new System.EventHandler(this.bt_stopCapturing_Click);
            // 
            // device_number_textBox
            // 
            this.device_number_textBox.Location = new System.Drawing.Point(336, 25);
            this.device_number_textBox.Name = "device_number_textBox";
            this.device_number_textBox.Size = new System.Drawing.Size(48, 20);
            this.device_number_textBox.TabIndex = 15;
            this.device_number_textBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Capture Device #";
            // 
            // Peer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 481);
            this.ControlBox = false;
            this.Controls.Add(this.bt_startSending);
            this.Controls.Add(this.bt_startListening);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.device_number_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IP_textBox);
            this.Controls.Add(this.picture_comming);
            this.Controls.Add(this.bt_stopCapturing);
            this.Controls.Add(this.bt_startCapturing);
            this.Controls.Add(this.picCapture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Peer1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User 1 ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Peer1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picture_comming)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox IP_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_startListening;
        private System.Windows.Forms.Button bt_startSending;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox device_number_textBox;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.PictureBox picCapture;
        internal System.Windows.Forms.Button bt_startCapturing;
        internal System.Windows.Forms.Button bt_stopCapturing;
        internal System.Windows.Forms.PictureBox picture_comming;
        
    }
}