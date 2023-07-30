namespace ThePrinceArcher_Game.GUI_Forms
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.pause_Panel = new System.Windows.Forms.Panel();
            this.continue_Btn = new System.Windows.Forms.Button();
            this.return_Btn = new System.Windows.Forms.Button();
            this.showImage_PB = new System.Windows.Forms.PictureBox();
            this.pause_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showImage_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // pause_Panel
            // 
            this.pause_Panel.BackColor = System.Drawing.Color.Silver;
            this.pause_Panel.Controls.Add(this.continue_Btn);
            this.pause_Panel.Controls.Add(this.return_Btn);
            this.pause_Panel.Controls.Add(this.showImage_PB);
            this.pause_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pause_Panel.Location = new System.Drawing.Point(0, 0);
            this.pause_Panel.Name = "pause_Panel";
            this.pause_Panel.Size = new System.Drawing.Size(584, 261);
            this.pause_Panel.TabIndex = 0;
            // 
            // continue_Btn
            // 
            this.continue_Btn.BackColor = System.Drawing.Color.CadetBlue;
            this.continue_Btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continue_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.continue_Btn.Location = new System.Drawing.Point(95, 192);
            this.continue_Btn.Name = "continue_Btn";
            this.continue_Btn.Size = new System.Drawing.Size(148, 43);
            this.continue_Btn.TabIndex = 1;
            this.continue_Btn.Text = "Continue";
            this.continue_Btn.UseVisualStyleBackColor = false;
            this.continue_Btn.Click += new System.EventHandler(this.continue_Btn_Click);
            // 
            // return_Btn
            // 
            this.return_Btn.BackColor = System.Drawing.Color.CadetBlue;
            this.return_Btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.return_Btn.Location = new System.Drawing.Point(284, 192);
            this.return_Btn.Name = "return_Btn";
            this.return_Btn.Size = new System.Drawing.Size(213, 43);
            this.return_Btn.TabIndex = 2;
            this.return_Btn.Text = "Return To Main Menu";
            this.return_Btn.UseVisualStyleBackColor = false;
            this.return_Btn.Click += new System.EventHandler(this.return_Btn_Click);
            // 
            // showImage_PB
            // 
            this.showImage_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showImage_PB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showImage_PB.Location = new System.Drawing.Point(95, 22);
            this.showImage_PB.Name = "showImage_PB";
            this.showImage_PB.Size = new System.Drawing.Size(402, 164);
            this.showImage_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showImage_PB.TabIndex = 0;
            this.showImage_PB.TabStop = false;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.pause_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "MessageForm";
            this.Text = "The Prince Archer";
            this.pause_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showImage_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pause_Panel;
        private System.Windows.Forms.PictureBox showImage_PB;
        private System.Windows.Forms.Button return_Btn;
        private System.Windows.Forms.Button continue_Btn;
    }
}