using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_EncapsulationOrnekk
{
    class Program
    {
        static void Main(string[] args)
        {
            Daire daire1 = new Daire(3);
            daire1.Yaricap = 5;
            Console.WriteLine("Çap: " +daire1 .Cap .ToString ());
            daire1.AlanHesapla();
            daire1.CevreHesapla();

            Console.ReadKey();
        }
    }
}
