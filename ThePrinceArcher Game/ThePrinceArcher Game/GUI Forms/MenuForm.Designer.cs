namespace ThePrinceArcher_Game.GUI_Forms
{
    partial class MenuForm
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
            this.cover_PB = new System.Windows.Forms.PictureBox();
            this.start_Btn = new System.Windows.Forms.Button();
            this.exit_Btn = new System.Windows.Forms.Button();
            this.instruction_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cover_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // cover_PB
            // 
            this.cover_PB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cover_PB.Image = global::ThePrinceArcher_Game.Properties.Resources.cover_image;
            this.cover_PB.Location = new System.Drawing.Point(0, 0);
            this.cover_PB.Name = "cover_PB";
            this.cover_PB.Size = new System.Drawing.Size(800, 450);
            this.cover_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cover_PB.TabIndex = 1;
            this.cover_PB.TabStop = false;
            // 
            // start_Btn
            // 
            this.start_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.start_Btn.BackColor = System.Drawing.Color.Brown;
            this.start_Btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start_Btn.Location = new System.Drawing.Point(495, 98);
            this.start_Btn.Name = "start_Btn";
            this.start_Btn.Size = new System.Drawing.Size(117, 47);
            this.start_Btn.TabIndex = 1;
            this.start_Btn.Text = "Start";
            this.start_Btn.UseVisualStyleBackColor = false;
            this.start_Btn.Click += new System.EventHandler(this.start_Btn_Click);
            // 
            // exit_Btn
            // 
            this.exit_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit_Btn.BackColor = System.Drawing.Color.Brown;
            this.exit_Btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_Btn.Location = new System.Drawing.Point(495, 204);
            this.exit_Btn.Name = "exit_Btn";
            this.exit_Btn.Size = new System.Drawing.Size(117, 47);
            this.exit_Btn.TabIndex = 3;
            this.exit_Btn.Text = "Exit";
            this.exit_Btn.UseVisualStyleBackColor = false;
            this.exit_Btn.Click += new System.EventHandler(this.exit_Btn_Click);
            // 
            // instruction_Btn
            // 
            this.instruction_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instruction_Btn.BackColor = System.Drawing.Color.Brown;
            this.instruction_Btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.instruction_Btn.Location = new System.Drawing.Point(495, 151);
            this.instruction_Btn.Name = "instruction_Btn";
            this.instruction_Btn.Size = new System.Drawing.Size(117, 47);
            this.instruction_Btn.TabIndex = 2;
            this.instruction_Btn.Text = "Instructions";
            this.instruction_Btn.UseVisualStyleBackColor = false;
            this.instruction_Btn.Click += new System.EventHandler(this.instruction_Btn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.instruction_Btn);
            this.Controls.Add(this.exit_Btn);
            this.Controls.Add(this.start_Btn);
            this.Controls.Add(this.cover_PB);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.cover_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cover_PB;
        private System.Windows.Forms.Button start_Btn;
        private System.Windows.Forms.Button exit_Btn;
        private System.Windows.Forms.Button instruction_Btn;
    }
}