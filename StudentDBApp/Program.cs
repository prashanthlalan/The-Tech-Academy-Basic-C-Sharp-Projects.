using System;
using StudentDBApp;

class Program
{
    static void Main()
    {
        using (var context = new DbConnection())
        {
            // Create database if not exists
            context.Database.EnsureCreated();

            // Add new student
            var student = new Student
            {
                FirstName = "John",
                LastName = "Doe"
            };

            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added successfully!");
            Console.WriteLine($"Student ID: {student.StudentId}");
            Console.WriteLine($"Enrollment Date: {student.EnrollmentDate}");
        }
    }
}