using System;
using System.Net.NetworkInformation;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints the current date and time to the console.
            Console.WriteLine("Current Date and Time: " + DateTime.Now);
            // Asks the user for a number.
            Console.Write("Enter a number: ");
            // Reads the user input and converts it to an integer.
            int number;
            // Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            if (int.TryParse(Console.ReadLine(), out number))
            {
                DateTime futureTime = DateTime.Now.AddHours(number);
                Console.WriteLine("The time in " + number + " " + "hours will be: " + futureTime);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid whole number.");
            }


        }
    }
}