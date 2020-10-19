using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace YearValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your year of birth?");
            string userInput = Console.ReadLine();

            if (Validate(userInput))
            {

            }

                

        }
       public static bool Validate(string yearInput)
        {
            if(yearInput.Length == 4)
            {
                try 
                {
                    Int32.Parse(yearInput);
                    return true;
                    
                }catch(Exception error)
                {
                    Console.WriteLine(error);
                    return false;

                }

            }else
            {
                Console.WriteLine("wrong format");
                return false;

            }
        } 
        public static void CalculateAge(string yearInput)
        {
            int year = Int32.Parse(yearInput);

            DateTime now = DateTime.Now;
            string currentYear = now.Year.ToString();
            int yearNow = Int32.Parse(currentYear);
            int age = yearNow - year;
            Console.WriteLine($"You are {age} years old.");
        }
    }
}
