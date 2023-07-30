namespace GSMS
{
    partial class Log_In
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_In));
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSuccess = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back_btn = new System.Windows.Forms.Button();
            this.signIn_btn = new System.Windows.Forms.Button();
            this.password_lbl = new System.Windows.Forms.Label();
            this.userName_lbl = new System.Windows.Forms.Label();
            this.logIn_Password_txt = new System.Windows.Forms.TextBox();
            this.logIn_UserName_txt = new System.Windows.Forms.TextBox();
            this.logIn_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSuccess)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // epSuccess
            // 
            this.epSuccess.ContainerControl = this;
            this.epSuccess.Icon = ((System.Drawing.Icon)(resources.GetObject("epSuccess.Icon")));
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Back_btn);
            this.panel1.Controls.Add(this.signIn_btn);
            this.panel1.Controls.Add(this.password_lbl);
            this.panel1.Controls.Add(this.userName_lbl);
            this.panel1.Controls.Add(this.logIn_Password_txt);
            this.panel1.Controls.Add(this.logIn_UserName_txt);
            this.panel1.Controls.Add(this.logIn_lbl);
            this.panel1.Location = new System.Drawing.Point(71, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 354);
            this.panel1.TabIndex = 0;
            // 
            // Back_btn
            // 
            this.Back_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(136)))));
            this.Back_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back_btn.Location = new System.Drawing.Point(174, 275);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(90, 45);
            this.Back_btn.TabIndex = 18;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // signIn_btn
            // 
            this.signIn_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signIn_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(136)))));
            this.signIn_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signIn_btn.Location = new System.Drawing.Point(387, 275);
            this.signIn_btn.Name = "signIn_btn";
            this.signIn_btn.Size = new System.Drawing.Size(90, 45);
            this.signIn_btn.TabIndex = 17;
            this.signIn_btn.Text = "Sign In";
            this.signIn_btn.UseVisualStyleBackColor = false;
            this.signIn_btn.Click += new System.EventHandler(this.signIn_btn_Click);
            // 
            // password_lbl
            // 
            this.password_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_lbl.AutoSize = true;
            this.password_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(136)))));
            this.password_lbl.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.password_lbl.Location = new System.Drawing.Point(170, 209);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(100, 22);
            this.password_lbl.TabIndex = 12;
            this.password_lbl.Text = "Password: ";
            // 
            // userName_lbl
            // 
            this.userName_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(136)))));
            this.userName_lbl.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.userName_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userName_lbl.Location = new System.Drawing.Point(170, 147);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(111, 22);
            this.userName_lbl.TabIndex = 13;
            this.userName_lbl.Text = "User_Name:";
            // 
            // logIn_Password_txt
            // 
            this.logIn_Password_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logIn_Password_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn_Password_txt.Location = new System.Drawing.Point(288, 208);
            this.logIn_Password_txt.Name = "logIn_Password_txt";
            this.logIn_Password_txt.PasswordChar = '*';
            this.logIn_Password_txt.Size = new System.Drawing.Size(189, 26);
            this.logIn_Password_txt.TabIndex = 16;
            this.logIn_Password_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.logIn_Password_txt_KeyUp);
            this.logIn_Password_txt.Validating += new System.ComponentModel.CancelEventHandler(this.logIn_Password_txt_Validating);
            // 
            // logIn_UserName_txt
            // 
            this.logIn_UserName_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logIn_UserName_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn_UserName_txt.Location = new System.Drawing.Point(288, 146);
            this.logIn_UserName_txt.Name = "logIn_UserName_txt";
            this.logIn_UserName_txt.Size = new System.Drawing.Size(189, 26);
            this.logIn_UserName_txt.TabIndex = 15;
            this.logIn_UserName_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.logIn_UserName_txt_KeyPress);
            this.logIn_UserName_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.logIn_UserName_txt_KeyUp);
            this.logIn_UserName_txt.Validating += new System.ComponentModel.CancelEventHandler(this.logIn_UserName_txt_Validating);
            // 
            // logIn_lbl
            // 
            this.logIn_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logIn_lbl.AutoSize = true;
            this.logIn_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(136)))));
            this.logIn_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logIn_lbl.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.logIn_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logIn_lbl.Location = new System.Drawing.Point(248, 35);
            this.logIn_lbl.Name = "logIn_lbl";
            this.logIn_lbl.Padding = new System.Windows.Forms.Padding(5);
            this.logIn_lbl.Size = new System.Drawing.Size(144, 58);
            this.logIn_lbl.TabIndex = 14;
            this.logIn_lbl.Text = "Log In";
            // 
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(136)))));
            this.BackgroundImage = global::GSMS.Properties.Resources.main_BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Log_In";
            this.Text = "City Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Log_In_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSuccess)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ErrorProvider epSuccess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button signIn_btn;
        private System.Windows.Forms.TextBox logIn_Password_txt;
        private System.Windows.Forms.TextBox logIn_UserName_txt;
        private System.Windows.Forms.Label logIn_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label userName_lbl;
    }
}