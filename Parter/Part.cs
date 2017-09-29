using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parts
{
    public class Part
    {
        public Part(string name, string id)
        {
            this.Name = name;
            this.ID = id;
        }

        public string Name { get; set; }
        public string ID { get; set; }

        public override string ToString()
        {
            return $"{Name} ({ID})";
        }





    }

}
