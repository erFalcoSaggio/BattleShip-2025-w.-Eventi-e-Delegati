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
            SuspendLayout();
            // 
            // lbl_SinglePlayerTIT
            // 
            lbl_SinglePlayerTIT.AutoSize = true;
            lbl_SinglePlayerTIT.Font = new Font("Reem Kufi", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_SinglePlayerTIT.Location = new Point(318, 37);
            lbl_SinglePlayerTIT.Name = "lbl_SinglePlayerTIT";
            lbl_SinglePlayerTIT.Size = new Size(165, 44);
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
            // SinglePlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}