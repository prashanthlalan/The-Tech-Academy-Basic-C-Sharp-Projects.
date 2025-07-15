
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of integers
        List<int> numbers = new List<int> () { 120, 210, 370, 490, 560 };
        //Ask the user for a number to divide each number in the list by.
        //Write a loop that takes each integer in the list, divides it by
        //the number the user entered, and displays the result to the screen.
        bool numValid = false;
        while (!numValid)
        {
            //Using a try/catch block to give error message
            try
            {
                Console.WriteLine("Please enter a number to divide each number in the list by:");
                float divisor = float.Parse(Console.ReadLine());
                if (divisor == 0)
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                //Dividing each number in the list by the divisor
                else
                {
                    foreach (int number in numbers)
                    {
                        float result = number / divisor;
                        Console.WriteLine(number + "/" + divisor + " = " + result);
                    }
                    numValid = true;
                }
            }
            //Catch block to display an error message for string input
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        // Message to let the user know the program has completed the try/catch block
        Console.WriteLine("The program has exited the try/catch block");
    }
}