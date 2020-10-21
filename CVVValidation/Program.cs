using System;
using System.Transactions;

namespace CVVValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your card cvv code:");
            string userInput = Console.ReadLine();
            if (ValidateCVV(userInput))
            {
                Console.WriteLine("Welcome!");
            } else
            {
                Console.WriteLine("Failed. Try again!");
            }
            
            
        }

        public static bool ValidateCVV(string cvvCode)
        {
            if (cvvCode.Length == 3)
            {
                try
                {
                    Int32.Parse(cvvCode);
                    return true;
                }
                catch(Exception error)
                {
                    Console.WriteLine("Failed to parse.");
                    return false;
                }
            } 
            else
            {
                return false;
            }
        }

    }
}
