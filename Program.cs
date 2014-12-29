using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dag allemaal");
            Console.Write("Geef de zijde van het vierkant:");
            int zijde = Int32.Parse(Console.ReadLine());
            Vierkant v = new Vierkant(zijde);
            Console.WriteLine("De omtrek van het vierkant is {0:d}", v.Omtrek  );
            Console.WriteLine("De oppervlakte van het vierkant is {0:d}", v.Oppervlakte);

        }
    }
}
