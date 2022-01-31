using System;

namespace FizzBuzzKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            //GetValue();
        }

        public static string GetValue(int value)
        {
            if (value % 3 == 0) return "Fizz";

            return value.ToString();
        }
    }
}
