using System;

namespace FizzBuzzLib
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            if (input % 3 == 0)
            {
                return "Fizz";
            }
            if (input % 5 == 0)
            {
                return "Buzz";
            }
            return input.ToString();
        }
    }
}
