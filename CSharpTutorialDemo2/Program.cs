using System;

namespace CSharpTutorialDemo2
{
    internal class Program
    {
        public static void Main(string[] args)
        {


            int a = 1;

            while (a <= 100)
            {


            }


        }

        private static void NewMethod2()
        {
            int a = 17;
            switch (a)
            {
                case 0:
                    Console.WriteLine("a is 0");
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("1-5");
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("6-10");
                    break;
                case 11:
                case 12:
                    Console.WriteLine("11-12");
                    break;
                case 13:
                case 14:
                case 15:
                    Console.WriteLine("13-15");
                    break;
                default:
                    Console.WriteLine("l dont know");
                    break;
            }
        }

        private static void NewMethod1()
        {
            int a = 15;
            switch (a)
            {
                case 10:
                    Console.WriteLine("a is 10");
                    break;
                case 14:
                    Console.WriteLine("a is 14");
                    break;
                case 15:
                    Console.WriteLine("a is 15");
                    break;
                default:
                    Console.WriteLine("l dont know");
                    break;
            }
        }

        private static void NewMethod()
        {
            int a = 15;
            int b = 15;

            Console.WriteLine(a > b ? "A" : a == b ? "AB" : "B");
        }

        private static void BoolControl()
        {
            bool isTrue = true;
            bool isFalse = 2 > 5;

            Console.WriteLine(isTrue);
            Console.WriteLine(isFalse);
        }

        private static void ElseIfStatement(int a, int b)
        {
            if (b > a)
            {
                Console.WriteLine("if statement");
            }
            else if (b > 8)
            {
                Console.WriteLine("else if statement");
            }
            else
            {
                Console.WriteLine("else statement");
            }
        }
    }
}