using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MethodClassAssignmentSubmission
    {
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method of the console app, instantiate the class.
            Mathop mathOperation = new Mathop();
            //Call the method in the class, passing in two numbers.
            mathOperation.Add(5, 10);
            //Call the method in the class, specifying the parameters by name.
            mathOperation.Add(a: 20, b: 30);
        }
    }
}