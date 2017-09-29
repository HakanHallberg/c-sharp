using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCount
{
     public class Program
    {
        static void Main(string[] args)
        {
            var aSchool = new School("Säve");
            var aClass1 = new  Class(28);
            var aClass2 = new Class(28);
            var aClass3 = new Class(28);
            aSchool.Classes.Add(aClass1);
            aSchool.Classes.Add(aClass2);
            aSchool.Classes.Add(aClass3);
            Console.WriteLine($"There are {aSchool.NumberOfStudents} number of students in this school.");
            Console.ReadLine();
        }
    }
}
