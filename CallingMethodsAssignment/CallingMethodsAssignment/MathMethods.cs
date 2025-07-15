using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class MathMethods
    {
        //In that class, create three methods, each of which will take one integer parameter in and return an integer.
        //The methods should do some math operation on the received parameter.
        public int convertm(int km)
        {
            int metres = km * 1000;
            return metres;
        }
        public int convertcm(int km)
        {
            int centimetres = km * 100000;
            return centimetres;
        }
        public int convertmm(int km)
        {
            int millimetres = km * 1000000;
            return millimetres;
        }

    }
}
