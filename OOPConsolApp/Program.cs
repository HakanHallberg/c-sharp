using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //kan raderas då de inte används

namespace OOPConsolApp
{
    class Program //intern klass. Nås bara i själva projektet
    {
        static void Main(string[] args)
        {
            // StudentDemo();
            InheritanceDemo();
            Console.ReadLine();
        }

        private static void InheritanceDemo()
        {
            Animal anAnimal = new Animal();
            anAnimal.Eat();
            Lion aLion = new Lion();
            aLion.Eat();
        }

        

        private static void StudentDemo()
        {
            var håkan = new Student();
            håkan.Name = "Håkan Hallberg";
            håkan.Email = "hallberg.hakan@icloud.com";
            håkan.TooTired += Håkan_TooTired;
            håkan.StudyHarder();
            håkan.StudyHarder();
            håkan.StudyHarder();
            Console.WriteLine($"Hello world to {håkan}"); //ctrl F5 för att få "press any key to continue"
            Console.ReadLine(); //ser till att man "hinner" läsa ovan rad utan ctrl F5
        }

        private static void Håkan_TooTired(object sender, EventArgs e) //det här är en call back metod
        {
            Console.WriteLine("Student needs to rest");
        }
    }
}
