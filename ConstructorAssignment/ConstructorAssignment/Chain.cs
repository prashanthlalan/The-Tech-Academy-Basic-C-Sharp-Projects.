using System;

namespace ConstructorAssignment.Chain
{
    public class Chain
    {
        //Constructor if one parameter, a float, is provided.
        public Chain(float num1) : this(num1, "Prashanth")
        {
            Console.WriteLine(num1 + " and your default name is " + Name);
        }
        //Constructor if one parameter, a string, is provided.
        public Chain(string name1) : this(39, name1)
        {
            Console.WriteLine(name1 + " and your default age is " + Num);
        }
        // Constructor if both parameters, a float and a string, are provided.
        public Chain(float num, string name)
        {
            Num = num;
            Name = name;
        }
        string Name { get; set; }
        float Num { get; set; }
    }
}
