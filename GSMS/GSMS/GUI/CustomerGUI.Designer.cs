namespace GSMS.GUI
{
    partial class CustomerGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerGUI));
            this.customer_SideMenu_Panel = new System.Windows.Forms.Panel();
            this.C_LogOut_btn = new System.Windows.Forms.Button();
            this.C_Announcement_btn = new System.Windows.Forms.Button();
            this.C_Received_btn = new System.Windows.Forms.Button();
            this.C_Purchase_Panel = new System.Windows.Forms.Panel();
            this.C_OrderGiven_btn = new System.Windows.Forms.Button();
            this.C_Purchase_btn = new System.Windows.Forms.Button();
            this.C_Cart_Panel = new System.Windows.Forms.Panel();
            this.C_SearchProduct_btn = new System.Windows.Forms.Button();
            this.C_ViewCart_btn = new System.Windows.Forms.Button();
            this.C_Cart_btn = new System.Windows.Forms.Button();
            this.C_Products_Panel = new System.Windows.Forms.Panel();
            this.C_WatchAll_btn = new System.Windows.Forms.Button();
            this.C_Products_Details_btn = new System.Windows.Forms.Button();
            this.customer_Image_Panel = new System.Windows.Forms.Panel();
            this.main_Panel = new System.Windows.Forms.Panel();
            this.menu_Display_Panel = new System.Windows.Forms.Panel();
            this.userData_Panel = new System.Windows.Forms.Panel();
            this.user_PasswordChange_btn = new System.Windows.Forms.Button();
            this.userContact_lbl = new System.Windows.Forms.Label();
            this.userName_lbl = new System.Windows.Forms.Label();
            this.Title_Panel = new System.Windows.Forms.Panel();
            this.Main_image = new System.Windows.Forms.PictureBox();
            this.MainScreen_Label = new System.Windows.Forms.Label();
            this.customer_SideMenu_Panel.SuspendLayout();
            this.C_Purchase_Panel.SuspendLayout();
            this.C_Cart_Panel.SuspendLayout();
            this.C_Products_Panel.SuspendLayout();
            this.main_Panel.SuspendLayout();
            this.userData_Panel.SuspendLayout();
            this.Title_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_image)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_SideMenu_Panel
            // 
            this.customer_SideMenu_Panel.AutoScroll = true;
            this.customer_SideMenu_Panel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.customer_SideMenu_Panel.Controls.Add(this.C_LogOut_btn);
            this.customer_SideMenu_Panel.Controls.Add(this.C_Announcement_btn);
            this.customer_SideMenu_Panel.Controls.Add(this.C_Received_btn);
            this.customer_SideMenu_Panel.Controls.Add(this.C_Purchase_Panel);
            this.customer_SideMenu_Panel.Controls.Add(this.C_Purchase_btn);
            this.customer_SideMenu_Panel.Controls.Add(this.C_Cart_Panel);
            this.customer_SideMenu_Panel.Controls.Add(this.C_Cart_btn);
            this.customer_SideMenu_Panel.Controls.Add(this.C_Products_Panel);
            this.customer_SideMenu_Panel.Controls.Add(this.C_Products_Details_btn);
            this.customer_SideMenu_Panel.Controls.Add(this.customer_Image_Panel);
            this.customer_SideMenu_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.customer_SideMenu_Panel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_SideMenu_Panel.Location = new System.Drawing.Point(0, 0);
            this.customer_SideMenu_Panel.Name = "customer_SideMenu_Panel";
            this.customer_SideMenu_Panel.Size = new System.Drawing.Size(203, 550);
            this.customer_SideMenu_Panel.TabIndex = 0;
            // 
            // C_LogOut_btn
            // 
            this.C_LogOut_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.C_LogOut_btn.Location = new System.Drawing.Point(0, 469);
            this.C_LogOut_btn.Name = "C_LogOut_btn";
            this.C_LogOut_btn.Size = new System.Drawing.Size(203, 39);
            this.C_LogOut_btn.TabIndex = 6;
            this.C_LogOut_btn.Text = "Log Out";
            this.C_LogOut_btn.UseVisualStyleBackColor = true;
            this.C_LogOut_btn.Click += new System.EventHandler(this.C_LogOut_btn_Click);
            // 
            // C_Announcement_btn
            // 
            this.C_Announcement_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.C_Announcement_btn.Location = new System.Drawing.Point(0, 430);
            this.C_Announcement_btn.Name = "C_Announcement_btn";
            this.C_Announcement_btn.Size = new System.Drawing.Size(203, 39);
            this.C_Announcement_btn.TabIndex = 5;
            this.C_Announcement_btn.Text = "Announements";
            this.C_Announcement_btn.UseVisualStyleBackColor = true;
            this.C_Announcement_btn.Click += new System.EventHandler(this.C_Announcement_btn_Click);
            // 
            // C_Received_btn
            // 
            this.C_Received_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.C_Received_btn.Location = new System.Drawing.Point(0, 391);
            this.C_Received_btn.Name = "C_Received_btn";
            this.C_Received_btn.Size = new System.Drawing.Size(203, 39);
            this.C_Received_btn.TabIndex = 4;
            this.C_Received_btn.Text = "Received Items";
            this.C_Received_btn.UseVisualStyleBackColor = true;
            this.C_Received_btn.Click += new System.EventHandler(this.C_Received_btn_Click);
            // 
            // C_Purchase_Panel
            // 
            this.C_Purchase_Panel.Controls.Add(this.C_OrderGiven_btn);
            this.C_Purchase_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.C_Purchase_Panel.Location = new System.Drawing.Point(0, 359);
            this.C_Purchase_Panel.Name = "C_Purchase_Panel";
            this.C_Purchase_Panel.Size = new System.Drawing.Size(203, 32);
            this.C_Purchase_Panel.TabIndex = 0;
            // 
            // C_OrderGiven_btn
            // 
            this.C_OrderGiven_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.C_OrderGiven_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.C_OrderGiven_btn.Location = new System.Drawing.Point(0, 0);
            this.C_OrderGiven_btn.Name = "C_OrderGiven_btn";
            this.C_OrderGiven_btn.Size = new System.Drawing.Size(203, 32);
            this.C_OrderGiven_btn.TabIndex = 3;
            this.C_OrderGiven_btn.Text = "Ordered Items";
            this.C_OrderGiven_btn.UseVisualStyleBackColor = true;
            this.C_OrderGiven_btn.Click += new System.EventHandler(this.C_OrderGiven_btn_Click);
            // 
            // C_Purchase_btn
            // 
            this.C_Purchase_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.C_Purchase_btn.Location = new System.Drawing.Point(0, 320);
            this.C_Purchase_btn.Name = "C_Purchase_btn";
            this.C_Purchase_btn.Size = new System.Drawing.Size(203, 39);
            this.C_Purchase_btn.TabIndex = 3;
            this.C_Purchase_btn.Text = "Purchased items";
            this.C_Purchase_btn.UseVisualStyleBackColor = true;
            this.C_Purchase_btn.Click += new System.EventHandler(this.C_Purchase_btn_Click);
            // 
            // C_Cart_Panel
            // 
            this.C_Cart_Panel.Controls.Add(this.C_SearchProduct_btn);
            this.C_Cart_Panel.Controls.Add(this.C_ViewCart_btn);
            this.C_Cart_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.C_Cart_Panel.Location = new System.Drawing.Point(0, 259);
            this.C_Cart_Panel.Name = "C_Cart_Panel";
            this.C_Cart_Panel.Size = new System.Drawing.Size(203, 61);
            this.C_Cart_Panel.TabIndex = 0;
            // 
            // C_SearchProduct_btn
            // 
            this.C_SearchProduct_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.C_SearchProduct_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.C_SearchProduct_btn.Location = new System.Drawing.Point(0, 31);
            this.C_SearchProduct_btn.Name = "C_SearchProduct_btn";
            this.C_SearchProduct_btn.Size = new System.Drawing.Size(203, 30);
            this.C_SearchProduct_btn.TabIndex = 4;
            this.C_SearchProduct_btn.Text = "Search Product";
            this.C_SearchProduct_btn.UseVisualStyleBackColor = true;
            this.C_SearchProduct_btn.Click += new System.EventHandler(this.C_SearchProduct_btn_Click);
            // 
            // C_ViewCart_btn
            // 
            this.C_ViewCart_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.C_ViewCart_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.C_ViewCart_btn.Location = new System.Drawing.Point(0, 0);
            this.C_ViewCart_btn.Name = "C_ViewCart_btn";
            this.C_ViewCart_btn.Size = new System.Drawing.Size(203, 31);
            this.C_ViewCart_btn.TabIndex = 3;
            this.C_ViewCart_btn.Text = "View Cart";
            this.C_ViewCart_btn.UseVisualStyleBackColor = true;
            this.C_ViewCart_btn.Click += new System.EventHandler(this.C_ViewCart_btn_Click);
            // 
            // C_Cart_btn
            // 
            this.C_Cart_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.C_Cart_btn.Location = new System.Drawing.Point(0, 220);
            this.C_Cart_btn.Name = "C_Cart_btn";
            this.C_Cart_btn.Size = new System.Drawing.Size(203, 39);
            this.C_Cart_btn.TabIndex = 2;
            this.C_Cart_btn.Text = "Cart";
            this.C_Cart_btn.UseVisualStyleBackColor = true;
            this.C_Cart_btn.Click += new System.EventHandler(this.C_Cart_btn_Click);
            // 
            // C_Products_Panel
            // 
            this.C_Products_Panel.Controls.Add(this.C_WatchAll_btn);
            this.C_Products_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.C_Products_Panel.Location = new System.Drawing.Point(0, 189);
            this.C_Products_Panel.Name = "C_Products_Panel";
            this.C_Products_Panel.Size = new System.Drawing.Size(203, 31);
            this.C_Products_Panel.TabIndex = 0;
            // 
            // C_WatchAll_btn
            // 
            this.C_WatchAll_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.C_WatchAll_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.C_WatchAll_btn.Location = new System.Drawing.Point(0, 0);
            this.C_WatchAll_btn.Name = "C_WatchAll_btn";
            this.C_WatchAll_btn.Size = new System.Drawing.Size(203, 31);
            this.C_WatchAll_btn.TabIndex = 2;
            this.C_WatchAll_btn.Text = "Watch All Products";
            this.C_WatchAll_btn.UseVisualStyleBackColor = true;
            this.C_WatchAll_btn.Click += new System.EventHandler(this.C_WatchAll_btn_Click);
            // 
            // C_Products_Details_btn
            // 
            this.C_Products_Details_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.C_Products_Details_btn.Location = new System.Drawing.Point(0, 150);
            this.C_Products_Details_btn.Name = "C_Products_Details_btn";
            this.C_Products_Details_btn.Size = new System.Drawing.Size(203, 39);
            this.C_Products_Details_btn.TabIndex = 1;
            this.C_Products_Details_btn.Text = "Products";
            this.C_Products_Details_btn.UseVisualStyleBackColor = true;
            this.C_Products_Details_btn.Click += new System.EventHandler(this.C_Products_Details_btn_Click);
            // 
            // customer_Image_Panel
            // 
            this.customer_Image_Panel.BackColor = System.Drawing.Color.Silver;
            this.customer_Image_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customer_Image_Panel.BackgroundImage")));
            this.customer_Image_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customer_Image_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.customer_Image_Panel.Location = new System.Drawing.Point(0, 0);
            this.customer_Image_Panel.Name = "customer_Image_Panel";
            this.customer_Image_Panel.Size = new System.Drawing.Size(203, 150);
            this.customer_Image_Panel.TabIndex = 1;
            // 
            // main_Panel
            // 
            this.main_Panel.AutoScroll = true;
            this.main_Panel.Controls.Add(this.menu_Display_Panel);
            this.main_Panel.Controls.Add(this.userData_Panel);
            this.main_Panel.Controls.Add(this.Title_Panel);
            this.main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_Panel.Location = new System.Drawing.Point(203, 0);
            this.main_Panel.Name = "main_Panel";
            this.main_Panel.Size = new System.Drawing.Size(651, 550);
            this.main_Panel.TabIndex = 0;
            // 
            // menu_Display_Panel
            // 
            this.menu_Display_Panel.AutoScroll = true;
            this.menu_Display_Panel.BackgroundImage = global::GSMS.Properties.Resources.cart_removebg_preview;
            this.menu_Display_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menu_Display_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_Display_Panel.Location = new System.Drawing.Point(0, 150);
            this.menu_Display_Panel.Name = "menu_Display_Panel";
            this.menu_Display_Panel.Size = new System.Drawing.Size(651, 400);
            this.menu_Display_Panel.TabIndex = 0;
            // 
            // userData_Panel
            // 
            this.userData_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userData_Panel.Controls.Add(this.user_PasswordChange_btn);
            this.userData_Panel.Controls.Add(this.userContact_lbl);
            this.userData_Panel.Controls.Add(this.userName_lbl);
            this.userData_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userData_Panel.Location = new System.Drawing.Point(0, 93);
            this.userData_Panel.Name = "userData_Panel";
            this.userData_Panel.Size = new System.Drawing.Size(651, 57);
            this.userData_Panel.TabIndex = 3;
            // 
            // user_PasswordChange_btn
            // 
            this.user_PasswordChange_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user_PasswordChange_btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_PasswordChange_btn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.user_PasswordChange_btn.Location = new System.Drawing.Point(401, 9);
            this.user_PasswordChange_btn.Name = "user_PasswordChange_btn";
            this.user_PasswordChange_btn.Size = new System.Drawing.Size(135, 39);
            this.user_PasswordChange_btn.TabIndex = 0;
            this.user_PasswordChange_btn.Text = "Change Password";
            this.user_PasswordChange_btn.UseVisualStyleBackColor = true;
            this.user_PasswordChange_btn.Click += new System.EventHandler(this.user_PasswordChange_btn_Click);
            // 
            // userContact_lbl
            // 
            this.userContact_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userContact_lbl.AutoSize = true;
            this.userContact_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userContact_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.userContact_lbl.Location = new System.Drawing.Point(261, 19);
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
            this.userName_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.userName_lbl.Location = new System.Drawing.Point(110, 19);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(90, 19);
            this.userName_lbl.TabIndex = 0;
            this.userName_lbl.Text = "UserName :";
            // 
            // Title_Panel
            // 
            this.Title_Panel.Controls.Add(this.Main_image);
            this.Title_Panel.Controls.Add(this.MainScreen_Label);
            this.Title_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title_Panel.Location = new System.Drawing.Point(0, 0);
            this.Title_Panel.Name = "Title_Panel";
            this.Title_Panel.Size = new System.Drawing.Size(651, 93);
            this.Title_Panel.TabIndex = 4;
            // 
            // Main_image
            // 
            this.Main_image.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Main_image.BackgroundImage = global::GSMS.Properties.Resources.mal__2__removebg_preview;
            this.Main_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_image.Location = new System.Drawing.Point(161, 12);
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
            this.MainScreen_Label.ForeColor = System.Drawing.Color.DarkMagenta;
            this.MainScreen_Label.Location = new System.Drawing.Point(285, 22);
            this.MainScreen_Label.Name = "MainScreen_Label";
            this.MainScreen_Label.Size = new System.Drawing.Size(181, 46);
            this.MainScreen_Label.TabIndex = 1;
            this.MainScreen_Label.Text = "City Shop";
            // 
            // CustomerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 550);
            this.Controls.Add(this.main_Panel);
            this.Controls.Add(this.customer_SideMenu_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerGUI";
            this.Text = "City Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerGUI_FormClosed);
            this.customer_SideMenu_Panel.ResumeLayout(false);
            this.C_Purchase_Panel.ResumeLayout(false);
            this.C_Cart_Panel.ResumeLayout(false);
            this.C_Products_Panel.ResumeLayout(false);
            this.main_Panel.ResumeLayout(false);
            this.userData_Panel.ResumeLayout(false);
            this.userData_Panel.PerformLayout();
            this.Title_Panel.ResumeLayout(false);
            this.Title_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel customer_SideMenu_Panel;
        private System.Windows.Forms.Panel customer_Image_Panel;
        private System.Windows.Forms.Button C_Products_Details_btn;
        private System.Windows.Forms.Panel C_Products_Panel;
        private System.Windows.Forms.Button C_WatchAll_btn;
        private System.Windows.Forms.Button C_Cart_btn;
        private System.Windows.Forms.Panel C_Cart_Panel;
        private System.Windows.Forms.Button C_ViewCart_btn;
        private System.Windows.Forms.Button C_Purchase_btn;
        private System.Windows.Forms.Panel C_Purchase_Panel;
        private System.Windows.Forms.Button C_OrderGiven_btn;
        private System.Windows.Forms.Button C_Received_btn;
        private System.Windows.Forms.Button C_LogOut_btn;
        private System.Windows.Forms.Button C_Announcement_btn;
        private System.Windows.Forms.Panel main_Panel;
        private System.Windows.Forms.Panel userData_Panel;
        private System.Windows.Forms.Button user_PasswordChange_btn;
        private System.Windows.Forms.Label userContact_lbl;
        private System.Windows.Forms.Label userName_lbl;
        private System.Windows.Forms.Panel Title_Panel;
        private System.Windows.Forms.PictureBox Main_image;
        private System.Windows.Forms.Label MainScreen_Label;
        private System.Windows.Forms.Panel menu_Display_Panel;
        private System.Windows.Forms.Button C_SearchProduct_btn;
    }
}