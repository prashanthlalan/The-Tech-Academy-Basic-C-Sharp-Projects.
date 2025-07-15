using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignmentSubmission
{
    class Mathop
    {
        //Create a class. In that class, create a void method that takes two integers as parameters.
        public void Add(int a, int b)
        {
            //Have the method do a math operation on the first integer
            //and display the second integer to the screen.
            int result = a + b;
            Console.WriteLine("The sum of {0} and {1} is: {2}", a, b, result);
        }
    }
}
