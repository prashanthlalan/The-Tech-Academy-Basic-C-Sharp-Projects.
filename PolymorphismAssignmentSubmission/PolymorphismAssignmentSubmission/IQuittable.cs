using System;

namespace PolymorphismAssignmentSubmission
{
    // Creating IQuittable interface with Quit() method
    public interface IQuittable
    {
        void Quit();
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    // Employee class inheriting from Person and implementing IQuittable
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        // Implementing Quit() method from IQuittable interface
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has quit the company.");
        }
    }
}