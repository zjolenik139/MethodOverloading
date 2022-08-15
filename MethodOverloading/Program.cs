using System;

namespace MethodOverloading
{
    internal class Program
    {

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal dec1, decimal dec2)
        {
            return dec1 + dec2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = 0;
            var response = "";

            if (isTrue)
            {
                sum = num1 + num2;

                if(sum == 1)
                {
                    response = $"{sum} dollar";
                }
                else
                {
                    response = $"{sum} dollars";
                }
            }

            return response;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 6, true));

            Console.WriteLine(Add(0, 1, true));

            Console.WriteLine(Add(-5, 3, true));
        }
    }
}
