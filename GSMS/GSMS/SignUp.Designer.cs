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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.Back_btn = new System.Windows.Forms.Button();
            this.create_Account_btn = new System.Windows.Forms.Button();
            this.signUp_lbl = new System.Windows.Forms.Label();
            this.signUp_userName_txt = new System.Windows.Forms.TextBox();
            this.signUp_Password_txt = new System.Windows.Forms.TextBox();
            this.userName_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.contact_lbl = new System.Windows.Forms.Label();
            this.signUp_Contact_txt = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Back_btn
            // 
            this.Back_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(252, 337);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(90, 45);
            this.Back_btn.TabIndex = 5;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // create_Account_btn
            // 
            this.create_Account_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create_Account_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_Account_btn.Location = new System.Drawing.Point(466, 337);
            this.create_Account_btn.Name = "create_Account_btn";
            this.create_Account_btn.Size = new System.Drawing.Size(90, 45);
            this.create_Account_btn.TabIndex = 4;
            this.create_Account_btn.Text = "Sign Up";
            this.create_Account_btn.UseVisualStyleBackColor = true;
            this.create_Account_btn.Click += new System.EventHandler(this.create_Account_btn_Click);
            // 
            // signUp_lbl
            // 
            this.signUp_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUp_lbl.AutoSize = true;
            this.signUp_lbl.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.signUp_lbl.Location = new System.Drawing.Point(259, 27);
            this.signUp_lbl.Name = "signUp_lbl";
            this.signUp_lbl.Padding = new System.Windows.Forms.Padding(5);
            this.signUp_lbl.Size = new System.Drawing.Size(288, 56);
            this.signUp_lbl.TabIndex = 0;
            this.signUp_lbl.Text = "Sign Up Screen";
            // 
            // signUp_userName_txt
            // 
            this.signUp_userName_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUp_userName_txt.Location = new System.Drawing.Point(396, 136);
            this.signUp_userName_txt.Name = "signUp_userName_txt";
            this.signUp_userName_txt.Size = new System.Drawing.Size(160, 20);
            this.signUp_userName_txt.TabIndex = 1;
            this.signUp_userName_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.signUp_userName_txt_KeyPress);
            // 
            // signUp_Password_txt
            // 
            this.signUp_Password_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUp_Password_txt.Location = new System.Drawing.Point(396, 195);
            this.signUp_Password_txt.Name = "signUp_Password_txt";
            this.signUp_Password_txt.Size = new System.Drawing.Size(160, 20);
            this.signUp_Password_txt.TabIndex = 2;
            // 
            // userName_lbl
            // 
            this.userName_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.userName_lbl.Location = new System.Drawing.Point(248, 135);
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
            this.password_lbl.Location = new System.Drawing.Point(249, 198);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(81, 19);
            this.password_lbl.TabIndex = 0;
            this.password_lbl.Text = "Password: ";
            // 
            // contact_lbl
            // 
            this.contact_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contact_lbl.AutoSize = true;
            this.contact_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_lbl.Location = new System.Drawing.Point(249, 257);
            this.contact_lbl.Name = "contact_lbl";
            this.contact_lbl.Size = new System.Drawing.Size(82, 19);
            this.contact_lbl.TabIndex = 0;
            this.contact_lbl.Text = "Contact # :";
            // 
            // signUp_Contact_txt
            // 
            this.signUp_Contact_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUp_Contact_txt.Location = new System.Drawing.Point(396, 258);
            this.signUp_Contact_txt.Mask = "0000-0000000";
            this.signUp_Contact_txt.Name = "signUp_Contact_txt";
            this.signUp_Contact_txt.Size = new System.Drawing.Size(160, 20);
            this.signUp_Contact_txt.TabIndex = 3;
            this.signUp_Contact_txt.ValidatingType = typeof(int);
            this.signUp_Contact_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.signUp_Contact_txt_KeyPress);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 463);
            this.Controls.Add(this.signUp_Contact_txt);
            this.Controls.Add(this.contact_lbl);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.create_Account_btn);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.userName_lbl);
            this.Controls.Add(this.signUp_Password_txt);
            this.Controls.Add(this.signUp_userName_txt);
            this.Controls.Add(this.signUp_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.Text = "City Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button create_Account_btn;
        private System.Windows.Forms.Label signUp_lbl;
        private System.Windows.Forms.TextBox signUp_userName_txt;
        private System.Windows.Forms.TextBox signUp_Password_txt;
        private System.Windows.Forms.Label userName_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label contact_lbl;
        private System.Windows.Forms.MaskedTextBox signUp_Contact_txt;
    }
}