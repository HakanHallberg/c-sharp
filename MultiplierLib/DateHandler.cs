using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
    public class DateHandler
    {
        public int DaysBetweenDates(DateTime firstDate, DateTime secondDate)
        {
            int numberOfDays = Convert.ToInt32((secondDate - firstDate).TotalDays);
            return numberOfDays;
        }

        public DateTime Add1000Days(DateTime theDate)
        {
            DateTime myDate = theDate.AddDays(1000);
            return myDate;
        }
    }
}
