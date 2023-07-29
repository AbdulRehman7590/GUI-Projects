namespace GSMS
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.signUp_Contact_txt = new System.Windows.Forms.MaskedTextBox();
            this.contact_lbl = new System.Windows.Forms.Label();
            this.Back_btn = new System.Windows.Forms.Button();
            this.create_Account_btn = new System.Windows.Forms.Button();
            this.password_lbl = new System.Windows.Forms.Label();
            this.userName_lbl = new System.Windows.Forms.Label();
            this.signUp_Password_txt = new System.Windows.Forms.TextBox();
            this.signUp_userName_txt = new System.Windows.Forms.TextBox();
            this.signUp_lbl = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSuccess = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSuccess)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.signUp_Contact_txt);
            this.panel1.Controls.Add(this.contact_lbl);
            this.panel1.Controls.Add(this.Back_btn);
            this.panel1.Controls.Add(this.create_Account_btn);
            this.panel1.Controls.Add(this.password_lbl);
            this.panel1.Controls.Add(this.userName_lbl);
            this.panel1.Controls.Add(this.signUp_Password_txt);
            this.panel1.Controls.Add(this.signUp_userName_txt);
            this.panel1.Controls.Add(this.signUp_lbl);
            this.panel1.Location = new System.Drawing.Point(117, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 352);
            this.panel1.TabIndex = 0;
            // 
            // signUp_Contact_txt
            // 
            this.signUp_Contact_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUp_Contact_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_Contact_txt.Location = new System.Drawing.Point(232, 230);
            this.signUp_Contact_txt.Mask = "0000-0000000";
            this.signUp_Contact_txt.Name = "signUp_Contact_txt";
            this.signUp_Contact_txt.Size = new System.Drawing.Size(198, 26);
            this.signUp_Contact_txt.TabIndex = 12;
            this.signUp_Contact_txt.ValidatingType = typeof(int);
            this.signUp_Contact_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.signUp_Contact_txt_KeyPress);
            this.signUp_Contact_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.signUp_Contact_txt_KeyUp);
            this.signUp_Contact_txt.Validating += new System.ComponentModel.CancelEventHandler(this.signUp_Contact_txt_Validating);
            // 
            // contact_lbl
            // 
            this.contact_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contact_lbl.AutoSize = true;
            this.contact_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_lbl.Location = new System.Drawing.Point(123, 233);
            this.contact_lbl.Name = "contact_lbl";
            this.contact_lbl.Size = new System.Drawing.Size(82, 19);
            this.contact_lbl.TabIndex = 6;
            this.contact_lbl.Text = "Contact # :";
            // 
            // Back_btn
            // 
            this.Back_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Back_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back_btn.Location = new System.Drawing.Point(127, 285);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(90, 45);
            this.Back_btn.TabIndex = 14;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // create_Account_btn
            // 
            this.create_Account_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create_Account_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.create_Account_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_Account_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.create_Account_btn.Location = new System.Drawing.Point(333, 285);
            this.create_Account_btn.Name = "create_Account_btn";
            this.create_Account_btn.Size = new System.Drawing.Size(97, 45);
            this.create_Account_btn.TabIndex = 13;
            this.create_Account_btn.Text = "Sign Up";
            this.create_Account_btn.UseVisualStyleBackColor = false;
            this.create_Account_btn.Click += new System.EventHandler(this.create_Account_btn_Click);
            // 
            // password_lbl
            // 
            this.password_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(123, 170);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(81, 19);
            this.password_lbl.TabIndex = 7;
            this.password_lbl.Text = "Password: ";
            // 
            // userName_lbl
            // 
            this.userName_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.userName_lbl.Location = new System.Drawing.Point(123, 111);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(94, 19);
            this.userName_lbl.TabIndex = 8;
            this.userName_lbl.Text = "User_Name:";
            // 
            // signUp_Password_txt
            // 
            this.signUp_Password_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUp_Password_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_Password_txt.Location = new System.Drawing.Point(232, 167);
            this.signUp_Password_txt.Name = "signUp_Password_txt";
            this.signUp_Password_txt.Size = new System.Drawing.Size(198, 26);
            this.signUp_Password_txt.TabIndex = 11;
            this.signUp_Password_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.signUp_Password_txt_KeyUp);
            this.signUp_Password_txt.Validating += new System.ComponentModel.CancelEventHandler(this.signUp_Password_txt_Validating);
            // 
            // signUp_userName_txt
            // 
            this.signUp_userName_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUp_userName_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_userName_txt.Location = new System.Drawing.Point(232, 108);
            this.signUp_userName_txt.Name = "signUp_userName_txt";
            this.signUp_userName_txt.Size = new System.Drawing.Size(198, 26);
            this.signUp_userName_txt.TabIndex = 10;
            this.signUp_userName_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.signUp_userName_txt_KeyPress);
            this.signUp_userName_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.signUp_userName_txt_KeyUp);
            this.signUp_userName_txt.Validating += new System.ComponentModel.CancelEventHandler(this.signUp_userName_txt_Validating);
            // 
            // signUp_lbl
            // 
            this.signUp_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUp_lbl.AutoSize = true;
            this.signUp_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signUp_lbl.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.signUp_lbl.Location = new System.Drawing.Point(132, 18);
            this.signUp_lbl.Name = "signUp_lbl";
            this.signUp_lbl.Padding = new System.Windows.Forms.Padding(5);
            this.signUp_lbl.Size = new System.Drawing.Size(290, 58);
            this.signUp_lbl.TabIndex = 9;
            this.signUp_lbl.Text = "Sign Up Screen";
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
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(804, 463);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.Text = "City Shop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSuccess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox signUp_Contact_txt;
        private System.Windows.Forms.Label contact_lbl;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button create_Account_btn;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label userName_lbl;
        private System.Windows.Forms.TextBox signUp_Password_txt;
        private System.Windows.Forms.TextBox signUp_userName_txt;
        private System.Windows.Forms.Label signUp_lbl;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ErrorProvider epSuccess;
    }
}