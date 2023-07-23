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
            this.logIn_lbl = new System.Windows.Forms.Label();
            this.logIn_UserName_txt = new System.Windows.Forms.TextBox();
            this.logIn_Password_txt = new System.Windows.Forms.TextBox();
            this.userName_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.signIn_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSuccess = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSuccess)).BeginInit();
            this.SuspendLayout();
            // 
            // logIn_lbl
            // 
            this.logIn_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logIn_lbl.AutoSize = true;
            this.logIn_lbl.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.logIn_lbl.Location = new System.Drawing.Point(263, 63);
            this.logIn_lbl.Name = "logIn_lbl";
            this.logIn_lbl.Padding = new System.Windows.Forms.Padding(5);
            this.logIn_lbl.Size = new System.Drawing.Size(266, 56);
            this.logIn_lbl.TabIndex = 0;
            this.logIn_lbl.Text = "Log In Screen";
            // 
            // logIn_UserName_txt
            // 
            this.logIn_UserName_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logIn_UserName_txt.Location = new System.Drawing.Point(387, 178);
            this.logIn_UserName_txt.Name = "logIn_UserName_txt";
            this.logIn_UserName_txt.Size = new System.Drawing.Size(160, 20);
            this.logIn_UserName_txt.TabIndex = 1;
            this.logIn_UserName_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.logIn_UserName_txt_KeyPress);
            this.logIn_UserName_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.logIn_UserName_txt_KeyUp);
            // 
            // logIn_Password_txt
            // 
            this.logIn_Password_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logIn_Password_txt.Location = new System.Drawing.Point(387, 237);
            this.logIn_Password_txt.Name = "logIn_Password_txt";
            this.logIn_Password_txt.PasswordChar = '*';
            this.logIn_Password_txt.Size = new System.Drawing.Size(160, 20);
            this.logIn_Password_txt.TabIndex = 2;
            // 
            // userName_lbl
            // 
            this.userName_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.userName_lbl.Location = new System.Drawing.Point(239, 177);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(94, 19);
            this.userName_lbl.TabIndex = 0;
            this.userName_lbl.Text = "User_Name:";
            // 
            // password_lbl
            // 
            this.password_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(240, 240);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(81, 19);
            this.password_lbl.TabIndex = 0;
            this.password_lbl.Text = "Password: ";
            // 
            // signIn_btn
            // 
            this.signIn_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signIn_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn_btn.Location = new System.Drawing.Point(457, 304);
            this.signIn_btn.Name = "signIn_btn";
            this.signIn_btn.Size = new System.Drawing.Size(90, 45);
            this.signIn_btn.TabIndex = 3;
            this.signIn_btn.Text = "Sign In";
            this.signIn_btn.UseVisualStyleBackColor = true;
            this.signIn_btn.Click += new System.EventHandler(this.signIn_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(243, 304);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(90, 45);
            this.Back_btn.TabIndex = 4;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
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
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.signIn_btn);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.userName_lbl);
            this.Controls.Add(this.logIn_Password_txt);
            this.Controls.Add(this.logIn_UserName_txt);
            this.Controls.Add(this.logIn_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Log_In";
            this.Text = "City Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Log_In_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSuccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logIn_lbl;
        private System.Windows.Forms.TextBox logIn_UserName_txt;
        private System.Windows.Forms.TextBox logIn_Password_txt;
        private System.Windows.Forms.Label userName_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Button signIn_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ErrorProvider epSuccess;
    }
}