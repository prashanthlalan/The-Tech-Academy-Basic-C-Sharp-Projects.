using System;

namespace OperatorsAssignmentSubmission
{
    //Create an Employee class with Id, FirstName and LastName properties. 
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // In the Employee class, overload the “==” operator
        // so it checks if two Employee objects are equal by comparing their Id property.
        // Remember that comparison operators must be overloaded in pairs.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both are null
            if (ReferenceEquals(emp1, emp2)) return true;
            // Check if one is null
            if (emp1 is null || emp2 is null) return false;
            // Compare Ids
            return emp1.Id == emp2.Id;
        }
        // Overload the “!=” operator to check if two Employee objects are not equal.
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Use the == operator to determine inequality
            return !(emp1 == emp2);
        }
    }
}
        