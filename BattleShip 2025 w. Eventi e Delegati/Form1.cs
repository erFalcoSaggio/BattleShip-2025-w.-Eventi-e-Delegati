namespace BattleShip_2025_w._Eventi_e_Delegati
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_SinglePlayer_Click(object sender, EventArgs e)
        {
            SinglePlayer sp = new SinglePlayer();
            sp.ShowDialog();
        }
    }
}