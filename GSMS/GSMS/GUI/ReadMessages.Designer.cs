namespace GSMS.GUI
{
    partial class ReadMessages
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.display_Panel = new System.Windows.Forms.Panel();
            this.Back_btn = new Guna.UI2.WinForms.Guna2Button();
            this.msg_Display_GV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.display_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msg_Display_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // display_Panel
            // 
            this.display_Panel.Controls.Add(this.Back_btn);
            this.display_Panel.Controls.Add(this.msg_Display_GV);
            this.display_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display_Panel.Location = new System.Drawing.Point(0, 0);
            this.display_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.display_Panel.Name = "display_Panel";
            this.display_Panel.Size = new System.Drawing.Size(875, 486);
            this.display_Panel.TabIndex = 0;
            // 
            // Back_btn
            // 
            this.Back_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Back_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Back_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Back_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Back_btn.FillColor = System.Drawing.Color.PaleTurquoise;
            this.Back_btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.Back_btn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Back_btn.Location = new System.Drawing.Point(88, 318);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(112, 45);
            this.Back_btn.TabIndex = 1;
            this.Back_btn.Text = "Back";
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // msg_Display_GV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.msg_Display_GV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.msg_Display_GV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msg_Display_GV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.msg_Display_GV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.msg_Display_GV.ColumnHeadersHeight = 4;
            this.msg_Display_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.msg_Display_GV.DefaultCellStyle = dataGridViewCellStyle3;
            this.msg_Display_GV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.msg_Display_GV.Location = new System.Drawing.Point(88, 67);
            this.msg_Display_GV.Name = "msg_Display_GV";
            this.msg_Display_GV.RowHeadersVisible = false;
            this.msg_Display_GV.Size = new System.Drawing.Size(685, 234);
            this.msg_Display_GV.TabIndex = 0;
            this.msg_Display_GV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.msg_Display_GV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.msg_Display_GV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.msg_Display_GV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.msg_Display_GV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.msg_Display_GV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.msg_Display_GV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.msg_Display_GV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.msg_Display_GV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.msg_Display_GV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_Display_GV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.msg_Display_GV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.msg_Display_GV.ThemeStyle.HeaderStyle.Height = 4;
            this.msg_Display_GV.ThemeStyle.ReadOnly = false;
            this.msg_Display_GV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.msg_Display_GV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.msg_Display_GV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_Display_GV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.msg_Display_GV.ThemeStyle.RowsStyle.Height = 22;
            this.msg_Display_GV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.msg_Display_GV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ReadMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 486);
            this.Controls.Add(this.display_Panel);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReadMessages";
            this.Text = "ReadMessages";
            this.display_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msg_Display_GV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel display_Panel;
        private Guna.UI2.WinForms.Guna2DataGridView msg_Display_GV;
        private Guna.UI2.WinForms.Guna2Button Back_btn;
    }
}