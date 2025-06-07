using System;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // print welcome message "Welcome to Package Express. Please follow the instructions below."
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //ask the package weight
            Console.WriteLine("Please enter the package weight:");
            int Weight = Convert.ToInt32(Console.ReadLine());
            // If the weight is greater than 50, display the error message,
            // “Package too heavy to be shipped via Package Express. Have a good day.”
            if (Weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // terminate the program
            }
            //ask the package width
            Console.WriteLine("Please enter the package width:");
            int Width = Convert.ToInt32(Console.ReadLine());
            //ask the package height
            Console.WriteLine("Please enter the package height:");
            int Height = Convert.ToInt32(Console.ReadLine());
            //ask the package length
            Console.WriteLine("Please enter the package length:");
            int Length = Convert.ToInt32(Console.ReadLine());
            // If the dimensions total is greater than 50,display the error message,
            // “Package too big to be shipped via Package Express.” 
            if (Width + Height + Length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // terminate the program
            }
            // multiply the three dimensions (height, width, & length) together
            // and multiply the product by the weight. Finally, divide the outcome by 100.
            Console.WriteLine("Your estimated total for shipping this package is: $" +
                              ((Width * Height * Length * Weight) / 100));
            // Thank you message
            Console.WriteLine("Thank you!");
        }
    }
}