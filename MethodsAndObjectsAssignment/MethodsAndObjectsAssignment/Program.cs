using System;

namespace MethodsAndObjectsAssignment
{
    // Create a class called Person and give it two properties,
    // each of data type string. One called FirstName, the other LastName.
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Give this class a void method called SayName() that takes no parameters
        // and simply writes the person's full name to the console in the format of: “Name: [full name]”.
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    // Create another class called Employee and have it inherit from the Person class.
    // Give the Employee class a property called Id and have it be of data type int.
    public class Employee : Person
    {
        public int Id { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Inside of the Main method, instantiate and initialize an Employee object with
            // a first name of “Sample”and a last name of “Student”.
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Call the superclass method SayName() on the Employee object
            employee.SayName();
        }
    }
}