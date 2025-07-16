using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class
            MathOperations operations = new MathOperations();

            // Handling user input
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            // Displaying division results
            operations.DivideByTwo(number);

            // Calling first overload method
            operations.DisplayResult(number);

            // Implementing method with output parameters
            operations.DisplayResult(number, out int result);
            Console.WriteLine("Output parameter result: " + result);

            // Using static class
            StaticMathOperations.HalfValue(number, out int staticResult);
            Console.WriteLine("Static class result: " + staticResult);
        }
    }
}