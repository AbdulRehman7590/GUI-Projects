namespace GSMS.GUI
{
    partial class EmployeeGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeGUI));
            this.employe_SideMenu_Panel = new System.Windows.Forms.Panel();
            this.E_LogOut_btn = new System.Windows.Forms.Button();
            this.E_Messenger_Panel = new System.Windows.Forms.Panel();
            this.E_Read_Message_btn = new System.Windows.Forms.Button();
            this.E_Sent_Message_btn = new System.Windows.Forms.Button();
            this.E_Messenger_btn = new System.Windows.Forms.Button();
            this.E_Announcement_Panel = new System.Windows.Forms.Panel();
            this.E_watch_Announcements_btn = new System.Windows.Forms.Button();
            this.E_make_announcement_btn = new System.Windows.Forms.Button();
            this.E_Announcement_btn = new System.Windows.Forms.Button();
            this.E_OrdersReceive_btn = new System.Windows.Forms.Button();
            this.E_Products_Panel = new System.Windows.Forms.Panel();
            this.E_LowStockProduct_btn = new System.Windows.Forms.Button();
            this.E_ProductsWatch_btn = new System.Windows.Forms.Button();
            this.E_ProductsDetails_btn = new System.Windows.Forms.Button();
            this.employee_Image_Panel = new System.Windows.Forms.Panel();
            this.main_Panel = new System.Windows.Forms.Panel();
            this.menu_Display_Panel = new System.Windows.Forms.Panel();
            this.userData_Panel = new System.Windows.Forms.Panel();
            this.user_PasswordChange_btn = new System.Windows.Forms.Button();
            this.userContact_lbl = new System.Windows.Forms.Label();
            this.userName_lbl = new System.Windows.Forms.Label();
            this.Title_Panel = new System.Windows.Forms.Panel();
            this.Main_image = new System.Windows.Forms.PictureBox();
            this.MainScreen_Label = new System.Windows.Forms.Label();
            this.employe_SideMenu_Panel.SuspendLayout();
            this.E_Messenger_Panel.SuspendLayout();
            this.E_Announcement_Panel.SuspendLayout();
            this.E_Products_Panel.SuspendLayout();
            this.main_Panel.SuspendLayout();
            this.userData_Panel.SuspendLayout();
            this.Title_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_image)).BeginInit();
            this.SuspendLayout();
            // 
            // employe_SideMenu_Panel
            // 
            this.employe_SideMenu_Panel.AutoScroll = true;
            this.employe_SideMenu_Panel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.employe_SideMenu_Panel.Controls.Add(this.E_LogOut_btn);
            this.employe_SideMenu_Panel.Controls.Add(this.E_Messenger_Panel);
            this.employe_SideMenu_Panel.Controls.Add(this.E_Messenger_btn);
            this.employe_SideMenu_Panel.Controls.Add(this.E_Announcement_Panel);
            this.employe_SideMenu_Panel.Controls.Add(this.E_Announcement_btn);
            this.employe_SideMenu_Panel.Controls.Add(this.E_OrdersReceive_btn);
            this.employe_SideMenu_Panel.Controls.Add(this.E_Products_Panel);
            this.employe_SideMenu_Panel.Controls.Add(this.E_ProductsDetails_btn);
            this.employe_SideMenu_Panel.Controls.Add(this.employee_Image_Panel);
            this.employe_SideMenu_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.employe_SideMenu_Panel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employe_SideMenu_Panel.Location = new System.Drawing.Point(0, 0);
            this.employe_SideMenu_Panel.Name = "employe_SideMenu_Panel";
            this.employe_SideMenu_Panel.Size = new System.Drawing.Size(200, 511);
            this.employe_SideMenu_Panel.TabIndex = 0;
            // 
            // E_LogOut_btn
            // 
            this.E_LogOut_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(136)))));
            this.E_LogOut_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.E_LogOut_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.E_LogOut_btn.Location = new System.Drawing.Point(0, 472);
            this.E_LogOut_btn.Name = "E_LogOut_btn";
            this.E_LogOut_btn.Size = new System.Drawing.Size(200, 39);
            this.E_LogOut_btn.TabIndex = 30;
            this.E_LogOut_btn.Text = "Log Out";
            this.E_LogOut_btn.UseVisualStyleBackColor = false;
            this.E_LogOut_btn.Click += new System.EventHandler(this.E_LogOut_btn_Click);
            // 
            // E_Messenger_Panel
            // 
            this.E_Messenger_Panel.Controls.Add(this.E_Read_Message_btn);
            this.E_Messenger_Panel.Controls.Add(this.E_Sent_Message_btn);
            this.E_Messenger_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.E_Messenger_Panel.Location = new System.Drawing.Point(0, 406);
            this.E_Messenger_Panel.Name = "E_Messenger_Panel";
            this.E_Messenger_Panel.Size = new System.Drawing.Size(200, 66);
            this.E_Messenger_Panel.TabIndex = 0;
            // 
            // E_Read_Message_btn
            // 
            this.E_Read_Message_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.E_Read_Message_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.E_Read_Message_btn.Location = new System.Drawing.Point(0, 30);
            this.E_Read_Message_btn.Name = "E_Read_Message_btn";
            this.E_Read_Message_btn.Size = new System.Drawing.Size(200, 36);
            this.E_Read_Message_btn.TabIndex = 17;
            this.E_Read_Message_btn.Text = "Read Message";
            this.E_Read_Message_btn.UseVisualStyleBackColor = true;
            this.E_Read_Message_btn.Click += new System.EventHandler(this.E_Read_Message_btn_Click);
            // 
            // E_Sent_Message_btn
            // 
            this.E_Sent_Message_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.E_Sent_Message_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.E_Sent_Message_btn.Location = new System.Drawing.Point(0, 0);
            this.E_Sent_Message_btn.Name = "E_Sent_Message_btn";
            this.E_Sent_Message_btn.Size = new System.Drawing.Size(200, 30);
            this.E_Sent_Message_btn.TabIndex = 16;
            this.E_Sent_Message_btn.Text = "Sent Message";
            this.E_Sent_Message_btn.UseVisualStyleBackColor = true;
            this.E_Sent_Message_btn.Click += new System.EventHandler(this.E_Sent_Message_btn_Click);
            // 
            // E_Messenger_btn
            // 
            this.E_Messenger_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(136)))));
            this.E_Messenger_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.E_Messenger_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.E_Messenger_btn.Location = new System.Drawing.Point(0, 367);
            this.E_Messenger_btn.Name = "E_Messenger_btn";
            this.E_Messenger_btn.Size = new System.Drawing.Size(200, 39);
            this.E_Messenger_btn.TabIndex = 29;
            this.E_Messenger_btn.Text = "Messenger";
            this.E_Messenger_btn.UseVisualStyleBackColor = false;
            this.E_Messenger_btn.Click += new System.EventHandler(this.E_Messenger_btn_Click);
            // 
            // E_Announcement_Panel
            // 
            this.E_Announcement_Panel.Controls.Add(this.E_watch_Announcements_btn);
            this.E_Announcement_Panel.Controls.Add(this.E_make_announcement_btn);
            this.E_Announcement_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.E_Announcement_Panel.Location = new System.Drawing.Point(0, 309);
            this.E_Announcement_Panel.Name = "E_Announcement_Panel";
            this.E_Announcement_Panel.Size = new System.Drawing.Size(200, 58);
            this.E_Announcement_Panel.TabIndex = 0;
            // 
            // E_watch_Announcements_btn
            // 
            this.E_watch_Announcements_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.E_watch_Announcements_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.E_watch_Announcements_btn.Location = new System.Drawing.Point(0, 30);
            this.E_watch_Announcements_btn.Name = "E_watch_Announcements_btn";
            this.E_watch_Announcements_btn.Size = new System.Drawing.Size(200, 30);
            this.E_watch_Announcements_btn.TabIndex = 18;
            this.E_watch_Announcements_btn.Text = "Watch Announcements";
            this.E_watch_Announcements_btn.UseVisualStyleBackColor = true;
            this.E_watch_Announcements_btn.Click += new System.EventHandler(this.E_watch_Announcements_btn_Click);
            // 
            // E_make_announcement_btn
            // 
            this.E_make_announcement_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.E_make_announcement_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.E_make_announcement_btn.Location = new System.Drawing.Point(0, 0);
            this.E_make_announcement_btn.Name = "E_make_announcement_btn";
            this.E_make_announcement_btn.Size = new System.Drawing.Size(200, 30);
            this.E_make_announcement_btn.TabIndex = 17;
            this.E_make_announcement_btn.Text = "Make Announcement";
            this.E_make_announcement_btn.UseVisualStyleBackColor = true;
            this.E_make_announcement_btn.Click += new System.EventHandler(this.E_make_announcement_btn_Click);
            // 
            // E_Announcement_btn
            // 
            this.E_Announcement_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(136)))));
            this.E_Announcement_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.E_Announcement_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.E_Announcement_btn.Location = new System.Drawing.Point(0, 270);
            this.E_Announcement_btn.Name = "E_Announcement_btn";
            this.E_Announcement_btn.Size = new System.Drawing.Size(200, 39);
            this.E_Announcement_btn.TabIndex = 28;
            this.E_Announcement_btn.Text = "Announcements";
            this.E_Announcement_btn.UseVisualStyleBackColor = false;
            this.E_Announcement_btn.Click += new System.EventHandler(this.E_Announcement_btn_Click);
            // 
            // E_OrdersReceive_btn
            // 
            this.E_OrdersReceive_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(136)))));
            this.E_OrdersReceive_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.E_OrdersReceive_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.E_OrdersReceive_btn.Location = new System.Drawing.Point(0, 231);
            this.E_OrdersReceive_btn.Name = "E_OrdersReceive_btn";
            this.E_OrdersReceive_btn.Size = new System.Drawing.Size(200, 39);
            this.E_OrdersReceive_btn.TabIndex = 26;
            this.E_OrdersReceive_btn.Text = "Orders Received";
            this.E_OrdersReceive_btn.UseVisualStyleBackColor = false;
            this.E_OrdersReceive_btn.Click += new System.EventHandler(this.E_OrdersReceive_btn_Click);
            // 
            // E_Products_Panel
            // 
            this.E_Products_Panel.Controls.Add(this.E_LowStockProduct_btn);
            this.E_Products_Panel.Controls.Add(this.E_ProductsWatch_btn);
            this.E_Products_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.E_Products_Panel.Location = new System.Drawing.Point(0, 171);
            this.E_Products_Panel.Name = "E_Products_Panel";
            this.E_Products_Panel.Size = new System.Drawing.Size(200, 60);
            this.E_Products_Panel.TabIndex = 0;
            // 
            // E_LowStockProduct_btn
            // 
            this.E_LowStockProduct_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.E_LowStockProduct_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.E_LowStockProduct_btn.Location = new System.Drawing.Point(0, 30);
            this.E_LowStockProduct_btn.Name = "E_LowStockProduct_btn";
            this.E_LowStockProduct_btn.Size = new System.Drawing.Size(200, 30);
            this.E_LowStockProduct_btn.TabIndex = 22;
            this.E_LowStockProduct_btn.Text = "Less Quantity Product";
            this.E_LowStockProduct_btn.UseVisualStyleBackColor = true;
            this.E_LowStockProduct_btn.Click += new System.EventHandler(this.E_LowStockProduct_btn_Click);
            // 
            // E_ProductsWatch_btn
            // 
            this.E_ProductsWatch_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.E_ProductsWatch_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.E_ProductsWatch_btn.Location = new System.Drawing.Point(0, 0);
            this.E_ProductsWatch_btn.Name = "E_ProductsWatch_btn";
            this.E_ProductsWatch_btn.Size = new System.Drawing.Size(200, 30);
            this.E_ProductsWatch_btn.TabIndex = 21;
            this.E_ProductsWatch_btn.Text = "Watch Products";
            this.E_ProductsWatch_btn.UseVisualStyleBackColor = true;
            this.E_ProductsWatch_btn.Click += new System.EventHandler(this.E_ProductsWatch_btn_Click);
            // 
            // E_ProductsDetails_btn
            // 
            this.E_ProductsDetails_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(136)))));
            this.E_ProductsDetails_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.E_ProductsDetails_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.E_ProductsDetails_btn.Location = new System.Drawing.Point(0, 132);
            this.E_ProductsDetails_btn.Name = "E_ProductsDetails_btn";
            this.E_ProductsDetails_btn.Size = new System.Drawing.Size(200, 39);
            this.E_ProductsDetails_btn.TabIndex = 25;
            this.E_ProductsDetails_btn.Text = "Products Details";
            this.E_ProductsDetails_btn.UseVisualStyleBackColor = false;
            this.E_ProductsDetails_btn.Click += new System.EventHandler(this.E_ProductsDetails_btn_Click);
            // 
            // employee_Image_Panel
            // 
            this.employee_Image_Panel.BackColor = System.Drawing.Color.LightSlateGray;
            this.employee_Image_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employee_Image_Panel.BackgroundImage")));
            this.employee_Image_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.employee_Image_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.employee_Image_Panel.Location = new System.Drawing.Point(0, 0);
            this.employee_Image_Panel.Name = "employee_Image_Panel";
            this.employee_Image_Panel.Size = new System.Drawing.Size(200, 132);
            this.employee_Image_Panel.TabIndex = 0;
            // 
            // main_Panel
            // 
            this.main_Panel.AutoScroll = true;
            this.main_Panel.Controls.Add(this.menu_Display_Panel);
            this.main_Panel.Controls.Add(this.userData_Panel);
            this.main_Panel.Controls.Add(this.Title_Panel);
            this.main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_Panel.Location = new System.Drawing.Point(200, 0);
            this.main_Panel.Name = "main_Panel";
            this.main_Panel.Size = new System.Drawing.Size(734, 511);
            this.main_Panel.TabIndex = 0;
            // 
            // menu_Display_Panel
            // 
            this.menu_Display_Panel.AutoScroll = true;
            this.menu_Display_Panel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menu_Display_Panel.BackgroundImage = global::GSMS.Properties.Resources.emp_bg_removebg_preview;
            this.menu_Display_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menu_Display_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_Display_Panel.Location = new System.Drawing.Point(0, 150);
            this.menu_Display_Panel.Name = "menu_Display_Panel";
            this.menu_Display_Panel.Size = new System.Drawing.Size(734, 361);
            this.menu_Display_Panel.TabIndex = 0;
            // 
            // userData_Panel
            // 
            this.userData_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.userData_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userData_Panel.Controls.Add(this.user_PasswordChange_btn);
            this.userData_Panel.Controls.Add(this.userContact_lbl);
            this.userData_Panel.Controls.Add(this.userName_lbl);
            this.userData_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userData_Panel.Location = new System.Drawing.Point(0, 93);
            this.userData_Panel.Name = "userData_Panel";
            this.userData_Panel.Size = new System.Drawing.Size(734, 57);
            this.userData_Panel.TabIndex = 3;
            // 
            // user_PasswordChange_btn
            // 
            this.user_PasswordChange_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user_PasswordChange_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(136)))));
            this.user_PasswordChange_btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_PasswordChange_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.user_PasswordChange_btn.Location = new System.Drawing.Point(415, 5);
            this.user_PasswordChange_btn.Name = "user_PasswordChange_btn";
            this.user_PasswordChange_btn.Size = new System.Drawing.Size(135, 39);
            this.user_PasswordChange_btn.TabIndex = 0;
            this.user_PasswordChange_btn.Text = "Change Password";
            this.user_PasswordChange_btn.UseVisualStyleBackColor = false;
            this.user_PasswordChange_btn.Click += new System.EventHandler(this.user_PasswordChange_btn_Click);
            // 
            // userContact_lbl
            // 
            this.userContact_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userContact_lbl.AutoSize = true;
            this.userContact_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userContact_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userContact_lbl.Location = new System.Drawing.Point(241, 19);
            this.userContact_lbl.Name = "userContact_lbl";
            this.userContact_lbl.Size = new System.Drawing.Size(70, 19);
            this.userContact_lbl.TabIndex = 0;
            this.userContact_lbl.Text = "Contact :";
            // 
            // userName_lbl
            // 
            this.userName_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userName_lbl.Location = new System.Drawing.Point(90, 19);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(90, 19);
            this.userName_lbl.TabIndex = 0;
            this.userName_lbl.Text = "UserName :";
            // 
            // Title_Panel
            // 
            this.Title_Panel.BackColor = System.Drawing.Color.CadetBlue;
            this.Title_Panel.Controls.Add(this.Main_image);
            this.Title_Panel.Controls.Add(this.MainScreen_Label);
            this.Title_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title_Panel.Location = new System.Drawing.Point(0, 0);
            this.Title_Panel.Name = "Title_Panel";
            this.Title_Panel.Size = new System.Drawing.Size(734, 93);
            this.Title_Panel.TabIndex = 4;
            // 
            // Main_image
            // 
            this.Main_image.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Main_image.BackgroundImage = global::GSMS.Properties.Resources.mal__2__removebg_preview;
            this.Main_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_image.Location = new System.Drawing.Point(200, 12);
            this.Main_image.Name = "Main_image";
            this.Main_image.Size = new System.Drawing.Size(118, 68);
            this.Main_image.TabIndex = 2;
            this.Main_image.TabStop = false;
            // 
            // MainScreen_Label
            // 
            this.MainScreen_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainScreen_Label.AutoSize = true;
            this.MainScreen_Label.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainScreen_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.MainScreen_Label.Location = new System.Drawing.Point(324, 22);
            this.MainScreen_Label.Name = "MainScreen_Label";
            this.MainScreen_Label.Size = new System.Drawing.Size(181, 46);
            this.MainScreen_Label.TabIndex = 1;
            this.MainScreen_Label.Text = "City Shop";
            // 
            // EmployeeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSMS.Properties.Resources.emp_bg_removebg_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.main_Panel);
            this.Controls.Add(this.employe_SideMenu_Panel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 550);
            this.Name = "EmployeeGUI";
            this.Text = "City Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeGUI_FormClosed);
            this.employe_SideMenu_Panel.ResumeLayout(false);
            this.E_Messenger_Panel.ResumeLayout(false);
            this.E_Announcement_Panel.ResumeLayout(false);
            this.E_Products_Panel.ResumeLayout(false);
            this.main_Panel.ResumeLayout(false);
            this.userData_Panel.ResumeLayout(false);
            this.userData_Panel.PerformLayout();
            this.Title_Panel.ResumeLayout(false);
            this.Title_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel employe_SideMenu_Panel;
        private System.Windows.Forms.Panel employee_Image_Panel;
        private System.Windows.Forms.Panel E_Announcement_Panel;
        private System.Windows.Forms.Button E_Announcement_btn;
        private System.Windows.Forms.Button E_OrdersReceive_btn;
        private System.Windows.Forms.Panel E_Products_Panel;
        private System.Windows.Forms.Button E_LowStockProduct_btn;
        private System.Windows.Forms.Button E_ProductsWatch_btn;
        private System.Windows.Forms.Button E_ProductsDetails_btn;
        private System.Windows.Forms.Panel E_Messenger_Panel;
        private System.Windows.Forms.Button E_Messenger_btn;
        private System.Windows.Forms.Button E_watch_Announcements_btn;
        private System.Windows.Forms.Button E_make_announcement_btn;
        private System.Windows.Forms.Button E_LogOut_btn;
        private System.Windows.Forms.Button E_Read_Message_btn;
        private System.Windows.Forms.Button E_Sent_Message_btn;
        private System.Windows.Forms.Panel main_Panel;
        private System.Windows.Forms.Panel userData_Panel;
        private System.Windows.Forms.Button user_PasswordChange_btn;
        private System.Windows.Forms.Label userContact_lbl;
        private System.Windows.Forms.Label userName_lbl;
        private System.Windows.Forms.Panel Title_Panel;
        private System.Windows.Forms.PictureBox Main_image;
        private System.Windows.Forms.Label MainScreen_Label;
        private System.Windows.Forms.Panel menu_Display_Panel;
    }
}