using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    // Declaring a static class
    public static class StaticMathOperations
    {
        public static void HalfValue(int input, out int result)
        {
            // Method with output parameter
            result = input / 2;
        }
    }

    // Creating a class with required methods
    public class MathOperations
    {
        // Void method that divides input by 2 and outputs result
        public void DivideByTwo(int number)
        {
            Console.WriteLine("Division result: " + (number / 2));
        }

        // First version of overloaded method
        public void DisplayResult(int num)
        {
            Console.WriteLine("Your number is: " + num);
        }

        // Overloaded method with output parameter
        public void DisplayResult(int num, out int divided)
        {
            divided = num / 2;
        }
    }
}