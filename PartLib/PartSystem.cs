using System;
using System.Collections.Generic;
using System.Text;

namespace PartLib
{
    public class PartSystem
    {
        private List<Part> Parts = new List<Part>();
        private List<Accountability> Accountabilities = new List<Accountability>();
        public void AddPart(Part part)
        {
            Parts.Add(part);
        }
        public void AddPart(Accountability accountability)
        {
            Accountabilities.Add(accountability);
        }
    }

}
