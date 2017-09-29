using System;

namespace OOPConsolApp
{
    internal class Lion : Animal
    {

       internal override void Eat()
        {
            base.Eat();
            Console.WriteLine("Hunting prey.");
        }
    }
}