using System;

namespace ParsingEnumsAssignment
{
    class Program
    {
        //Create an enum for the days of the week.
        enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        // Prompt the user to enter the current day of the week.
        // Parse the input to the enum type.
        // If the input is not valid, prompt the user to enter a valid day of the week.
        // Display the day of the week.
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week (e.g., Monday):");
            string userInput = Console.ReadLine();
            // Assign the value to a variable of that enum data type you just created.
            DaysOfWeek dayOfWeek;
            // Wrap the above statement in a try/catch block and have it print
            // "Please enter an actual day of the week.” to the console if an error occurs.
            try
            {
                // Attempt to parse the user input to the enum type
                dayOfWeek = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);
                Console.WriteLine("You entered: " + dayOfWeek);
            }
            catch (ArgumentException)
            {
                // If parsing fails, prompt the user to enter a valid day of the week
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }

    }
}