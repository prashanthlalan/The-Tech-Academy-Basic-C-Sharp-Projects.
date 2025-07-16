using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Create another class called Employee and have it inherit from the Person class.
    public class Employee : Person
    {
        //Give the Employee class a property called Id and override the SayName() method.
        public int Id { get; set; }
        //Implement the SayName() method inside of the Employee class.
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
