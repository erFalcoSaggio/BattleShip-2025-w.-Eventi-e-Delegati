using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip_2025_w._Eventi_e_Delegati
{
    public partial class SinglePlayer : Form
    {
        Button[,] bottoni = new Button[10, 10];

        public SinglePlayer()
        {
            InitializeComponent();
        }

        private void SinglePlayer_Load(object sender, EventArgs e)
        {
            CreaBottoniGriglia();
        }

        private void CreaBottoniGriglia()
        {
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    Button btn = new Button();
                    btn.Name = $"btn_{r}{c}";
                    btn.Size = new Size(56, 36);
                    btn.BackColor = Color.FromArgb(0, 192, 192);
                    btn.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold);
                    btn.ForeColor = SystemColors.Control;
                    btn.Text = "";
                    //btn.Click += btn_Griglia_Click;

                    // Salva nella matrice
                    bottoni[r, c] = btn;

                    //bottoni[r, c].Click += Cella_ClickGiocatore;

                    // Aggiungi alla griglia
                    tbl_Grid.Controls.Add(btn, c, r);
                }
            }
        }

    }
}
