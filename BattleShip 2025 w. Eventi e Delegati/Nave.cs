using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_2025_w._Eventi_e_Delegati
{
    public class Nave
    {
        public int Lunghezza { get; private set; }
        public bool Affondata = false;
        public List<(int r, int c)> Celle { get; private set; } = new List<(int, int)>();

        public Nave(int lunghezza)
        {
            Lunghezza = lunghezza;
        }
    }

}
