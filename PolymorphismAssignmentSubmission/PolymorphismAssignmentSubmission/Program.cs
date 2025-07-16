using System;

namespace PolymorphismAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            IQuittable employee = new Employee
            {
                FirstName = "Prashanth",
                LastName = "Lalan",
            };
            employee.Quit();
        }
    }
}