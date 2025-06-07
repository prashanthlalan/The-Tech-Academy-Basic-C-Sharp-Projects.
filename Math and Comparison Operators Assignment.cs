using System;

class SampleApplication
{
    static void Main()
    {
        //printing a welcome message "Anonymous Income Comparison Program"
        Console.WriteLine("Anonymous Income Comparison Program");
        //printing a message "Person 1"
        Console.WriteLine("Person 1");
        //asking for hourly rate for Person 1 and storing it in a variable rateperHour1
        Console.WriteLine("Hourly Rate?");
        string rateperHour1 = Console.ReadLine();
        //asking for hours worked per week for Person 1 and storing it in a variable hoursWorked1
        Console.WriteLine("Hours worked per week?");
        string hoursWorked1 = Console.ReadLine();
        //printing a message "Person 2"
        Console.WriteLine("Person 2");
        //asking for hourly rate for Person 2 and storing it in a variable rateperHour2
        Console.WriteLine("Hourly Rate?");
        string rateperHour2 = Console.ReadLine();
        //asking for hours worked per week for Person 2 and storing it in a variable hoursWorked2
        Console.WriteLine("Hours worked per week?");
        //reading the input for hours worked per week for Person 2
        string hoursWorked2 = Console.ReadLine();
        //calculating annual salary for Person 1 and storing it in a variable annualSalary1
        int annualSalary1 = Convert.ToInt32(rateperHour1) * Convert.ToInt32(hoursWorked1) * 52;
        Console.WriteLine("Annual salary of Person 1:");
        //printing a message "Annual salary of Person 1:"
        Console.WriteLine(annualSalary1);
        //calculating annual salary for Person 2 and storing it in a variable annualSalary2
        int annualSalary2 = Convert.ToInt32(rateperHour2) * Convert.ToInt32(hoursWorked2) * 52;
        //printing a message "Annual salary of Person 2:"
        Console.WriteLine("Annual salary of Person 2:");
        //printing the annual salary of Person 2
        Console.WriteLine(annualSalary2);
        //printing a message "Does Person 1 make more money than Person 2?"
        Console.WriteLine("Person 1 makes more money than Person 2");
        //comparing annualSalary1 and annualSalary2 and storing the result in a variable ifMore
        bool ifMore = annualSalary1 > annualSalary2;
        //printing the result of the comparison
        Console.WriteLine(ifMore);
        Console.ReadLine();
    }
}