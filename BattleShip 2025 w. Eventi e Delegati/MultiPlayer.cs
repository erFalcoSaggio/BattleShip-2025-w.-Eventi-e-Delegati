using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BattleShip_2025_w._Eventi_e_Delegati
{
    public partial class MultiPlayer : Form
    {
        // due griglie
        Button[,] grid1 = new Button[10, 10];
        Button[,] grid2 = new Button[10, 10];

        // due campi solita logica=  (0=vuoto, 1=nave, 2=colpito)
        int[,] campo1 = new int[10, 10];
        int[,] campo2 = new int[10, 10];

        // due flotte
        List<Nave> flotta1 = new List<Nave>();
        List<Nave> flotta2 = new List<Nave>();

        int fase = 1;            // 1 = posiziona player1, 2 = posiziona player2, 3 = gioco
        int naveCorrente = 0;    // nave che si sta posizionando
        int turno = 1;           // turno del giocatore (1 o 2)

        List<(int r, int c)> posTemp = new List<(int, int)>();

        public delegate void ClickCellaHandler(int r, int c, int campoID);
        public event ClickCellaHandler OnCellaClick;

        public MultiPlayer()
        {
            InitializeComponent();
            OnCellaClick += GestisciClick;
        }

        private void MultiPlayer_Load(object sender, EventArgs e)
        {
            CreaGriglia(grid1, tbl_Grid1, 1);
            CreaGriglia(grid2, tbl_Grid2, 2);

            CreaFlotta(flotta1);
            CreaFlotta(flotta2);

            Log("Giocatore 1: posiziona la nave da 4 celle.");
        }

        private void CreaFlotta(List<Nave> f)
        {
            f.Add(new Nave(4));
            f.Add(new Nave(3));
            f.Add(new Nave(3));
            f.Add(new Nave(2));
            f.Add(new Nave(2));
            f.Add(new Nave(1));
        }

        private void Log(string testo)
        {
            lstLog.Items.Add(testo);
            lstLog.TopIndex = lstLog.Items.Count - 1; //autoscrolla
        }

        // creazione grìiglia defualt
        private void CreaGriglia(Button[,] griglia, TableLayoutPanel tbl, int campoID)
        {
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    Button b = new Button();
                    b.Size = new Size(40, 40);
                    b.BackColor = Color.FromArgb(0, 192, 192);

                    int rr = r;
                    int cc = c;
                    b.Click += (s, e) => OnCellaClick?.Invoke(rr, cc, campoID);

                    griglia[r, c] = b;
                    tbl.Controls.Add(b, c, r);
                }
            }
        }


        //i vari click
        private void GestisciClick(int r, int c, int campoID)
        {
            if (fase == 1 || fase == 2)
            {
                PosizionaNave(r, c, campoID);
            }
            else // =3
            {
                GiocaTurno(r, c, campoID);
            }
        }

        //pioszionamento
        private void PosizionaNave(int r, int c, int campoID)
        {
            //gliglia sbagliata
            if ((fase == 1 && campoID != 1) || (fase == 2 && campoID != 2))
            {
                Log("Stai posizionando nell'area sbagliata!");
                return;
            }

            int[,] campo = (campoID == 1 ? campo1 : campo2); //guardi su che campo
            Button[,] griglia = (campoID == 1 ? grid1 : grid2); //guardi l'effettiva griglia
            List<Nave> flotta = (campoID == 1 ? flotta1 : flotta2);

            if (campo[r, c] == 1)
            {
                Log("Cella già occupata!");
                return;
            }

            griglia[r, c].BackColor = Color.DarkBlue;
            posTemp.Add((r, c));

            int lung = flotta[naveCorrente].Lunghezza;

            if (posTemp.Count < lung)
                return;

            //controllo se è sulla stessa riga/col

            bool stessaRiga = posTemp.All(p => p.r == posTemp[0].r);
            bool stessaCol = posTemp.All(p => p.c == posTemp[0].c);

            if (!stessaRiga && !stessaCol)
            {
                Log("Le celle devono essere in linea.");
                ResetPosTemp(griglia);
                return;
            }

            if (stessaRiga)
            {
                var col = posTemp.Select(p => p.c).OrderBy(x => x).ToList();
                for (int i = 1; i < col.Count; i++)
                    if (col[i] != col[i - 1] + 1)
                    {
                        Log("Le celle devono essere attaccate.");
                        ResetPosTemp(griglia);
                        return;
                    }
            }
            else
            {
                var rig = posTemp.Select(p => p.r).OrderBy(x => x).ToList();
                for (int i = 1; i < rig.Count; i++)
                    if (rig[i] != rig[i - 1] + 1)
                    {
                        Log("Le celle devono essere attaccate.");
                        ResetPosTemp(griglia);
                        return;
                    }
            }

            foreach (var pos in posTemp)
            {
                campo[pos.r, pos.c] = 1;
                flotta[naveCorrente].Celle.Add(pos);
            }

            Log($"Nave da {lung} celle posizionata.");
            naveCorrente++;
            posTemp.Clear();

            //procedo
            if (naveCorrente == 6)
            {
                if (fase == 1)
                {
                    Log("Giocatore 2 ora posiziona le sue navi.");
                    ResetGriglia(grid1);
                    fase = 2;
                    naveCorrente = 0;
                }
                else
                {
                    Log("Entrambi i giocatori hanno posizionato. Inizia il gioco!");
                    ResetGriglia(grid1);
                    ResetGriglia(grid2);
                    fase = 3;
                }
            }
            else
            {
                Log($"Posiziona la nave da {flotta[naveCorrente].Lunghezza} celle.");
            }
        }


        private void ResetPosTemp(Button[,] griglia)
        {
            foreach (var p in posTemp)
            {
                griglia[p.r, p.c].BackColor = Color.FromArgb(0, 192, 192);
            }
            posTemp.Clear();
        }

        private void ResetGriglia(Button[,] griglia)
        {
            for (int r = 0; r < 10; r++)
                for (int c = 0; c < 10; c++)
                    griglia[r, c].BackColor = Color.FromArgb(0, 192, 192);
        }

        // effettivo gioco
        private void GiocaTurno(int r, int c, int campoID)
        {
            //colpisci la tua griglia
            if ((turno == 1 && campoID == 1) || (turno == 2 && campoID == 2))
            {
                Log("Non puoi colpire il tuo campo!");
                return;
            }

            // vedi l'avversario
            int[,] campoEnemy = (campoID == 1 ? campo1 : campo2);
            Button[,] gridEnemy = (campoID == 1 ? grid1 : grid2);

            if (gridEnemy[r, c].BackColor == Color.Red || gridEnemy[r, c].BackColor == Color.Blue)
                return;

            if (campoEnemy[r, c] == 1)
            {
                campoEnemy[r, c] = 2;
                gridEnemy[r, c].BackColor = Color.Red;
                Log($"Giocatore {turno} ha COLPITO ({r},{c})!");
            }
            else
            {
                gridEnemy[r, c].BackColor = Color.Blue;
                Log($"Giocatore {turno} ha fatto ACQUA ({r},{c}).");
            }

            if (ControllaVittoria(campoEnemy))
            {
                MessageBox.Show($"Giocatore {turno} ha vinto!",
                                "Partita finita!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.Close();
                return;
            }

            turno = (turno == 1 ? 2 : 1);
            lblTurno.Text = $"Turno: Giocatore {turno}";
        }

        private bool ControllaVittoria(int[,] campo)
        {
            for (int r = 0; r < 10; r++)
                for (int c = 0; c < 10; c++)
                    if (campo[r, c] == 1)   //non finito
                        return false;

            return true; //nessuna nave rimasta
        }
    }
}
