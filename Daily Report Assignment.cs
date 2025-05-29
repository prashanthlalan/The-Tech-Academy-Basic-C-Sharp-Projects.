using System;

namespace myConsoleProject.cs
{
    internal class Program
    {
        static void Main()
        {
            //Displaying College Name
            Console.WriteLine("Academy of Learning Career College");
            
            //Displaying Title of the report
            Console.WriteLine("Student Daily Report.");
            
            //Get student's name through What is your name? input and assign it to string variable studentName.
            Console.WriteLine( "What is your name?");
            string studentName = Console.ReadLine();
            
            //Get student's course through What course are you on? input and assign it to variable studentCourse.
            Console.WriteLine("What course are you on?");
            string studentCourse = Console.ReadLine();
            
            //Get page number the student that is currently learning through What page number? input, convert it into integer datatype and assign it to variable pageNumber.
            Console.WriteLine("What page number?");
            int pageNumber  = Convert.ToInt32(Console.ReadLine());

            //Get whether the student need any assistance through Do you need help with anything? Please answer "true" or "false".? input, convert it into boolean datatype and assign it to variable needHelp.
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            //Get any positive feedback on learning so far from the student through Were there any positive experiences you’d like to share? Please give specifics. input and assign it to variable Experience
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string Experience = Console.ReadLine();

            //Get any other feedback on learning so far from the student through Is there any other feedback you’d like to provide? Please be specific. input and assign it to variable Experience
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string Feedback = Console.ReadLine();

            //Get any other feedback on learning so far from the student through Is there any other feedback you’d like to provide? Please be specific. input and assign it to variable Experience
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            //Displaying the confirmation message
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
