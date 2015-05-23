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
            this.tc_contactsDetails = new System.Windows.Forms.TabControl();
            this.tabPage_Menu = new System.Windows.Forms.TabPage();
            this.panel_tabPage_Menu_Delete = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_panel_tabPage_Menu_Contact_Delete = new System.Windows.Forms.ComboBox();
            this.bt_panel_tabPage_Menu_Contacts_Delete = new System.Windows.Forms.Button();
            this.panel_tabPage_Menu_View = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_panel_tabPage_Menu_Contact_View = new System.Windows.Forms.ComboBox();
            this.bt_panel_tabPage_Menu_Contacts_View = new System.Windows.Forms.Button();
            this.panel_tabPage_Menu_Add = new System.Windows.Forms.Panel();
            this.bt_panel_tabPage_Menu__Contacts_Add = new System.Windows.Forms.Button();
            this.cb_panel_tabPage_Menu_Contact_Add = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1_Contacts = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_Help = new System.Windows.Forms.TabPage();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suggesstionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_CallMenu = new System.Windows.Forms.Panel();
            this.bt_stop_call_Menu = new System.Windows.Forms.Button();
            this.axVideoChatReceiver1 = new AxVideoChatReceiverLib.AxVideoChatReceiver();
            this.axVideoChatSender1 = new AxVideoChatSenderLib.AxVideoChatSender();
            this.bt_disconnect_panel_CallMenu = new System.Windows.Forms.Button();
            this.bt_call_panel_CallMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_VideoChat.SuspendLayout();
            this.tc_contactsDetails.SuspendLayout();
            this.tabPage_Menu.SuspendLayout();
            this.panel_tabPage_Menu_Delete.SuspendLayout();
            this.panel_tabPage_Menu_View.SuspendLayout();
            this.panel_tabPage_Menu_Add.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage_Help.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel_CallMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatSender1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_VideoChat
            // 
            this.panel_VideoChat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_VideoChat.Controls.Add(this.tc_contactsDetails);
            this.panel_VideoChat.Location = new System.Drawing.Point(3, 6);
            this.panel_VideoChat.Name = "panel_VideoChat";
            this.panel_VideoChat.Size = new System.Drawing.Size(210, 472);
            this.panel_VideoChat.TabIndex = 0;
            // 
            // tc_contactsDetails
            // 
            this.tc_contactsDetails.Controls.Add(this.tabPage_Menu);
            this.tc_contactsDetails.Controls.Add(this.tabPage_Help);
            this.tc_contactsDetails.Location = new System.Drawing.Point(0, 0);
            this.tc_contactsDetails.Name = "tc_contactsDetails";
            this.tc_contactsDetails.SelectedIndex = 0;
            this.tc_contactsDetails.Size = new System.Drawing.Size(208, 472);
            this.tc_contactsDetails.TabIndex = 0;
            // 
            // tabPage_Menu
            // 
            this.tabPage_Menu.AllowDrop = true;
            this.tabPage_Menu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage_Menu.Controls.Add(this.panel_tabPage_Menu_Delete);
            this.tabPage_Menu.Controls.Add(this.panel_tabPage_Menu_View);
            this.tabPage_Menu.Controls.Add(this.panel_tabPage_Menu_Add);
            this.tabPage_Menu.Controls.Add(this.menuStrip1);
            this.tabPage_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Menu.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Menu.Name = "tabPage_Menu";
            this.tabPage_Menu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Menu.Size = new System.Drawing.Size(200, 446);
            this.tabPage_Menu.TabIndex = 0;
            this.tabPage_Menu.Text = "Menu";
            // 
            // panel_tabPage_Menu_Delete
            // 
            this.panel_tabPage_Menu_Delete.BackColor = System.Drawing.Color.GhostWhite;
            this.panel_tabPage_Menu_Delete.Controls.Add(this.label3);
            this.panel_tabPage_Menu_Delete.Controls.Add(this.cb_panel_tabPage_Menu_Contact_Delete);
            this.panel_tabPage_Menu_Delete.Controls.Add(this.bt_panel_tabPage_Menu_Contacts_Delete);
            this.panel_tabPage_Menu_Delete.Location = new System.Drawing.Point(5, 61);
            this.panel_tabPage_Menu_Delete.Name = "panel_tabPage_Menu_Delete";
            this.panel_tabPage_Menu_Delete.Size = new System.Drawing.Size(188, 132);
            this.panel_tabPage_Menu_Delete.TabIndex = 3;
            this.panel_tabPage_Menu_Delete.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // cb_panel_tabPage_Menu_Contact_Delete
            // 
            this.cb_panel_tabPage_Menu_Contact_Delete.FormattingEnabled = true;
            this.cb_panel_tabPage_Menu_Contact_Delete.Location = new System.Drawing.Point(15, 46);
            this.cb_panel_tabPage_Menu_Contact_Delete.Name = "cb_panel_tabPage_Menu_Contact_Delete";
            this.cb_panel_tabPage_Menu_Contact_Delete.Size = new System.Drawing.Size(161, 21);
            this.cb_panel_tabPage_Menu_Contact_Delete.TabIndex = 1;
            // 
            // bt_panel_tabPage_Menu_Contacts_Delete
            // 
            this.bt_panel_tabPage_Menu_Contacts_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_panel_tabPage_Menu_Contacts_Delete.Location = new System.Drawing.Point(52, 91);
            this.bt_panel_tabPage_Menu_Contacts_Delete.Name = "bt_panel_tabPage_Menu_Contacts_Delete";
            this.bt_panel_tabPage_Menu_Contacts_Delete.Size = new System.Drawing.Size(75, 23);
            this.bt_panel_tabPage_Menu_Contacts_Delete.TabIndex = 0;
            this.bt_panel_tabPage_Menu_Contacts_Delete.Text = "Delete";
            this.bt_panel_tabPage_Menu_Contacts_Delete.UseVisualStyleBackColor = true;
            // 
            // panel_tabPage_Menu_View
            // 
            this.panel_tabPage_Menu_View.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_tabPage_Menu_View.Controls.Add(this.label2);
            this.panel_tabPage_Menu_View.Controls.Add(this.cb_panel_tabPage_Menu_Contact_View);
            this.panel_tabPage_Menu_View.Controls.Add(this.bt_panel_tabPage_Menu_Contacts_View);
            this.panel_tabPage_Menu_View.Location = new System.Drawing.Point(3, 62);
            this.panel_tabPage_Menu_View.Name = "panel_tabPage_Menu_View";
            this.panel_tabPage_Menu_View.Size = new System.Drawing.Size(189, 131);
            this.panel_tabPage_Menu_View.TabIndex = 2;
            this.panel_tabPage_Menu_View.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // cb_panel_tabPage_Menu_Contact_View
            // 
            this.cb_panel_tabPage_Menu_Contact_View.FormattingEnabled = true;
            this.cb_panel_tabPage_Menu_Contact_View.Location = new System.Drawing.Point(15, 46);
            this.cb_panel_tabPage_Menu_Contact_View.Name = "cb_panel_tabPage_Menu_Contact_View";
            this.cb_panel_tabPage_Menu_Contact_View.Size = new System.Drawing.Size(161, 21);
            this.cb_panel_tabPage_Menu_Contact_View.TabIndex = 1;
            // 
            // bt_panel_tabPage_Menu_Contacts_View
            // 
            this.bt_panel_tabPage_Menu_Contacts_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_panel_tabPage_Menu_Contacts_View.Location = new System.Drawing.Point(52, 91);
            this.bt_panel_tabPage_Menu_Contacts_View.Name = "bt_panel_tabPage_Menu_Contacts_View";
            this.bt_panel_tabPage_Menu_Contacts_View.Size = new System.Drawing.Size(75, 23);
            this.bt_panel_tabPage_Menu_Contacts_View.TabIndex = 0;
            this.bt_panel_tabPage_Menu_Contacts_View.Text = "View";
            this.bt_panel_tabPage_Menu_Contacts_View.UseVisualStyleBackColor = true;
            this.bt_panel_tabPage_Menu_Contacts_View.Click += new System.EventHandler(this.bt_panel_tabPage_Menu_Contacts_View_Click);
            // 
            // panel_tabPage_Menu_Add
            // 
            this.panel_tabPage_Menu_Add.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_tabPage_Menu_Add.Controls.Add(this.bt_panel_tabPage_Menu__Contacts_Add);
            this.panel_tabPage_Menu_Add.Controls.Add(this.cb_panel_tabPage_Menu_Contact_Add);
            this.panel_tabPage_Menu_Add.Controls.Add(this.label1);
            this.panel_tabPage_Menu_Add.Location = new System.Drawing.Point(4, 62);
            this.panel_tabPage_Menu_Add.Name = "panel_tabPage_Menu_Add";
            this.panel_tabPage_Menu_Add.Size = new System.Drawing.Size(189, 131);
            this.panel_tabPage_Menu_Add.TabIndex = 1;
            this.panel_tabPage_Menu_Add.Visible = false;
            // 
            // bt_panel_tabPage_Menu__Contacts_Add
            // 
            this.bt_panel_tabPage_Menu__Contacts_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_panel_tabPage_Menu__Contacts_Add.Location = new System.Drawing.Point(52, 91);
            this.bt_panel_tabPage_Menu__Contacts_Add.Name = "bt_panel_tabPage_Menu__Contacts_Add";
            this.bt_panel_tabPage_Menu__Contacts_Add.Size = new System.Drawing.Size(75, 23);
            this.bt_panel_tabPage_Menu__Contacts_Add.TabIndex = 2;
            this.bt_panel_tabPage_Menu__Contacts_Add.Text = "Add";
            this.bt_panel_tabPage_Menu__Contacts_Add.UseVisualStyleBackColor = true;
            // 
            // cb_panel_tabPage_Menu_Contact_Add
            // 
            this.cb_panel_tabPage_Menu_Contact_Add.FormattingEnabled = true;
            this.cb_panel_tabPage_Menu_Contact_Add.Location = new System.Drawing.Point(15, 46);
            this.cb_panel_tabPage_Menu_Contact_Add.Name = "cb_panel_tabPage_Menu_Contact_Add";
            this.cb_panel_tabPage_Menu_Contact_Add.Size = new System.Drawing.Size(161, 21);
            this.cb_panel_tabPage_Menu_Contact_Add.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
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
            // toolStripMenuItem1_Contacts
            // 
            this.toolStripMenuItem1_Contacts.BackColor = System.Drawing.Color.Snow;
            this.toolStripMenuItem1_Contacts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.toolStripMenuItem1_Contacts.Name = "toolStripMenuItem1_Contacts";
            this.toolStripMenuItem1_Contacts.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem1_Contacts.Text = "Contacts";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::VideoConferencing.Properties.Resources.contacts;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Image = global::VideoConferencing.Properties.Resources.myspace;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::VideoConferencing.Properties.Resources.Falcon_pro_for_twitter;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.signOutToolStripMenuItem.Text = "SignOut";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // tabPage_Help
            // 
            this.tabPage_Help.Controls.Add(this.menuStrip2);
            this.tabPage_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Help.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Help.Name = "tabPage_Help";
            this.tabPage_Help.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Help.Size = new System.Drawing.Size(200, 446);
            this.tabPage_Help.TabIndex = 1;
            this.tabPage_Help.Text = "Help";
            this.tabPage_Help.UseVisualStyleBackColor = true;
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
            // panel_CallMenu
            // 
            this.panel_CallMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panel_CallMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_CallMenu.Controls.Add(this.button1);
            this.panel_CallMenu.Controls.Add(this.bt_stop_call_Menu);
            this.panel_CallMenu.Controls.Add(this.axVideoChatReceiver1);
            this.panel_CallMenu.Controls.Add(this.axVideoChatSender1);
            this.panel_CallMenu.Controls.Add(this.bt_disconnect_panel_CallMenu);
            this.panel_CallMenu.Controls.Add(this.bt_call_panel_CallMenu);
            this.panel_CallMenu.Location = new System.Drawing.Point(213, 6);
            this.panel_CallMenu.Name = "panel_CallMenu";
            this.panel_CallMenu.Size = new System.Drawing.Size(459, 472);
            this.panel_CallMenu.TabIndex = 1;
            this.panel_CallMenu.Visible = false;
            // 
            // bt_stop_call_Menu
            // 
            this.bt_stop_call_Menu.Location = new System.Drawing.Point(277, 436);
            this.bt_stop_call_Menu.Name = "bt_stop_call_Menu";
            this.bt_stop_call_Menu.Size = new System.Drawing.Size(156, 26);
            this.bt_stop_call_Menu.TabIndex = 5;
            this.bt_stop_call_Menu.Text = "Stop";
            this.bt_stop_call_Menu.UseVisualStyleBackColor = true;
            this.bt_stop_call_Menu.Click += new System.EventHandler(this.bt_stop_call_Menu_Click);
            // 
            // axVideoChatReceiver1
            // 
            this.axVideoChatReceiver1.Enabled = true;
            this.axVideoChatReceiver1.Location = new System.Drawing.Point(7, 7);
            this.axVideoChatReceiver1.Name = "axVideoChatReceiver1";
            this.axVideoChatReceiver1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatReceiver1.OcxState")));
            this.axVideoChatReceiver1.Size = new System.Drawing.Size(444, 252);
            this.axVideoChatReceiver1.TabIndex = 4;
            // 
            // axVideoChatSender1
            // 
            this.axVideoChatSender1.Enabled = true;
            this.axVideoChatSender1.Location = new System.Drawing.Point(266, 265);
            this.axVideoChatSender1.Name = "axVideoChatSender1";
            this.axVideoChatSender1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatSender1.OcxState")));
            this.axVideoChatSender1.Size = new System.Drawing.Size(185, 137);
            this.axVideoChatSender1.TabIndex = 3;
            // 
            // bt_disconnect_panel_CallMenu
            // 
            this.bt_disconnect_panel_CallMenu.Location = new System.Drawing.Point(358, 408);
            this.bt_disconnect_panel_CallMenu.Name = "bt_disconnect_panel_CallMenu";
            this.bt_disconnect_panel_CallMenu.Size = new System.Drawing.Size(75, 26);
            this.bt_disconnect_panel_CallMenu.TabIndex = 2;
            this.bt_disconnect_panel_CallMenu.Text = "Receive";
            this.bt_disconnect_panel_CallMenu.UseVisualStyleBackColor = true;
            this.bt_disconnect_panel_CallMenu.Click += new System.EventHandler(this.bt_disconnect_panel_CallMenu_Click);
            // 
            // bt_call_panel_CallMenu
            // 
            this.bt_call_panel_CallMenu.Location = new System.Drawing.Point(277, 408);
            this.bt_call_panel_CallMenu.Name = "bt_call_panel_CallMenu";
            this.bt_call_panel_CallMenu.Size = new System.Drawing.Size(75, 26);
            this.bt_call_panel_CallMenu.TabIndex = 1;
            this.bt_call_panel_CallMenu.Text = "Call";
            this.bt_call_panel_CallMenu.UseVisualStyleBackColor = true;
            this.bt_call_panel_CallMenu.Click += new System.EventHandler(this.bt_call_panel_CallMenu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(676, 481);
            this.Controls.Add(this.panel_CallMenu);
            this.Controls.Add(this.panel_VideoChat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Conferencing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Form_FormClosed);
            this.panel_VideoChat.ResumeLayout(false);
            this.tc_contactsDetails.ResumeLayout(false);
            this.tabPage_Menu.ResumeLayout(false);
            this.tabPage_Menu.PerformLayout();
            this.panel_tabPage_Menu_Delete.ResumeLayout(false);
            this.panel_tabPage_Menu_Delete.PerformLayout();
            this.panel_tabPage_Menu_View.ResumeLayout(false);
            this.panel_tabPage_Menu_View.PerformLayout();
            this.panel_tabPage_Menu_Add.ResumeLayout(false);
            this.panel_tabPage_Menu_Add.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage_Help.ResumeLayout(false);
            this.tabPage_Help.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel_CallMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatSender1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_VideoChat;
        private System.Windows.Forms.Panel panel_CallMenu;
        private System.Windows.Forms.TabControl tc_contactsDetails;
        private System.Windows.Forms.TabPage tabPage_Menu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage tabPage_Help;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suggesstionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1_Contacts;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Panel panel_tabPage_Menu_Add;
        private System.Windows.Forms.Button bt_panel_tabPage_Menu__Contacts_Add;
        private System.Windows.Forms.ComboBox cb_panel_tabPage_Menu_Contact_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_tabPage_Menu_View;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_panel_tabPage_Menu_Contact_View;
        private System.Windows.Forms.Button bt_panel_tabPage_Menu_Contacts_View;
        private System.Windows.Forms.Panel panel_tabPage_Menu_Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_panel_tabPage_Menu_Contact_Delete;
        private System.Windows.Forms.Button bt_panel_tabPage_Menu_Contacts_Delete;
        private System.Windows.Forms.Button bt_disconnect_panel_CallMenu;
        private System.Windows.Forms.Button bt_call_panel_CallMenu;
        private AxVideoChatReceiverLib.AxVideoChatReceiver axVideoChatReceiver1;
        private AxVideoChatSenderLib.AxVideoChatSender axVideoChatSender1;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Button bt_stop_call_Menu;
        private System.Windows.Forms.Button button1;
    }
}

