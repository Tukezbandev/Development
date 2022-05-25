using System;

namespace CSharpTutorialDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {


                string firstName = "Aytac" ; 
                string lastName = "Abbasova" ; 
                int number = 15 ; 
                string message = $"{firstName} {lastName}  {number.ToString()}" ;

                Console.WriteLine(message.IndexOf("c"));


        }



        public static void LastExamples()
        {
            Console.WriteLine("Yasinizi daxil edin");
            var age = Convert.ToInt32(Console.ReadLine()); //string 18
            var intAge = Convert.ToInt32(age); //int 18
            age = age + 1; //string 181
            if (intAge + 1 != Convert.ToInt32(age))
            {
                Console.WriteLine($"intAge: {intAge} age: {age}");
            }
            else
            {
                Console.WriteLine("Beraberdirler");
            }

        }


    }


}