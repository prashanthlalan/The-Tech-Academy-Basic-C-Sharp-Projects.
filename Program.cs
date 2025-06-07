using System;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask the user for their age
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            //ask the user if they have ever had a DUI
            Console.WriteLine("Have you ever had a DUI?");
            string hasDUI = Console.ReadLine();
            //ask the user how many speeding tickets they have
            Console.WriteLine("How many speeding tickets do you have?");
            string speedingTickets = Console.ReadLine();
            // check if the user is qualified for insurance
            if (Convert.ToInt32(age) >= 15 && hasDUI == "false" && Convert.ToInt32(speedingTickets) <= 3)
            {
                Console.WriteLine("Qualified?");
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("Qualified?");
                Console.WriteLine("false");
            }
        }
    }
}