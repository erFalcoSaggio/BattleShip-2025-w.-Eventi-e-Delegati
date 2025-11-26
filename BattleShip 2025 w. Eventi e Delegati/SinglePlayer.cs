using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BattleShip_2025_w._Eventi_e_Delegati
{
    public partial class SinglePlayer : Form
    {
        Button[,] bottoni = new Button[10, 10];
        List<Nave> flotta = new List<Nave>();

        // matrice: 0 = vuoto, 1 = nave, 2 = colpita
        int[,] campo = new int[10, 10];

        // indice della nave che sta venendo posizionata
        int naveCorrente = 0;

        // cele selezionate temporaneamente per la nave corrente
        List<(int r, int c)> posTemp = new List<(int, int)>();

        //contattori
        int mosse = 0;
        int naviNonAffondate = 6;

        public delegate void CellaCliccataHandler(int r, int c);
        public event CellaCliccataHandler OnCellaCliccata;

        bool partitaFinita = false;

        public SinglePlayer()
        {
            InitializeComponent();
            OnCellaCliccata += GestisciCella;
        }

        private void SinglePlayer_Load(object sender, EventArgs e)
        {
            CreaBottoniGriglia();
            CreaFlotta();
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
                    int rr = r;
                    int cc = c;
                    btn.Click += (s, e) => OnCellaCliccata?.Invoke(rr, cc);

                    // Salva nella matrice
                    bottoni[r, c] = btn;

                    //bottoni[r, c].Click += Cella_ClickGiocatore;

                    // Aggiungi alla griglia
                    tbl_Grid.Controls.Add(btn, c, r);
                }
            }
        }


        private void CreaFlotta()
        {
            flotta.Add(new Nave(4)); // 1 nave da 4
            flotta.Add(new Nave(3)); // 2 navi da 3
            flotta.Add(new Nave(3));
            flotta.Add(new Nave(2)); // 2 navi da 2
            flotta.Add(new Nave(2));
            flotta.Add(new Nave(1)); // 1 nave da 1

            // degbug
            //MessageBox.Show("Flotta creata: " + flotta.Count + " navi");
        }

        //funzioncina per aggiungere testo nel listbox
        private void Log(string testo)
        {
            lstLog.Items.Add(testo);
        }

        //fondamentale zio cane
        private void GestisciCella(int r, int c)
        {
            // sto posizionando le navi altrimennti gioco
            if (naveCorrente < flotta.Count)
            {
                PosizionaNave(r, c);
            }
            else
            {
                GiocaTurno(r, c);
            }
        }




        private void PosizionaNave(int r, int c)
        {
            // controllo libera, quindi chiudo
            if (campo[r, c] == 1)
            {
                Log("Cella già occupata!");
                return;
            }

            // aggiungo, MA NON PER SEMPRE
            bottoni[r, c].BackColor = Color.DarkBlue;
            posTemp.Add((r, c));

            int lung = flotta[naveCorrente].Lunghezza; // vedo quanto deve essere lunga

            // celle non sufficienti → fermo
            if (posTemp.Count < lung)
                return;

            // check valida
            bool stessaRiga = true;
            bool stessaCol = true;

            for (int i = 1; i < posTemp.Count; i++)
            {
                //non è sulla stessa riga
                if (posTemp[i].r != posTemp[0].r)
                    stessaRiga = false;
                //non è sulla stessa col
                if (posTemp[i].c != posTemp[0].c)
                    stessaCol = false;
            }

            if (!stessaRiga && !stessaCol) //entrambe false
            {
                Log("Le celle devono essere tutte in linea retta!");
                ResetPosTemp(); //pulisco
                return;
            }

            // check consecutive
            if (stessaRiga)
            {
                var colonne = posTemp.Select(p => p.c).OrderBy(x => x).ToList(); //ordino le colonne ex 0,2,1 → 0,1,2
                for (int i = 1; i < colonne.Count; i++) //controlla se è consecutivo
                {
                    if (colonne[i] != colonne[i - 1] + 1)
                    {
                        Log("Le celle devono essere attaccate!");
                        ResetPosTemp();
                        return;
                    }
                }
            }
            else if (stessaCol)
            {
                var righe = posTemp.Select(p => p.r).OrderBy(x => x).ToList();
                for (int i = 1; i < righe.Count; i++)
                {
                    if (righe[i] != righe[i - 1] + 1)
                    {
                        Log("Le celle devono essere attaccate!");
                        ResetPosTemp();
                        return;
                    }
                }
            }

            // nave valida, salvo

            foreach (var pos in posTemp)
            {
                campo[pos.r, pos.c] = 1;
                flotta[naveCorrente].Celle.Add(pos);
            }

            Log($"Nave da {lung} celle posizionata.");
            naveCorrente++;
            posTemp.Clear();

            if (naveCorrente < flotta.Count)
                Log($"Posiziona la nave da {flotta[naveCorrente].Lunghezza} celle.");
            else {
                Log("Tutte le navi posizionate! Inizia il gioco.");
                ResetGridColors();
            }
            
        }

        // nel casso cella non valida
        private void ResetPosTemp()
        {
            foreach (var p in posTemp)
                bottoni[p.r, p.c].BackColor = Color.FromArgb(0, 192, 192);

            posTemp.Clear();
        }

        // reset griglia dei colori
        private void ResetGridColors()
        {
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    bottoni[r, c].BackColor = Color.FromArgb(0, 192, 192);
                }
            }
        }



        // GIOCO______ EFFEFTTIVO //

        private void GiocaTurno(int r, int c)
        {
            // cella già colpiti asa stare
            if (bottoni[r, c].BackColor == Color.Red || bottoni[r, c].BackColor == Color.Blue)
                return;

            // mosse++
            mosse++;
            lblMosse.Text = mosse.ToString();

            // fase della cella colpita
            if (campo[r, c] == 1)
            {
                campo[r, c] = 2; // segno come colpita
                bottoni[r, c].BackColor = Color.Red;

                Log($"Colpito in posizione ({r},{c})");
                //ho dovuto fare così perchè i due file wav me li prendeva come array di byte invece di file Stream
                byte[] soundData = Properties.Resources.falling_rock;
                MemoryStream ms = new MemoryStream(soundData);
                SoundPlayer sp = new SoundPlayer(ms);
                sp.Play();

                // controllo se una nave è affondata
                foreach (var nave in flotta)
                {
                    // affondata == true → salto
                    if (nave.Affondata)
                        continue;

                    bool affondata = true; // IPOTIZZO sia stata affondata

                    foreach (var cella in nave.Celle)
                    {
                        if (campo[cella.r, cella.c] != 2)
                        {
                            affondata = false;
                            break;
                        }
                    }

                    if (affondata)
                    {
                        nave.Affondata = true;  // altrimenti mi si sminchai tutto e conta più volte
                        naviNonAffondate--;
                        lblNavi.Text = naviNonAffondate.ToString();
                        Log("Nave affondata!");

                        //vittoria
                        if (naviNonAffondate == 0)
                        {
                            MessageBox.Show($"Hai vinto! Hai impiegato {mosse} mosse!",
                                            "Vittoria!",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            partitaFinita = true;   // non chiudo qui ma dopo, altrimenti crsasha
                        }

                        break;
                    }
                }

            }
            else
            {
                // robo dell'acqua
                bottoni[r, c].BackColor = Color.Blue;
                Log($"Acqua!! ({r},{c})");
                //ho dovuto fare così perchè i due file wav me li prendeva come array di byte invece di file Stream
                byte[] soundData = Properties.Resources.water_splash;
                MemoryStream ms = new MemoryStream(soundData);
                SoundPlayer sp = new SoundPlayer(ms);
                sp.Play();
            }

            //fine game
            if (partitaFinita)
            {
                this.Close();
                return;
            }
        }


    }
}
