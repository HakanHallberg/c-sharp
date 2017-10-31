using System;
using System.Collections.Generic;
using System.Text;

namespace FakturaLib
{
    public class Faktura
    {
        public Faktura(Part kund, decimal total)
        {
            this._kund = kund;
            this._total = total;
        }

        private Part _kund;
        private decimal _total;
        public override string ToString()
        {
            return $"{_kund.Namn} ska betala {_total} SEK";
        }


    }
}
