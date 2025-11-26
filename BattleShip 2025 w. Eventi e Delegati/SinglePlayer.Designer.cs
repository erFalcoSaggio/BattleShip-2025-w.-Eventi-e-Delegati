namespace BattleShip_2025_w._Eventi_e_Delegati
{
    partial class SinglePlayer
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
            lbl_SinglePlayerTIT = new Label();
            tbl_Grid = new TableLayoutPanel();
            lstLog = new ListBox();
            lblMosse = new Label();
            lblMosseTitolo = new Label();
            lblNaviTitolo = new Label();
            lblNavi = new Label();
            SuspendLayout();
            // 
            // lbl_SinglePlayerTIT
            // 
            lbl_SinglePlayerTIT.AutoSize = true;
            lbl_SinglePlayerTIT.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_SinglePlayerTIT.Location = new Point(318, 37);
            lbl_SinglePlayerTIT.Name = "lbl_SinglePlayerTIT";
            lbl_SinglePlayerTIT.Size = new Size(169, 29);
            lbl_SinglePlayerTIT.TabIndex = 0;
            lbl_SinglePlayerTIT.Text = "Single Player";
            // 
            // tbl_Grid
            // 
            tbl_Grid.ColumnCount = 10;
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.Location = new Point(202, 84);
            tbl_Grid.Name = "tbl_Grid";
            tbl_Grid.RowCount = 10;
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_Grid.Size = new Size(403, 342);
            tbl_Grid.TabIndex = 1;
            // 
            // lstLog
            // 
            lstLog.FormattingEnabled = true;
            lstLog.ItemHeight = 15;
            lstLog.Location = new Point(12, 17);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(236, 49);
            lstLog.TabIndex = 2;
            // 
            // lblMosse
            // 
            lblMosse.AutoSize = true;
            lblMosse.Location = new Point(679, 206);
            lblMosse.Name = "lblMosse";
            lblMosse.Size = new Size(38, 15);
            lblMosse.TabIndex = 3;
            lblMosse.Text = "label1";
            // 
            // lblMosseTitolo
            // 
            lblMosseTitolo.AutoSize = true;
            lblMosseTitolo.Location = new Point(629, 206);
            lblMosseTitolo.Name = "lblMosseTitolo";
            lblMosseTitolo.Size = new Size(44, 15);
            lblMosseTitolo.TabIndex = 4;
            lblMosseTitolo.Text = "Mosse:";
            // 
            // lblNaviTitolo
            // 
            lblNaviTitolo.AutoSize = true;
            lblNaviTitolo.Location = new Point(629, 244);
            lblNaviTitolo.Name = "lblNaviTitolo";
            lblNaviTitolo.Size = new Size(34, 15);
            lblNaviTitolo.TabIndex = 6;
            lblNaviTitolo.Text = "Navi:";
            // 
            // lblNavi
            // 
            lblNavi.AutoSize = true;
            lblNavi.Location = new Point(679, 244);
            lblNavi.Name = "lblNavi";
            lblNavi.Size = new Size(38, 15);
            lblNavi.TabIndex = 5;
            lblNavi.Text = "label1";
            // 
            // SinglePlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNaviTitolo);
            Controls.Add(lblNavi);
            Controls.Add(lblMosseTitolo);
            Controls.Add(lblMosse);
            Controls.Add(lstLog);
            Controls.Add(tbl_Grid);
            Controls.Add(lbl_SinglePlayerTIT);
            Name = "SinglePlayer";
            Text = "SinglePlayer";
            Load += SinglePlayer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_SinglePlayerTIT;
        private TableLayoutPanel tbl_Grid;
        private ListBox lstLog;
        private Label lblMosse;
        private Label lblMosseTitolo;
        private Label lblNaviTitolo;
        private Label lblNavi;
    }
}