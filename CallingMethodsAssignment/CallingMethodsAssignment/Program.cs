using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Please enter the value in Killometre:");
            //Convert the input to meters using parameters and return the result.
            int km = Convert.ToInt32(Console.ReadLine());
            MathMethods mathMethods = new MathMethods();
            int metres = mathMethods.convertm(km);
            Console.WriteLine("The value in Metres is: " + metres);

            //Convert the input to centimeters using parameters and return the result.
            int centimetres = mathMethods.convertcm(km);
            Console.WriteLine("The value in Centimetres is: " + centimetres);

            //Convert the input to millimeters using parameters and return the result.
            int millimetres = mathMethods.convertmm(km);
            Console.WriteLine("The value in Millimetres is: " + millimetres);

            Console.ReadLine();



        }
    }
}