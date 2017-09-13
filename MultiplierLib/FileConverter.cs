/*using System;
using System.Text;

namespace MultiplierLib
{
    public class FileConverter
    {
        public string Transform(string row)
        {
            string[] tokens = row.Split(';');
            var firstName = tokens[0].ToUpper();
            var lastName = tokens[1].ToUpper();
            var years = DateTime.Now.Year - int.Parse(tokens[2]);
            var message = $"{firstName} {lastName} ÄR {years} ÅR GAMMAL!";
            return message;
        }
        public void TransformFile(string InputName, string OutputName)
        {
            StreamWriter sw = new StreamWriter(File.Create(OutputName),
                Encoding.GetEncoding("iso-8859-1"));
            string[] lines = File.ReadAllLines(InputName);
            foreach (var line in lines)
            {
                sw.WriteLine(Transform(line));

            }
            sw.Close();
            File.WriteAllText(OutputName, sw.ToString());
        }
    }
}*/
