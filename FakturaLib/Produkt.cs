using System;
using System.Collections.Generic;
using System.Text;

namespace FakturaLib
{
    public class Produkt
    {
        public Produkt(string namn, decimal pris)
        {
            if (pris < 0)
                throw new InvalidOperationException("Pris måste vara större än noll!");
            this.Namn = namn;
            this.Pris = pris;
        }


        public string Namn { get; private set; }
        public decimal Pris { get; private set; }
        public override string ToString()
        {
            return this.Namn;
        }
    }
     
}
