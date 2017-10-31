using FakturaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakturaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fakturaSystem = new FakturaSystem();
            Part enPerson = fakturaSystem.SkapaPart("John Smith", "800101-1234");
            var beställning = fakturaSystem.SkapaBeställning(enPerson);
            var teddy = fakturaSystem.SkapaProdukt("Fredriksson", 79M);
            var ponny = fakturaSystem.SkapaProdukt("Miniponny", 15000M);
            try
            {
                beställning.nyRad(teddy, 3);
                beställning.nyRad(ponny, 1);
                Console.WriteLine($"Beställningen är värd {beställning.Total}");
                var faktura = beställning.GenereraFaktura();
                Console.WriteLine(faktura);
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("Hoppsan! Försök igen lite senare.");
            }
        }
    }
}
