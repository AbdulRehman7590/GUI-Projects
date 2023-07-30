namespace GSMS.GUI
{
    partial class InputBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputBox));
            this.display_Panel = new System.Windows.Forms.Panel();
            this.update_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.update_Data_Txt = new System.Windows.Forms.TextBox();
            this.updated_lbl = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSuccess = new System.Windows.Forms.ErrorProvider(this.components);
            this.display_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSuccess)).BeginInit();
            this.SuspendLayout();
            // 
            // display_Panel
            // 
            this.display_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.display_Panel.Controls.Add(this.update_btn);
            this.display_Panel.Controls.Add(this.Back_btn);
            this.display_Panel.Controls.Add(this.update_Data_Txt);
            this.display_Panel.Controls.Add(this.updated_lbl);
            this.display_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display_Panel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.display_Panel.Location = new System.Drawing.Point(0, 0);
            this.display_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.display_Panel.Name = "display_Panel";
            this.display_Panel.Size = new System.Drawing.Size(690, 401);
            this.display_Panel.TabIndex = 0;
            // 
            // update_btn
            // 
            this.update_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(136)))));
            this.update_btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_btn.Location = new System.Drawing.Point(407, 192);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(90, 43);
            this.update_btn.TabIndex = 2;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(136)))));
            this.Back_btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back_btn.Location = new System.Drawing.Point(121, 192);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(90, 43);
            this.Back_btn.TabIndex = 3;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // update_Data_Txt
            // 
            this.update_Data_Txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_Data_Txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_Data_Txt.Location = new System.Drawing.Point(298, 125);
            this.update_Data_Txt.Name = "update_Data_Txt";
            this.update_Data_Txt.Size = new System.Drawing.Size(199, 26);
            this.update_Data_Txt.TabIndex = 1;
            this.update_Data_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.update_Data_Txt_KeyPress);
            this.update_Data_Txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update_Data_Txt_KeyUp);
            this.update_Data_Txt.Validating += new System.ComponentModel.CancelEventHandler(this.update_Data_Txt_Validating);
            // 
            // updated_lbl
            // 
            this.updated_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updated_lbl.AutoSize = true;
            this.updated_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updated_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updated_lbl.Location = new System.Drawing.Point(117, 128);
            this.updated_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.updated_lbl.Name = "updated_lbl";
            this.updated_lbl.Size = new System.Drawing.Size(174, 19);
            this.updated_lbl.TabIndex = 0;
            this.updated_lbl.Text = "Enter the updated Data :";
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
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 401);
            this.Controls.Add(this.display_Panel);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InputBox";
            this.Text = "City Shop";
            this.display_Panel.ResumeLayout(false);
            this.display_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSuccess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel display_Panel;
        private System.Windows.Forms.Label updated_lbl;
        private System.Windows.Forms.TextBox update_Data_Txt;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ErrorProvider epSuccess;
    }
}