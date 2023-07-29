namespace GSMS.GUI
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.user_Display_Panel = new System.Windows.Forms.TableLayoutPanel();
            this.product_Sale_txt = new System.Windows.Forms.TextBox();
            this.product_Quantity_txt = new System.Windows.Forms.TextBox();
            this.product_Price_txt = new System.Windows.Forms.TextBox();
            this.product_Quantity_lbl = new System.Windows.Forms.Label();
            this.product_Price_lbl = new System.Windows.Forms.Label();
            this.product_Name_lbl = new System.Windows.Forms.Label();
            this.product_Sale_lbl = new System.Windows.Forms.Label();
            this.product_Name_txt = new System.Windows.Forms.TextBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSuccess = new System.Windows.Forms.ErrorProvider(this.components);
            this.user_Display_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSuccess)).BeginInit();
            this.SuspendLayout();
            // 
            // user_Display_Panel
            // 
            this.user_Display_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user_Display_Panel.ColumnCount = 2;
            this.user_Display_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.user_Display_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.user_Display_Panel.Controls.Add(this.product_Sale_txt, 1, 3);
            this.user_Display_Panel.Controls.Add(this.product_Quantity_txt, 1, 2);
            this.user_Display_Panel.Controls.Add(this.product_Price_txt, 1, 1);
            this.user_Display_Panel.Controls.Add(this.product_Quantity_lbl, 0, 2);
            this.user_Display_Panel.Controls.Add(this.product_Price_lbl, 0, 1);
            this.user_Display_Panel.Controls.Add(this.product_Name_lbl, 0, 0);
            this.user_Display_Panel.Controls.Add(this.product_Sale_lbl, 0, 3);
            this.user_Display_Panel.Controls.Add(this.product_Name_txt, 1, 0);
            this.user_Display_Panel.Location = new System.Drawing.Point(144, 66);
            this.user_Display_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.user_Display_Panel.Name = "user_Display_Panel";
            this.user_Display_Panel.RowCount = 4;
            this.user_Display_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.user_Display_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.user_Display_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.user_Display_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.user_Display_Panel.Size = new System.Drawing.Size(558, 274);
            this.user_Display_Panel.TabIndex = 0;
            // 
            // product_Sale_txt
            // 
            this.product_Sale_txt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_Sale_txt.Location = new System.Drawing.Point(319, 224);
            this.product_Sale_txt.Margin = new System.Windows.Forms.Padding(40, 20, 20, 30);
            this.product_Sale_txt.Name = "product_Sale_txt";
            this.product_Sale_txt.Size = new System.Drawing.Size(217, 29);
            this.product_Sale_txt.TabIndex = 4;
            this.product_Sale_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.product_Sale_txt_KeyPress);
            this.product_Sale_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.product_Sale_txt_KeyUp);
            this.product_Sale_txt.Validating += new System.ComponentModel.CancelEventHandler(this.product_Sale_txt_Validating);
            // 
            // product_Quantity_txt
            // 
            this.product_Quantity_txt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_Quantity_txt.Location = new System.Drawing.Point(319, 156);
            this.product_Quantity_txt.Margin = new System.Windows.Forms.Padding(40, 20, 20, 30);
            this.product_Quantity_txt.Name = "product_Quantity_txt";
            this.product_Quantity_txt.Size = new System.Drawing.Size(217, 29);
            this.product_Quantity_txt.TabIndex = 3;
            this.product_Quantity_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.product_Quantity_txt_KeyPress);
            this.product_Quantity_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.product_Quantity_txt_KeyUp);
            this.product_Quantity_txt.Validating += new System.ComponentModel.CancelEventHandler(this.product_Quantity_txt_Validating);
            // 
            // product_Price_txt
            // 
            this.product_Price_txt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_Price_txt.Location = new System.Drawing.Point(319, 88);
            this.product_Price_txt.Margin = new System.Windows.Forms.Padding(40, 20, 20, 30);
            this.product_Price_txt.Name = "product_Price_txt";
            this.product_Price_txt.Size = new System.Drawing.Size(217, 29);
            this.product_Price_txt.TabIndex = 2;
            this.product_Price_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.product_Price_txt_KeyPress);
            this.product_Price_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.product_Price_txt_KeyUp);
            this.product_Price_txt.Validating += new System.ComponentModel.CancelEventHandler(this.product_Price_txt_Validating);
            // 
            // product_Quantity_lbl
            // 
            this.product_Quantity_lbl.AutoSize = true;
            this.product_Quantity_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_Quantity_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_Quantity_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.product_Quantity_lbl.Location = new System.Drawing.Point(3, 136);
            this.product_Quantity_lbl.Name = "product_Quantity_lbl";
            this.product_Quantity_lbl.Padding = new System.Windows.Forms.Padding(80, 25, 20, 20);
            this.product_Quantity_lbl.Size = new System.Drawing.Size(273, 68);
            this.product_Quantity_lbl.TabIndex = 0;
            this.product_Quantity_lbl.Text = "Product Quantity:";
            // 
            // product_Price_lbl
            // 
            this.product_Price_lbl.AutoSize = true;
            this.product_Price_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_Price_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_Price_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.product_Price_lbl.Location = new System.Drawing.Point(3, 68);
            this.product_Price_lbl.Name = "product_Price_lbl";
            this.product_Price_lbl.Padding = new System.Windows.Forms.Padding(80, 25, 20, 20);
            this.product_Price_lbl.Size = new System.Drawing.Size(273, 68);
            this.product_Price_lbl.TabIndex = 0;
            this.product_Price_lbl.Text = "Product Price:";
            // 
            // product_Name_lbl
            // 
            this.product_Name_lbl.AutoSize = true;
            this.product_Name_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_Name_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_Name_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.product_Name_lbl.Location = new System.Drawing.Point(3, 0);
            this.product_Name_lbl.Name = "product_Name_lbl";
            this.product_Name_lbl.Padding = new System.Windows.Forms.Padding(80, 25, 20, 20);
            this.product_Name_lbl.Size = new System.Drawing.Size(273, 68);
            this.product_Name_lbl.TabIndex = 0;
            this.product_Name_lbl.Text = "Product Name:";
            // 
            // product_Sale_lbl
            // 
            this.product_Sale_lbl.AutoSize = true;
            this.product_Sale_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_Sale_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_Sale_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.product_Sale_lbl.Location = new System.Drawing.Point(3, 204);
            this.product_Sale_lbl.Name = "product_Sale_lbl";
            this.product_Sale_lbl.Padding = new System.Windows.Forms.Padding(80, 25, 20, 20);
            this.product_Sale_lbl.Size = new System.Drawing.Size(273, 70);
            this.product_Sale_lbl.TabIndex = 0;
            this.product_Sale_lbl.Text = "Product Sale:";
            // 
            // product_Name_txt
            // 
            this.product_Name_txt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_Name_txt.Location = new System.Drawing.Point(319, 20);
            this.product_Name_txt.Margin = new System.Windows.Forms.Padding(40, 20, 20, 30);
            this.product_Name_txt.Name = "product_Name_txt";
            this.product_Name_txt.Size = new System.Drawing.Size(219, 29);
            this.product_Name_txt.TabIndex = 1;
            this.product_Name_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.product_Name_txt_KeyPress);
            this.product_Name_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.product_Name_txt_KeyUp);
            this.product_Name_txt.Validating += new System.ComponentModel.CancelEventHandler(this.product_Name_txt_Validating);
            // 
            // Add_btn
            // 
            this.Add_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Add_btn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_btn.Location = new System.Drawing.Point(589, 362);
            this.Add_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(113, 43);
            this.Add_btn.TabIndex = 4;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Back_btn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back_btn.Location = new System.Drawing.Point(151, 362);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(113, 43);
            this.Back_btn.TabIndex = 6;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
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
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(823, 481);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.user_Display_Panel);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.user_Display_Panel.ResumeLayout(false);
            this.user_Display_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSuccess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel user_Display_Panel;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Label product_Quantity_lbl;
        private System.Windows.Forms.Label product_Price_lbl;
        private System.Windows.Forms.Label product_Name_lbl;
        private System.Windows.Forms.Label product_Sale_lbl;
        private System.Windows.Forms.TextBox product_Name_txt;
        private System.Windows.Forms.TextBox product_Sale_txt;
        private System.Windows.Forms.TextBox product_Quantity_txt;
        private System.Windows.Forms.TextBox product_Price_txt;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ErrorProvider epSuccess;
    }
}