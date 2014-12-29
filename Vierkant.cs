using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitConsole
{
    class Vierkant:Figuur
    {
        public int Zijde { get; private set; }
        public Vierkant(int zijde)
        {
            this.Zijde = zijde;
        }

        public override double Omtrek
        {
            get { return 4 * Zijde; }
        }

        public override double Oppervlakte
        {
            get { return Zijde * Zijde; }
        }
    }
}
