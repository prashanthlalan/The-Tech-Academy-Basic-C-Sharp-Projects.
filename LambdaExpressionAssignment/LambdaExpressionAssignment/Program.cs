using System;
using System.Collections.Generic;

namespace LambdaExpressionAssignment
{
    //In the Main() method, create a list of at least 10 employees.At least two employees should have the first name “Joe”.
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Alice", LastName = "Brown" },
                new Employee { Id = 5, FirstName = "Bob", LastName = "Davis" },
                new Employee { Id = 6, FirstName = "Charlie", LastName = "Wilson" },
                new Employee { Id = 7, FirstName = "David", LastName = "Garcia" },
                new Employee { Id = 8, FirstName = "Eve", LastName = "Martinez" },
                new Employee { Id = 9, FirstName = "Frank", LastName = "Lopez" },
                new Employee { Id = 10, FirstName = "Grace", LastName = "Hernandez" }
            };
            //Using a foreach loop, create a new list of all employees with the first name “Joe”.
            //In your comparison statement, remember to reference the property of the object you are checking.
            List<Employee> joes = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }
            //Perform the same action again, but this time with a lambda expression.
            List<Employee> joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();
            // Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> IdGreaterThan5 = employees.Where(e => e.Id > 5).ToList();
            // Output the results to the console.
            Console.WriteLine("Employees named Joe (foreach loop):");
            foreach (var joe in joes)
            {
                Console.WriteLine("ID: " + joe.Id + " | " + "Name: " + joe.FirstName + " " + joe.LastName);
            }

            Console.WriteLine("\nEmployees named Joe (lambda expression):");
            foreach (var joe in joesLambda)
            {
                Console.WriteLine("ID: " + joe.Id + " | " + "Name: " + joe.FirstName + " " + joe.LastName);
            }

            Console.WriteLine("\nEmployees with ID > 5:");
            foreach (var emp in IdGreaterThan5)
            {
                Console.WriteLine("ID: " + emp.Id + " | " + "Name: " + emp.FirstName + " " + emp.LastName);
            }

            Console.ReadLine();
        }
    }
}