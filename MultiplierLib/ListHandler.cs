using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
    public class ListHandler
    {
        public List<string> List = new List<string>();

        public void AddFiveStrings()
        {

           for (int i = 0; i < 5; i++)
            {
                List.Add(" ");
            }
        }

        public void RemoveThirdString()
        {
            List.RemoveAt(2);
        }

        public void Sort()
        {
            List.Sort();
        }
    }
}