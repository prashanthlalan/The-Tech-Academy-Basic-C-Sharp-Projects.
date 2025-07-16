using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class MathMethods2
    {
        //First method that will take in an integer
        public int MathOp(int num)
        {
            return num + 10;
        }
        //Second method that will take in a decimal
        public decimal MathOp(decimal num)
        {
            //Convert the decimal to an integer, multiply by 100, and return as a decimal
            int newnum =Convert.ToInt32(num);
            return newnum * 100;
        }
        //Third method that will take in a string
        public int MathOp(string num)
        {
            //Convert the string to an integer, multiply by 200 to perform the operation, and return as an integer
            int newnum = Convert.ToInt32(num);
            return (newnum * 200);
        }

    }
}
