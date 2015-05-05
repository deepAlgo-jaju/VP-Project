namespace VideoConferencing
{
    partial class PracticeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Stop = new System.Windows.Forms.Button();
            this.cb_videoDevicesList = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(351, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 117);
            this.panel1.TabIndex = 1;
            // 
            // bt_Stop
            // 
            this.bt_Stop.Location = new System.Drawing.Point(443, 342);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(86, 29);
            this.bt_Stop.TabIndex = 2;
            this.bt_Stop.Text = "Stop";
            this.bt_Stop.UseVisualStyleBackColor = true;
            this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
            // 
            // cb_videoDevicesList
            // 
            this.cb_videoDevicesList.FormattingEnabled = true;
            this.cb_videoDevicesList.Location = new System.Drawing.Point(32, 296);
            this.cb_videoDevicesList.Name = "cb_videoDevicesList";
            this.cb_videoDevicesList.Size = new System.Drawing.Size(216, 21);
            this.cb_videoDevicesList.TabIndex = 3;
            this.cb_videoDevicesList.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 205);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Call";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cb_videoDevicesList);
            this.Controls.Add(this.bt_Stop);
            this.Controls.Add(this.panel1);
            this.Name = "PracticeForm";
            this.Text = "PracticeForm";
            this.Load += new System.EventHandler(this.PracticeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Stop;
        private System.Windows.Forms.ComboBox cb_videoDevicesList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}