using System;

namespace ConstructorAssignment.Chain
{
    class program
    {
        static void Main(string[] args)
        {
            // Create a const Variable
            const string const1 = "Your Name is";
            const string const2 = "Your age number is ";
            Console.WriteLine("Enter your name or age: ");
            // Create a variable using the var keyword
            var answer = Console.ReadLine();
            if (float.TryParse(answer, out float x))
            {
                Console.WriteLine(const2);
                Chain chain1 = new Chain(x);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(const1);
                Chain chain2 = new Chain(answer);
                Console.ReadLine();
            }
        }
    }
}