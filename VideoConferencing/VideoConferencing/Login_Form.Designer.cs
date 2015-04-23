namespace VideoConferencing
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.panel_Login = new System.Windows.Forms.Panel();
            this.comboBox_Login_UserName = new System.Windows.Forms.ComboBox();
            this.textBox_Login_Pass = new System.Windows.Forms.TextBox();
            this.panel_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Login
            // 
            this.panel_Login.BackgroundImage = global::VideoConferencing.Properties.Resources.Login_Form_web;
            this.panel_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Login.Controls.Add(this.textBox_Login_Pass);
            this.panel_Login.Controls.Add(this.comboBox_Login_UserName);
            this.panel_Login.Location = new System.Drawing.Point(-2, -3);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(659, 552);
            this.panel_Login.TabIndex = 0;
            // 
            // comboBox_Login_UserName
            // 
            this.comboBox_Login_UserName.Font = new System.Drawing.Font("Segoe UI Emoji", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Login_UserName.FormattingEnabled = true;
            this.comboBox_Login_UserName.Items.AddRange(new object[] {
            "user1",
            "user2"});
            this.comboBox_Login_UserName.Location = new System.Drawing.Point(203, 285);
            this.comboBox_Login_UserName.Name = "comboBox_Login_UserName";
            this.comboBox_Login_UserName.Size = new System.Drawing.Size(260, 39);
            this.comboBox_Login_UserName.TabIndex = 0;
            // 
            // textBox_Login_Pass
            // 
            this.textBox_Login_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Login_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Login_Pass.Location = new System.Drawing.Point(203, 370);
            this.textBox_Login_Pass.Name = "textBox_Login_Pass";
            this.textBox_Login_Pass.Size = new System.Drawing.Size(260, 34);
            this.textBox_Login_Pass.TabIndex = 1;
            this.textBox_Login_Pass.UseSystemPasswordChar = true;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 547);
            this.Controls.Add(this.panel_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.ComboBox comboBox_Login_UserName;
        private System.Windows.Forms.TextBox textBox_Login_Pass;
    }
}