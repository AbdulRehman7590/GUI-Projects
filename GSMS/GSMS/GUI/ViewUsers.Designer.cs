namespace GSMS.GUI
{
    partial class ViewUsers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GV = new System.Windows.Forms.DataGridView();
            this.Back_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.GV);
            this.panel1.Controls.Add(this.Back_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 464);
            this.panel1.TabIndex = 0;
            // 
            // GV
            // 
            this.GV.AllowUserToOrderColumns = true;
            this.GV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Location = new System.Drawing.Point(13, 102);
            this.GV.Margin = new System.Windows.Forms.Padding(4);
            this.GV.Name = "GV";
            this.GV.Size = new System.Drawing.Size(805, 204);
            this.GV.TabIndex = 0;
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Back_btn.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back_btn.Location = new System.Drawing.Point(13, 314);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(135, 48);
            this.Back_btn.TabIndex = 7;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 464);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewUsers";
            this.Text = "ViewUsers";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.Button Back_btn;
    }
}