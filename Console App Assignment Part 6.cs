using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleappArrayAssignment
{
    class Program
    {
        static void Main()
        {
            // Assignment: Part 1
            //Create 1 dimensional array of strings
            string[] FirstText = { "James ", "Kayne ", "George ", "Victor " };
            // A loop that iterates through each string in the array and adds the user's text input to the end of each string.
            // This step will not output anything to the console, but will update each array element by appending the user's text.
            for (int i = 0; i < FirstText.Length; i++)
            {
                Console.WriteLine($"Current Text: {FirstText[i]}");
                Console.Write("Enter text to append: ");
                //Then create a second loop that prints off each string in the array one at a time.
                string userInput = Console.ReadLine();
                FirstText[i] += userInput;
                Console.WriteLine(
                    $"Updated Text: {FirstText[i]}");
            }
            // Assignment: Part 2
            //An infinite loop
            List<int> numbers = new List<int>();
            int count = 0;
            // A loop that iterates through each integer in the array and adds it to a list of integers.
            while (true)
            {
                numbers.Add(count);
                Console.WriteLine($"Current Count: {count}");
                count++;
                if (count >= 10)  // Exit condition for the infinite loop
                {
                    Console.WriteLine("Infinite loop ended after reaching 10.");
                    break;  // This breaks the loop
                }
            }
            // Assignment: Part 3
            //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            // A loop that iterates through each integer in the list and prints it to the console.
            int[] num = {58, 61, 83, 68};
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Number at index < {i}: {num[i]}");
            }
            //Add another loop where the comparison that’s used to determine
            //whether to continue iterating the loop is a “<=” operator.
            for (int i = 0; i <= num.Length - 1; i++)
            {
                Console.WriteLine($"Number at index <= {i}: {num[i]}");
            }
            // Assignment: Part 4
            // A list of strings where each item in the list is unique.
            List<string> uniqueStrings = new List<string> { "Apple", "Banana", "Orange", "Pineapple" };
            // Ask the user to input text to search for in the list.
            Console.Write("Enter a string to search for in the list: ");
            // A loop that iterates through the list and then displays
            // the index of the list item that contains matching text on the screen.
            string searchText = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < uniqueStrings.Count; i++)
            {
                if (uniqueStrings[i].Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Found '{searchText}' at index {i} in the list.");
                    found = true;
                }
            }
            //Add code to check if the user put in text that isn't on the list and,
            //if they did, tell the user their input is not on the list.
            // Add code that stops the loop from executing once a match has been found.
            if (!found)
            {
                Console.WriteLine($"'{searchText}' is not found in the list.");
            }
            // Assignment: Part 5
            // A list of strings that has at least two identical strings in the list.
            // Ask the user to select text to search for in the list.
            List<string> duplicateStrings = new List<string> { "Cat", "Dog", "Cat", "Bird" };
            Console.Write("Enter a string to search for duplicates in the list: ");
            // Create a loop that iterates through the list and then displays
            // the indices of the list that contain matching text on the screen.
            // Ensure to remove any break statements that may prevent your code from returning multiple matches.
            string searchDuplicateText = Console.ReadLine();
            List<int> indices = new List<int>();
            for (int i = 0; i < duplicateStrings.Count; i++)
            {
                if (duplicateStrings[i].Equals(searchDuplicateText, StringComparison.OrdinalIgnoreCase))
                {
                    indices.Add(i);
                }
            }
            //Add code to the loop to check if the user put in text that isn't on the list and,
            //if they did, tells the user their input is not on the list.
            //(You do not need to provide any additional chances for the user to enter text.)
            if (indices.Count > 0)
            {
                Console.WriteLine($"Found '{searchDuplicateText}' at indices: {string.Join(", ", indices)}");
            }
            else
            {
                Console.WriteLine($"'{searchDuplicateText}' is not found in the list.");
            }
            // Assignment: Part 6
            // Create a list of strings that has at least two identical strings in the list.
            List<string> stringList = new List<string> { "Red", "Blue", "Green", "Red" };
            // Create a foreach loop that evaluates each item in the list,
            // and displays a message showing the string and whether or not it has already appeared in the list.
            // For example, if you had a list of letters: {“A”, “B”, “C”, “D”, “C”},
            // you could have the following print to the screen:
            // A - this item is unique
            // B - this item is unique
            // C - this item is unique
            // D - this item is unique
            // C - this item is a duplicate
            foreach (string item in stringList)
            {
                if (stringList.IndexOf(item) == stringList.LastIndexOf(item))
                {
                    Console.WriteLine($"{item} - this item is unique");
                }
                else
                {
                    Console.WriteLine($"{item} - this item is a duplicate");
                }
            }
        }
    }
}