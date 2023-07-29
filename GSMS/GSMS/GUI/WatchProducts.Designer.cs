namespace GSMS.GUI
{
    partial class WatchProducts
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
            this.Bill_TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.total_Bill_lbl = new System.Windows.Forms.Label();
            this.bill_lbl = new System.Windows.Forms.Label();
            this.GV = new System.Windows.Forms.DataGridView();
            this.Back_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Bill_TablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Bill_TablePanel);
            this.panel1.Controls.Add(this.GV);
            this.panel1.Controls.Add(this.Back_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 483);
            this.panel1.TabIndex = 0;
            // 
            // Bill_TablePanel
            // 
            this.Bill_TablePanel.ColumnCount = 2;
            this.Bill_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.09091F));
            this.Bill_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.90909F));
            this.Bill_TablePanel.Controls.Add(this.total_Bill_lbl, 1, 0);
            this.Bill_TablePanel.Controls.Add(this.bill_lbl, 0, 0);
            this.Bill_TablePanel.Location = new System.Drawing.Point(52, 286);
            this.Bill_TablePanel.Name = "Bill_TablePanel";
            this.Bill_TablePanel.RowCount = 1;
            this.Bill_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Bill_TablePanel.Size = new System.Drawing.Size(244, 38);
            this.Bill_TablePanel.TabIndex = 0;
            // 
            // total_Bill_lbl
            // 
            this.total_Bill_lbl.AutoSize = true;
            this.total_Bill_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.total_Bill_lbl.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Bill_lbl.Location = new System.Drawing.Point(129, 10);
            this.total_Bill_lbl.Margin = new System.Windows.Forms.Padding(10);
            this.total_Bill_lbl.Name = "total_Bill_lbl";
            this.total_Bill_lbl.Size = new System.Drawing.Size(105, 18);
            this.total_Bill_lbl.TabIndex = 0;
            this.total_Bill_lbl.Text = "Bill";
            // 
            // bill_lbl
            // 
            this.bill_lbl.AutoSize = true;
            this.bill_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bill_lbl.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_lbl.Location = new System.Drawing.Point(10, 10);
            this.bill_lbl.Margin = new System.Windows.Forms.Padding(10);
            this.bill_lbl.Name = "bill_lbl";
            this.bill_lbl.Size = new System.Drawing.Size(99, 18);
            this.bill_lbl.TabIndex = 0;
            this.bill_lbl.Text = "Total Bill :";
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
            this.GV.Location = new System.Drawing.Point(52, 59);
            this.GV.Name = "GV";
            this.GV.Size = new System.Drawing.Size(667, 210);
            this.GV.TabIndex = 4;
            // 
            // Back_btn
            // 
            this.Back_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Back_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back_btn.Location = new System.Drawing.Point(584, 276);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(135, 48);
            this.Back_btn.TabIndex = 5;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // WatchProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 483);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WatchProducts";
            this.Text = "WatchProducts";
            this.panel1.ResumeLayout(false);
            this.Bill_TablePanel.ResumeLayout(false);
            this.Bill_TablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.TableLayoutPanel Bill_TablePanel;
        private System.Windows.Forms.Label bill_lbl;
        private System.Windows.Forms.Label total_Bill_lbl;
    }
}