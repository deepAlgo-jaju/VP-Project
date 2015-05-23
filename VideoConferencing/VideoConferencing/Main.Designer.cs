﻿namespace VideoConferencing
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
            this.components = new System.ComponentModel.Container();
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
            this.bt_disconnect_panel_CallMenu = new System.Windows.Forms.Button();
            this.bt_call_panel_CallMenu = new System.Windows.Forms.Button();
            this.pnl_user1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.text_IP = new System.Windows.Forms.TextBox();
            this.bt_stopCamera = new System.Windows.Forms.Button();
            this.bt_startCamera = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_startVoice = new System.Windows.Forms.Button();
            this.text_Camera_send_port = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_Voice_SendingPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_user2 = new System.Windows.Forms.Panel();
            this.WebCamCapture = new WebCam_Capture.WebCamCapture();
            this.Capturing = new System.Windows.Forms.Timer(this.components);
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
            this.pnl_user1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_user2.SuspendLayout();
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
            this.panel_CallMenu.Controls.Add(this.bt_stop_call_Menu);
            this.panel_CallMenu.Controls.Add(this.bt_disconnect_panel_CallMenu);
            this.panel_CallMenu.Controls.Add(this.bt_call_panel_CallMenu);
            this.panel_CallMenu.Location = new System.Drawing.Point(436, 249);
            this.panel_CallMenu.Name = "panel_CallMenu";
            this.panel_CallMenu.Size = new System.Drawing.Size(47, 27);
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
            // bt_disconnect_panel_CallMenu
            // 
            this.bt_disconnect_panel_CallMenu.Location = new System.Drawing.Point(358, 408);
            this.bt_disconnect_panel_CallMenu.Name = "bt_disconnect_panel_CallMenu";
            this.bt_disconnect_panel_CallMenu.Size = new System.Drawing.Size(75, 26);
            this.bt_disconnect_panel_CallMenu.TabIndex = 2;
            this.bt_disconnect_panel_CallMenu.Text = "Receive";
            this.bt_disconnect_panel_CallMenu.UseVisualStyleBackColor = true;
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
            // pnl_user1
            // 
            this.pnl_user1.Controls.Add(this.label8);
            this.pnl_user1.Controls.Add(this.text_IP);
            this.pnl_user1.Controls.Add(this.bt_stopCamera);
            this.pnl_user1.Controls.Add(this.bt_startCamera);
            this.pnl_user1.Controls.Add(this.bt_stop);
            this.pnl_user1.Controls.Add(this.bt_startVoice);
            this.pnl_user1.Controls.Add(this.text_Camera_send_port);
            this.pnl_user1.Controls.Add(this.label7);
            this.pnl_user1.Controls.Add(this.text_Voice_SendingPort);
            this.pnl_user1.Controls.Add(this.label6);
            this.pnl_user1.Controls.Add(this.label4);
            this.pnl_user1.Controls.Add(this.pictureBox1);
            this.pnl_user1.Location = new System.Drawing.Point(230, 6);
            this.pnl_user1.Name = "pnl_user1";
            this.pnl_user1.Size = new System.Drawing.Size(445, 253);
            this.pnl_user1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(43, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 41;
            this.label8.Text = "Talk With (IP)";
            // 
            // text_IP
            // 
            this.text_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_IP.Location = new System.Drawing.Point(131, 7);
            this.text_IP.Name = "text_IP";
            this.text_IP.Size = new System.Drawing.Size(256, 20);
            this.text_IP.TabIndex = 40;
            this.text_IP.Text = "127.0.0.1";
            // 
            // bt_stopCamera
            // 
            this.bt_stopCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_stopCamera.Location = new System.Drawing.Point(303, 157);
            this.bt_stopCamera.Name = "bt_stopCamera";
            this.bt_stopCamera.Size = new System.Drawing.Size(84, 24);
            this.bt_stopCamera.TabIndex = 39;
            this.bt_stopCamera.Text = "Stop Camera";
            this.bt_stopCamera.Click += new System.EventHandler(this.bt_stopCamera_Click);
            // 
            // bt_startCamera
            // 
            this.bt_startCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_startCamera.Location = new System.Drawing.Point(303, 125);
            this.bt_startCamera.Name = "bt_startCamera";
            this.bt_startCamera.Size = new System.Drawing.Size(84, 24);
            this.bt_startCamera.TabIndex = 38;
            this.bt_startCamera.Text = "Start Camera";
            this.bt_startCamera.Click += new System.EventHandler(this.bt_startCamera_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_stop.Location = new System.Drawing.Point(202, 157);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(89, 24);
            this.bt_stop.TabIndex = 37;
            this.bt_stop.Text = "Stop Voice";
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // bt_startVoice
            // 
            this.bt_startVoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_startVoice.Location = new System.Drawing.Point(202, 127);
            this.bt_startVoice.Name = "bt_startVoice";
            this.bt_startVoice.Size = new System.Drawing.Size(89, 24);
            this.bt_startVoice.TabIndex = 36;
            this.bt_startVoice.Text = "Start Talking";
            this.bt_startVoice.Click += new System.EventHandler(this.bt_startVoice_Click);
            // 
            // text_Camera_send_port
            // 
            this.text_Camera_send_port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_Camera_send_port.Location = new System.Drawing.Point(283, 73);
            this.text_Camera_send_port.Name = "text_Camera_send_port";
            this.text_Camera_send_port.Size = new System.Drawing.Size(104, 20);
            this.text_Camera_send_port.TabIndex = 35;
            this.text_Camera_send_port.Text = "8000";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(225, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Video Port";
            // 
            // text_Voice_SendingPort
            // 
            this.text_Voice_SendingPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_Voice_SendingPort.Location = new System.Drawing.Point(283, 99);
            this.text_Voice_SendingPort.Name = "text_Voice_SendingPort";
            this.text_Voice_SendingPort.Size = new System.Drawing.Size(104, 20);
            this.text_Voice_SendingPort.TabIndex = 33;
            this.text_Voice_SendingPort.Text = "9000";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(225, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Voice Port";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(58, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "My Camera";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(27, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.Location = new System.Drawing.Point(26, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(58, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Remote Camera";
            // 
            // pnl_user2
            // 
            this.pnl_user2.Controls.Add(this.label5);
            this.pnl_user2.Controls.Add(this.pictureBox2);
            this.pnl_user2.Location = new System.Drawing.Point(230, 253);
            this.pnl_user2.Name = "pnl_user2";
            this.pnl_user2.Size = new System.Drawing.Size(445, 221);
            this.pnl_user2.TabIndex = 3;
            // 
            // WebCamCapture
            // 
            this.WebCamCapture.CaptureHeight = 240;
            this.WebCamCapture.CaptureWidth = 320;
            this.WebCamCapture.FrameNumber = ((ulong)(0ul));
            this.WebCamCapture.Location = new System.Drawing.Point(359, 15);
            this.WebCamCapture.Name = "WebCamCapture";
            this.WebCamCapture.Size = new System.Drawing.Size(342, 252);
            this.WebCamCapture.TabIndex = 0;
            this.WebCamCapture.TimeToCapture_milliseconds = 100;
            this.WebCamCapture.ImageCaptured += new WebCam_Capture.WebCamCapture.WebCamEventHandler(this.WebCamCapture_ImageCaptured_1);
            // 
            // Capturing
            // 
            this.Capturing.Tick += new System.EventHandler(this.Capturing_Tick);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(676, 480);
            this.Controls.Add(this.pnl_user2);
            this.Controls.Add(this.pnl_user1);
            this.Controls.Add(this.panel_CallMenu);
            this.Controls.Add(this.panel_VideoChat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Conferencing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Form_FormClosed);
            this.Load += new System.EventHandler(this.Main_Form_Load);
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
            this.pnl_user1.ResumeLayout(false);
            this.pnl_user1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_user2.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Button bt_stop_call_Menu;
        private System.Windows.Forms.Panel pnl_user1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox text_Camera_send_port;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_Voice_SendingPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_stopCamera;
        private System.Windows.Forms.Button bt_startCamera;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_startVoice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_IP;
        private System.Windows.Forms.Panel pnl_user2;
        private WebCam_Capture.WebCamCapture WebCamCapture;
        private System.Windows.Forms.Timer Capturing;
    }
}
