using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to input two numbers, one at a time.
            //Let them know they need not enter anything for the second number.
            Console.WriteLine("Please enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number (optional, press Enter to skip):");
            try
            {
                //Call the method in the class, if both parameters are given.
                int secondnumber = Convert.ToInt32(Console.ReadLine());
                int result = new MathOperation().MathOp(firstNumber, secondnumber);
                Console.WriteLine(firstNumber + " x " + secondnumber + " = " + result);

            }
            catch
            {
                //Call the method in the class, if only one parameter is given.
                int result = new MathOperation().MathOp(firstNumber);
                Console.WriteLine(firstNumber + " x 10 = " + result);
            }
            Console.ReadLine();     
        }
    }
}