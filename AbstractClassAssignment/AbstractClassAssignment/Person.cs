﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{

    //Create an abstract class called Person with two properties:
    //string firstName and string lastName.
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Give it the method SayName().
        public abstract void SayName();
    }
}
