using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var aHouse = new House();
            var aRoom1 = new Room();
            var aRoom2 = new Room();
            Window window1 = new Window();
            Window window2 = new Window();
            Window window3 = new Window();
            Window window4 = new Window();
            aRoom1.AddWindow(window1);
            aRoom1.AddWindow(window2);
            aRoom2.AddWindow(window3);
            aRoom2.AddWindow(window4);
            aHouse.AddRoom(aRoom1);
            aHouse.AddRoom(aRoom2);
            window1.Open();
            Console.WriteLine(aHouse.NumberOfClosedWindows + " windows are still closed.");
            Console.ReadLine();
        }
    }
}
