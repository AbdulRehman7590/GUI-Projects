namespace ThePrinceArcher_Game.GUI_Forms
{
    partial class InstructionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionsForm));
            this.instruction_PB = new System.Windows.Forms.PictureBox();
            this.instructions_Lbl = new System.Windows.Forms.Label();
            this.back_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.instruction_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // instruction_PB
            // 
            this.instruction_PB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instruction_PB.Image = global::ThePrinceArcher_Game.Properties.Resources.instructions;
            this.instruction_PB.Location = new System.Drawing.Point(0, 0);
            this.instruction_PB.Name = "instruction_PB";
            this.instruction_PB.Size = new System.Drawing.Size(800, 450);
            this.instruction_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.instruction_PB.TabIndex = 1;
            this.instruction_PB.TabStop = false;
            // 
            // instructions_Lbl
            // 
            this.instructions_Lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instructions_Lbl.AutoSize = true;
            this.instructions_Lbl.BackColor = System.Drawing.Color.RosyBrown;
            this.instructions_Lbl.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions_Lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.instructions_Lbl.Location = new System.Drawing.Point(382, 124);
            this.instructions_Lbl.Name = "instructions_Lbl";
            this.instructions_Lbl.Size = new System.Drawing.Size(341, 138);
            this.instructions_Lbl.TabIndex = 0;
            this.instructions_Lbl.Text = resources.GetString("instructions_Lbl.Text");
            this.instructions_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // back_Btn
            // 
            this.back_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_Btn.BackColor = System.Drawing.Color.Sienna;
            this.back_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_Btn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.back_Btn.Location = new System.Drawing.Point(490, 290);
            this.back_Btn.Name = "back_Btn";
            this.back_Btn.Size = new System.Drawing.Size(130, 42);
            this.back_Btn.TabIndex = 1;
            this.back_Btn.Text = "Back";
            this.back_Btn.UseVisualStyleBackColor = false;
            this.back_Btn.Click += new System.EventHandler(this.back_Btn_Click);
            // 
            // InstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_Btn);
            this.Controls.Add(this.instructions_Lbl);
            this.Controls.Add(this.instruction_PB);
            this.Name = "InstructionsForm";
            this.Text = "InstructionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.instruction_PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox instruction_PB;
        private System.Windows.Forms.Label instructions_Lbl;
        private System.Windows.Forms.Button back_Btn;
    }
}