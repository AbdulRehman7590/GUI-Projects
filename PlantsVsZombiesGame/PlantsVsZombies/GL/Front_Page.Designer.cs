namespace PlantsVsZombies.GL
{
    partial class Front_Page
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
            this.Eit_Btn = new System.Windows.Forms.Button();
            this.Start_Btn = new System.Windows.Forms.Button();
            this.main_Screen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.main_Screen)).BeginInit();
            this.SuspendLayout();
            // 
            // Eit_Btn
            // 
            this.Eit_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Eit_Btn.BackColor = System.Drawing.Color.Teal;
            this.Eit_Btn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eit_Btn.ForeColor = System.Drawing.Color.Transparent;
            this.Eit_Btn.Location = new System.Drawing.Point(333, 208);
            this.Eit_Btn.Name = "Eit_Btn";
            this.Eit_Btn.Size = new System.Drawing.Size(121, 41);
            this.Eit_Btn.TabIndex = 2;
            this.Eit_Btn.Text = "Exit";
            this.Eit_Btn.UseVisualStyleBackColor = false;
            this.Eit_Btn.Click += new System.EventHandler(this.Eit_Btn_Click);
            // 
            // Start_Btn
            // 
            this.Start_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Start_Btn.BackColor = System.Drawing.Color.Teal;
            this.Start_Btn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Btn.ForeColor = System.Drawing.Color.Transparent;
            this.Start_Btn.Location = new System.Drawing.Point(333, 158);
            this.Start_Btn.Name = "Start_Btn";
            this.Start_Btn.Size = new System.Drawing.Size(121, 41);
            this.Start_Btn.TabIndex = 1;
            this.Start_Btn.Text = "Start";
            this.Start_Btn.UseVisualStyleBackColor = false;
            this.Start_Btn.Click += new System.EventHandler(this.Start_Btn_Click);
            // 
            // main_Screen
            // 
            this.main_Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_Screen.Image = global::PlantsVsZombies.Properties.Resources.Front_page1;
            this.main_Screen.Location = new System.Drawing.Point(0, 0);
            this.main_Screen.Name = "main_Screen";
            this.main_Screen.Size = new System.Drawing.Size(800, 450);
            this.main_Screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.main_Screen.TabIndex = 5;
            this.main_Screen.TabStop = false;
            // 
            // Front_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Eit_Btn);
            this.Controls.Add(this.Start_Btn);
            this.Controls.Add(this.main_Screen);
            this.Name = "Front_Page";
            this.Text = "Front_Page";
            ((System.ComponentModel.ISupportInitialize)(this.main_Screen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Eit_Btn;
        private System.Windows.Forms.Button Start_Btn;
        private System.Windows.Forms.PictureBox main_Screen;
    }
}