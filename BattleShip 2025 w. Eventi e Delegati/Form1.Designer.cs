namespace BattleShip_2025_w._Eventi_e_Delegati
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pct_Logo = new PictureBox();
            btn_SinglePlayer = new Button();
            btn_MultiPlayer = new Button();
            lbl_Copy = new Label();
            ((System.ComponentModel.ISupportInitialize)pct_Logo).BeginInit();
            SuspendLayout();
            // 
            // pct_Logo
            // 
            pct_Logo.Image = Properties.Resources._250px_Battleship_naval_game_logo;
            pct_Logo.Location = new Point(274, 117);
            pct_Logo.Name = "pct_Logo";
            pct_Logo.Size = new Size(253, 67);
            pct_Logo.TabIndex = 0;
            pct_Logo.TabStop = false;
            // 
            // btn_SinglePlayer
            // 
            btn_SinglePlayer.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_SinglePlayer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_SinglePlayer.Location = new Point(274, 215);
            btn_SinglePlayer.Name = "btn_SinglePlayer";
            btn_SinglePlayer.Size = new Size(257, 63);
            btn_SinglePlayer.TabIndex = 1;
            btn_SinglePlayer.Text = "👤 | Single Player";
            btn_SinglePlayer.UseVisualStyleBackColor = true;
            btn_SinglePlayer.Click += btn_SinglePlayer_Click;
            // 
            // btn_MultiPlayer
            // 
            btn_MultiPlayer.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_MultiPlayer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_MultiPlayer.Location = new Point(274, 294);
            btn_MultiPlayer.Name = "btn_MultiPlayer";
            btn_MultiPlayer.Size = new Size(257, 63);
            btn_MultiPlayer.TabIndex = 2;
            btn_MultiPlayer.Text = "🗣👤 | Multi Player";
            btn_MultiPlayer.TextAlign = ContentAlignment.MiddleLeft;
            btn_MultiPlayer.UseVisualStyleBackColor = true;
            btn_MultiPlayer.Click += btn_MultiPlayer_Click;
            // 
            // lbl_Copy
            // 
            lbl_Copy.AutoSize = true;
            lbl_Copy.Location = new Point(645, 426);
            lbl_Copy.Name = "lbl_Copy";
            lbl_Copy.Size = new Size(143, 15);
            lbl_Copy.TabIndex = 3;
            lbl_Copy.Text = "© Falcari Alessandro 2025";
            lbl_Copy.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Copy);
            Controls.Add(btn_MultiPlayer);
            Controls.Add(btn_SinglePlayer);
            Controls.Add(pct_Logo);
            Name = "Form1";
            Text = "BattleShip";
            ((System.ComponentModel.ISupportInitialize)pct_Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pct_Logo;
        private Button btn_SinglePlayer;
        private Button btn_MultiPlayer;
        private Label lbl_Copy;
    }
}