namespace ThePrinceArcher_Game.GUI_Forms
{
    partial class StoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoryForm));
            this.story_PB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.story_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // story_PB
            // 
            this.story_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.story_PB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.story_PB.Image = global::ThePrinceArcher_Game.Properties.Resources.story;
            this.story_PB.Location = new System.Drawing.Point(0, 0);
            this.story_PB.Name = "story_PB";
            this.story_PB.Size = new System.Drawing.Size(800, 450);
            this.story_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.story_PB.TabIndex = 0;
            this.story_PB.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 238);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // back_Btn
            // 
            this.back_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_Btn.BackColor = System.Drawing.Color.Sienna;
            this.back_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_Btn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.back_Btn.Location = new System.Drawing.Point(47, 288);
            this.back_Btn.Name = "back_Btn";
            this.back_Btn.Size = new System.Drawing.Size(130, 50);
            this.back_Btn.TabIndex = 1;
            this.back_Btn.Text = "Back";
            this.back_Btn.UseVisualStyleBackColor = false;
            this.back_Btn.Click += new System.EventHandler(this.back_Btn_Click);
            // 
            // StoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.story_PB);
            this.Name = "StoryForm";
            this.Text = "StoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.story_PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox story_PB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_Btn;
    }
}