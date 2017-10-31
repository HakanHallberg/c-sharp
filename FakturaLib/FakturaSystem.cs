using System;
using FakturaLib;

namespace FakturaApp
{
    public class FakturaSystem
    {
            public Part SkapaPart(string Namn, string JuridiskId)
            {
                var enPerson = new Part 
                {
                    Namn = namn,
                    JuridiskId = juridiskId
                };
                return enPerson;
            }
            public Beställning SkapaBeställning(Part enPerson)
            {
                return new Beställning(enPerson);
            }
        }
    }
}