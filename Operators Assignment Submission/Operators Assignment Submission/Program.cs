using System;

namespace OperatorsAssignmentSubmission
{
    class Program
    {
        //In the "Program.cs" file, instantiate two objects of the Employee class and assign values to their properties.
        //Then compare the two Employee objects using the newly overloaded operators and display the results.
        static void Main(string[] args)
        {
            Employee emp1 = new Employee { Id = 1, FirstName = "Prashanth", LastName = "Lalan" };
            Employee emp2 = new Employee { Id = 2, FirstName = "Robert", LastName = "De Niro" };
            // Compare emp1 and emp2 when they are equal
            Console.WriteLine($"Are emp1 and emp2 equal? {emp1 == emp2}");
            // compare emp1 and emp2 when they are not equal
            Console.WriteLine($"Are emp1 and emp2 not equal? {emp1 != emp2}");
        }
    }
}