using System;
using System.Linq;

namespace HomeTasks
{
    public class Program
    {
        public static void Main(string[] args) { }

        private static void NewMethod2()
        {
            int[] numbers = { 1, 45, 23, 78, 59 };
            // Console.WriteLine(numbers.Max());
            // Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());
        }

        private static void NewMethod1()
        {
            string[] students = { "Tukezban", "Aytac" };
            string[] students2 = new string[3] { "Aytac", "Tukezban", "Aysel" };

            Console.WriteLine(students[0]);
        }

        private static void NewMethod()
        {
            if (IsPrimeNumber(9817))
            {
                Console.WriteLine("Sade eded");
            }
            else
            {
                Console.WriteLine("Murekkeb");
            }
        }

        private static bool IsPrimeNumber(int paramsNumber)
        {
            bool IsPrime = true;

            for (int i = 2; i < paramsNumber; i++)
            {
                if (paramsNumber % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }

            return IsPrime;
        }

        private static void WhileLoop2()
        {
            int number = 1;
            while (number <= 100)
            {
                if (number <= 20 && number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
                else if (number > 20 && number <= 40 && number % 5 == 0)
                {
                    Console.WriteLine(number);
                }
                else if (number > 40 && number <= 60 && number % 6 == 0)
                {
                    Console.WriteLine(number);
                }
                else if (number > 60 && number <= 90)
                {
                    Console.WriteLine(number);
                }
                else if (number == 95 || number == 97)
                {
                    Console.WriteLine(number);
                }

                number++;
            }
        }

        private static void WhileLoop()
        {
            int number = 1;
            while (number <= 100)
            {
                if (number <= 50 && number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
                else if (number > 50 && number % 2 != 0)
                {
                    Console.WriteLine(number);
                }

                number++;
            }
        }
    }
}
