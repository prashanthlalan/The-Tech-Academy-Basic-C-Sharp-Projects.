using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiate MathMethods2 class
            MathMethods2 mathMethods = new MathMethods2();
            // Call the first method with an integer parameter
            Console.WriteLine(mathMethods.MathOp(5));
            // Call the second method with a decimal parameter
            Console.WriteLine(mathMethods.MathOp(4m));
            // Call the third method with a string
            Console.WriteLine(mathMethods.MathOp("4"));
        }
    }
}