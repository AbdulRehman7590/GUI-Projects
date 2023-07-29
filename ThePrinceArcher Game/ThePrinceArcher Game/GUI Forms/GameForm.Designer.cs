namespace ThePrinceArcher_Game.GUI_Forms
{
    partial class GameForm
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
            this.bars_Panel = new System.Windows.Forms.Panel();
            this.prince_Health_Bar = new System.Windows.Forms.ProgressBar();
            this.enemy_Health_Bar = new System.Windows.Forms.ProgressBar();
            this.enemy_Health_Lbl = new System.Windows.Forms.Label();
            this.arrow_Lbl = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.arrows = new System.Windows.Forms.Label();
            this.score_Lbl = new System.Windows.Forms.Label();
            this.prince_Health_Lbl = new System.Windows.Forms.Label();
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.gameForm_Panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bars_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bars_Panel
            // 
            this.bars_Panel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bars_Panel.Controls.Add(this.panel1);
            this.bars_Panel.Controls.Add(this.prince_Health_Bar);
            this.bars_Panel.Controls.Add(this.enemy_Health_Bar);
            this.bars_Panel.Controls.Add(this.enemy_Health_Lbl);
            this.bars_Panel.Controls.Add(this.arrow_Lbl);
            this.bars_Panel.Controls.Add(this.score);
            this.bars_Panel.Controls.Add(this.arrows);
            this.bars_Panel.Controls.Add(this.score_Lbl);
            this.bars_Panel.Controls.Add(this.prince_Health_Lbl);
            this.bars_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bars_Panel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bars_Panel.Location = new System.Drawing.Point(0, 322);
            this.bars_Panel.Name = "bars_Panel";
            this.bars_Panel.Size = new System.Drawing.Size(800, 128);
            this.bars_Panel.TabIndex = 1;
            // 
            // prince_Health_Bar
            // 
            this.prince_Health_Bar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prince_Health_Bar.Location = new System.Drawing.Point(41, 72);
            this.prince_Health_Bar.Name = "prince_Health_Bar";
            this.prince_Health_Bar.Size = new System.Drawing.Size(178, 23);
            this.prince_Health_Bar.TabIndex = 0;
            this.prince_Health_Bar.Value = 100;
            // 
            // enemy_Health_Bar
            // 
            this.enemy_Health_Bar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enemy_Health_Bar.Location = new System.Drawing.Point(581, 72);
            this.enemy_Health_Bar.Name = "enemy_Health_Bar";
            this.enemy_Health_Bar.Size = new System.Drawing.Size(178, 23);
            this.enemy_Health_Bar.TabIndex = 0;
            this.enemy_Health_Bar.Value = 100;
            // 
            // enemy_Health_Lbl
            // 
            this.enemy_Health_Lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enemy_Health_Lbl.AutoSize = true;
            this.enemy_Health_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.enemy_Health_Lbl.Location = new System.Drawing.Point(577, 33);
            this.enemy_Health_Lbl.Name = "enemy_Health_Lbl";
            this.enemy_Health_Lbl.Size = new System.Drawing.Size(122, 24);
            this.enemy_Health_Lbl.TabIndex = 0;
            this.enemy_Health_Lbl.Text = "Lord Knight :";
            // 
            // arrow_Lbl
            // 
            this.arrow_Lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrow_Lbl.AutoSize = true;
            this.arrow_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.arrow_Lbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.arrow_Lbl.Location = new System.Drawing.Point(329, 72);
            this.arrow_Lbl.Name = "arrow_Lbl";
            this.arrow_Lbl.Size = new System.Drawing.Size(87, 24);
            this.arrow_Lbl.TabIndex = 0;
            this.arrow_Lbl.Text = " Arrows :";
            // 
            // score
            // 
            this.score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(431, 37);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(30, 22);
            this.score.TabIndex = 0;
            this.score.Text = "00";
            // 
            // arrows
            // 
            this.arrows.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrows.AutoSize = true;
            this.arrows.Location = new System.Drawing.Point(431, 73);
            this.arrows.Name = "arrows";
            this.arrows.Size = new System.Drawing.Size(30, 22);
            this.arrows.TabIndex = 0;
            this.arrows.Text = "00";
            // 
            // score_Lbl
            // 
            this.score_Lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.score_Lbl.AutoSize = true;
            this.score_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.score_Lbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_Lbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.score_Lbl.Location = new System.Drawing.Point(337, 34);
            this.score_Lbl.Name = "score_Lbl";
            this.score_Lbl.Size = new System.Drawing.Size(79, 27);
            this.score_Lbl.TabIndex = 0;
            this.score_Lbl.Text = "Score :";
            // 
            // prince_Health_Lbl
            // 
            this.prince_Health_Lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prince_Health_Lbl.AutoSize = true;
            this.prince_Health_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prince_Health_Lbl.Location = new System.Drawing.Point(37, 34);
            this.prince_Health_Lbl.Name = "prince_Health_Lbl";
            this.prince_Health_Lbl.Size = new System.Drawing.Size(75, 24);
            this.prince_Health_Lbl.TabIndex = 0;
            this.prince_Health_Lbl.Text = "Prince :";
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 200;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // gameForm_Panel
            // 
            this.gameForm_Panel.BackgroundImage = global::ThePrinceArcher_Game.Properties.Resources.bg1;
            this.gameForm_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameForm_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameForm_Panel.Location = new System.Drawing.Point(0, 0);
            this.gameForm_Panel.Name = "gameForm_Panel";
            this.gameForm_Panel.Size = new System.Drawing.Size(800, 322);
            this.gameForm_Panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 10);
            this.panel1.TabIndex = 0;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameForm_Panel);
            this.Controls.Add(this.bars_Panel);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.bars_Panel.ResumeLayout(false);
            this.bars_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel bars_Panel;
        private System.Windows.Forms.ProgressBar prince_Health_Bar;
        private System.Windows.Forms.ProgressBar enemy_Health_Bar;
        private System.Windows.Forms.Label enemy_Health_Lbl;
        private System.Windows.Forms.Label arrow_Lbl;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label arrows;
        private System.Windows.Forms.Label score_Lbl;
        private System.Windows.Forms.Label prince_Health_Lbl;
        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Panel gameForm_Panel;
        private System.Windows.Forms.Panel panel1;
    }
}