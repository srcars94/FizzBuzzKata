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
            if (value % 3 == 0 && value % 5 == 0) return "FizzBuzz";

            if (value % 3 == 0) return "Fizz";

            if (value % 5 == 0) return "Buzz";

            return value.ToString();
        }
    }
}
