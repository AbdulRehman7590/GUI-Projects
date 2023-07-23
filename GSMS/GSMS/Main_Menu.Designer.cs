
namespace GSMS
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.MainScreen_Label = new System.Windows.Forms.Label();
            this.lbl_msg1 = new System.Windows.Forms.Label();
            this.lbl_msg2 = new System.Windows.Forms.Label();
            this.lbl_msg3 = new System.Windows.Forms.Label();
            this.lbl_msg4 = new System.Windows.Forms.Label();
            this.signUp_btn = new System.Windows.Forms.Button();
            this.logIn_btn = new System.Windows.Forms.Button();
            this.signUp_Role_Panel = new System.Windows.Forms.Panel();
            this.customer_SignUp_btn = new System.Windows.Forms.Button();
            this.employee_SignUp_btn = new System.Windows.Forms.Button();
            this.admin_SignUp_btn = new System.Windows.Forms.Button();
            this.signUp_Role_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainScreen_Label
            // 
            this.MainScreen_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainScreen_Label.AutoSize = true;
            this.MainScreen_Label.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainScreen_Label.Location = new System.Drawing.Point(311, 37);
            this.MainScreen_Label.Name = "MainScreen_Label";
            this.MainScreen_Label.Size = new System.Drawing.Size(181, 46);
            this.MainScreen_Label.TabIndex = 0;
            this.MainScreen_Label.Text = "City Shop";
            // 
            // lbl_msg1
            // 
            this.lbl_msg1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_msg1.AutoSize = true;
            this.lbl_msg1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg1.Location = new System.Drawing.Point(227, 116);
            this.lbl_msg1.Name = "lbl_msg1";
            this.lbl_msg1.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_msg1.Size = new System.Drawing.Size(355, 26);
            this.lbl_msg1.TabIndex = 0;
            this.lbl_msg1.Text = "Welcome to City Shop! Your one-stop shopping destination.";
            // 
            // lbl_msg2
            // 
            this.lbl_msg2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_msg2.AutoSize = true;
            this.lbl_msg2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lbl_msg2.Location = new System.Drawing.Point(273, 142);
            this.lbl_msg2.Name = "lbl_msg2";
            this.lbl_msg2.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_msg2.Size = new System.Drawing.Size(262, 26);
            this.lbl_msg2.TabIndex = 0;
            this.lbl_msg2.Text = "Browse, buy, and enjoy our vast collection.";
            // 
            // lbl_msg3
            // 
            this.lbl_msg3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_msg3.AutoSize = true;
            this.lbl_msg3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg3.Location = new System.Drawing.Point(273, 168);
            this.lbl_msg3.Name = "lbl_msg3";
            this.lbl_msg3.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_msg3.Size = new System.Drawing.Size(262, 26);
            this.lbl_msg3.TabIndex = 0;
            this.lbl_msg3.Text = "Discover the latest trends, deals, and more.";
            // 
            // lbl_msg4
            // 
            this.lbl_msg4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_msg4.AutoSize = true;
            this.lbl_msg4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg4.Location = new System.Drawing.Point(225, 194);
            this.lbl_msg4.Name = "lbl_msg4";
            this.lbl_msg4.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_msg4.Size = new System.Drawing.Size(357, 26);
            this.lbl_msg4.TabIndex = 0;
            this.lbl_msg4.Text = "We\'re here to make your shopping experience extraordinary.";
            // 
            // signUp_btn
            // 
            this.signUp_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUp_btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.signUp_btn.Location = new System.Drawing.Point(487, 264);
            this.signUp_btn.Name = "signUp_btn";
            this.signUp_btn.Padding = new System.Windows.Forms.Padding(5);
            this.signUp_btn.Size = new System.Drawing.Size(95, 43);
            this.signUp_btn.TabIndex = 1;
            this.signUp_btn.Text = "Sign Up";
            this.signUp_btn.UseVisualStyleBackColor = true;
            this.signUp_btn.Click += new System.EventHandler(this.signUp_btn_Click);
            // 
            // logIn_btn
            // 
            this.logIn_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logIn_btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.logIn_btn.Location = new System.Drawing.Point(228, 264);
            this.logIn_btn.Name = "logIn_btn";
            this.logIn_btn.Size = new System.Drawing.Size(95, 43);
            this.logIn_btn.TabIndex = 2;
            this.logIn_btn.Text = "Log In";
            this.logIn_btn.UseVisualStyleBackColor = true;
            this.logIn_btn.Click += new System.EventHandler(this.logIn_btn_Click);
            // 
            // signUp_Role_Panel
            // 
            this.signUp_Role_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUp_Role_Panel.Controls.Add(this.customer_SignUp_btn);
            this.signUp_Role_Panel.Controls.Add(this.employee_SignUp_btn);
            this.signUp_Role_Panel.Controls.Add(this.admin_SignUp_btn);
            this.signUp_Role_Panel.Location = new System.Drawing.Point(586, 264);
            this.signUp_Role_Panel.Name = "signUp_Role_Panel";
            this.signUp_Role_Panel.Size = new System.Drawing.Size(200, 100);
            this.signUp_Role_Panel.TabIndex = 7;
            // 
            // customer_SignUp_btn
            // 
            this.customer_SignUp_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.customer_SignUp_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_SignUp_btn.Location = new System.Drawing.Point(0, 68);
            this.customer_SignUp_btn.Name = "customer_SignUp_btn";
            this.customer_SignUp_btn.Size = new System.Drawing.Size(200, 34);
            this.customer_SignUp_btn.TabIndex = 4;
            this.customer_SignUp_btn.Text = "Customer";
            this.customer_SignUp_btn.UseVisualStyleBackColor = true;
            this.customer_SignUp_btn.Click += new System.EventHandler(this.customer_SignUp_btn_Click);
            // 
            // employee_SignUp_btn
            // 
            this.employee_SignUp_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.employee_SignUp_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.employee_SignUp_btn.Location = new System.Drawing.Point(0, 34);
            this.employee_SignUp_btn.Name = "employee_SignUp_btn";
            this.employee_SignUp_btn.Size = new System.Drawing.Size(200, 34);
            this.employee_SignUp_btn.TabIndex = 3;
            this.employee_SignUp_btn.Text = "Employee";
            this.employee_SignUp_btn.UseVisualStyleBackColor = true;
            this.employee_SignUp_btn.Click += new System.EventHandler(this.employee_SignUp_btn_Click);
            // 
            // admin_SignUp_btn
            // 
            this.admin_SignUp_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.admin_SignUp_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_SignUp_btn.Location = new System.Drawing.Point(0, 0);
            this.admin_SignUp_btn.Name = "admin_SignUp_btn";
            this.admin_SignUp_btn.Size = new System.Drawing.Size(200, 34);
            this.admin_SignUp_btn.TabIndex = 2;
            this.admin_SignUp_btn.Text = "Admin";
            this.admin_SignUp_btn.UseVisualStyleBackColor = true;
            this.admin_SignUp_btn.Click += new System.EventHandler(this.admin_SignUp_btn_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signUp_Role_Panel);
            this.Controls.Add(this.logIn_btn);
            this.Controls.Add(this.signUp_btn);
            this.Controls.Add(this.lbl_msg4);
            this.Controls.Add(this.lbl_msg3);
            this.Controls.Add(this.lbl_msg2);
            this.Controls.Add(this.lbl_msg1);
            this.Controls.Add(this.MainScreen_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Menu";
            this.Text = "City Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Menu_FormClosed);
            this.signUp_Role_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainScreen_Label;
        private System.Windows.Forms.Label lbl_msg1;
        private System.Windows.Forms.Label lbl_msg2;
        private System.Windows.Forms.Label lbl_msg3;
        private System.Windows.Forms.Label lbl_msg4;
        private System.Windows.Forms.Button signUp_btn;
        private System.Windows.Forms.Button logIn_btn;
        private System.Windows.Forms.Panel signUp_Role_Panel;
        private System.Windows.Forms.Button customer_SignUp_btn;
        private System.Windows.Forms.Button employee_SignUp_btn;
        private System.Windows.Forms.Button admin_SignUp_btn;
    }
}

