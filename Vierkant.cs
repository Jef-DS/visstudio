using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitConsole
{
    class Vierkant
    {
        public int Zijde { get; private set; }
        public Vierkant(int zijde)
        {
            this.Zijde = zijde;
        }
        public int Omtrek
        {
            get { return 4 * Zijde; }
        }
    }
}
