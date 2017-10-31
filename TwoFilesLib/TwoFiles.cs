using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoFilesLib
{
    public class TwoFiles
    {
        public static string Transform(string input1, string input2)
        {
            var stringReader1 = new StringReader(input1);
            string output = "";
            while (true)
            {
                var line1 = stringReader1.ReadLine();
                if (line1 == null)
                    break;
                var innerReader = new StringReader(input2);
                while(true)
                {
                    var line2 = innerReader.ReadLine();
                    if (line2 == null)
                        break;
                    var d = decimal.Parse(line1, CultureInfo.InvariantCulture);
                    var q = int.Parse(line2);
                    var result = (d * q).ToString(CultureInfo.InvariantCulture);
                    output += $"{line1}x{line2}={result}\n";
                }
            }
            return output;
        }
    }
}
