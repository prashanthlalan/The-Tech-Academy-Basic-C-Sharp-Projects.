using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class MathOperation
    {
        //Create a method that takes two integers as parameters.
        //Make one of them optional.
        public int MathOp(int a, int b = 10)
        {
            //Have the method do a math operation and return an integer result.
            return a * b;
        }

    }
}
