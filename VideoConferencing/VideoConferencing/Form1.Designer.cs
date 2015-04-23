namespace VideoConferencing
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.panel_VideoChat = new System.Windows.Forms.Panel();
            this.panel_Contacts = new System.Windows.Forms.Panel();
            this.tabPage_Help = new System.Windows.Forms.TabPage();
            this.tabPage_Menu = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suggesstionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1_Contacts = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_VideoChat.SuspendLayout();
            this.tabPage_Help.SuspendLayout();
            this.tabPage_Menu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_VideoChat
            // 
            this.panel_VideoChat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_VideoChat.Controls.Add(this.tabControl1);
            this.panel_VideoChat.Location = new System.Drawing.Point(3, 6);
            this.panel_VideoChat.Name = "panel_VideoChat";
            this.panel_VideoChat.Size = new System.Drawing.Size(210, 391);
            this.panel_VideoChat.TabIndex = 0;
            // 
            // panel_Contacts
            // 
            this.panel_Contacts.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Contacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Contacts.Location = new System.Drawing.Point(209, 6);
            this.panel_Contacts.Name = "panel_Contacts";
            this.panel_Contacts.Size = new System.Drawing.Size(463, 391);
            this.panel_Contacts.TabIndex = 1;
            // 
            // tabPage_Help
            // 
            this.tabPage_Help.Controls.Add(this.menuStrip2);
            this.tabPage_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Help.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Help.Name = "tabPage_Help";
            this.tabPage_Help.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Help.Size = new System.Drawing.Size(200, 362);
            this.tabPage_Help.TabIndex = 1;
            this.tabPage_Help.Text = "Help";
            this.tabPage_Help.UseVisualStyleBackColor = true;
            // 
            // tabPage_Menu
            // 
            this.tabPage_Menu.AllowDrop = true;
            this.tabPage_Menu.Controls.Add(this.menuStrip1);
            this.tabPage_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Menu.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Menu.Name = "tabPage_Menu";
            this.tabPage_Menu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Menu.Size = new System.Drawing.Size(200, 362);
            this.tabPage_Menu.TabIndex = 0;
            this.tabPage_Menu.Text = "Menu";
            this.tabPage_Menu.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1_Contacts});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(194, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Menu);
            this.tabControl1.Controls.Add(this.tabPage_Help);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(208, 388);
            this.tabControl1.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactUsToolStripMenuItem,
            this.suggesstionToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(194, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            // 
            // suggesstionToolStripMenuItem
            // 
            this.suggesstionToolStripMenuItem.Name = "suggesstionToolStripMenuItem";
            this.suggesstionToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.suggesstionToolStripMenuItem.Text = "Suggessition";
            // 
            // toolStripMenuItem1_Contacts
            // 
            this.toolStripMenuItem1_Contacts.BackColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem1_Contacts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.toolStripMenuItem1_Contacts.Name = "toolStripMenuItem1_Contacts";
            this.toolStripMenuItem1_Contacts.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem1_Contacts.Text = "Contacts";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::VideoConferencing.Properties.Resources.contacts;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Image = global::VideoConferencing.Properties.Resources.myspace;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "View";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Image = global::VideoConferencing.Properties.Resources.Falcon_pro_for_twitter;
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(674, 403);
            this.Controls.Add(this.panel_Contacts);
            this.Controls.Add(this.panel_VideoChat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Conferencing";
            this.panel_VideoChat.ResumeLayout(false);
            this.tabPage_Help.ResumeLayout(false);
            this.tabPage_Help.PerformLayout();
            this.tabPage_Menu.ResumeLayout(false);
            this.tabPage_Menu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_VideoChat;
        private System.Windows.Forms.Panel panel_Contacts;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Menu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage tabPage_Help;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suggesstionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1_Contacts;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
    }
}

