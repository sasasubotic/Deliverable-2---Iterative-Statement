/*
Name: Sasa Subotic
Date: 9/11/2019
Class: ISM4300
Project Name: Deliverable 2, Iterative Statements
*/

using System;

namespace Deliverable_2_Iterative_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user to input a value between 1-100, also puts a date and time on the console
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("System Date/Time: " + DateTime.Now);
            Console.WriteLine("Enter a value from 1 to 100");

            //Try-catch to catch any exceptions to this statement
            try
            {
                //Establishing variables and strings
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);

                //IF statement to establish the parameters of the inputted value
                if (value_of_input > 0 & value_of_input <= 100)
                {
                    Console.WriteLine("Executing a for loop, please wait.");
                    Console.WriteLine("The For Loop will iterate " + value_of_input.ToString() + " times");

                    //for every loop, the loop amount will increase by 1, hence the i++
                    for (int i = 1; i < value_of_input; i++)
                    {
                        Console.WriteLine("You have entered " + value_of_input.ToString() + ". This is the current integer number in the loop : " + i);
                    }

                    //The ending/closing of the application
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);
                }

                //else statement to correct any amount not between 1 and 100
                else
                {
                    //sets the console text color to red to indicate an error
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error, please enter a value from 1-100");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);
                }
            }

            //catch to get the exceptions and send an "error" message
            catch
            {
                {
                    //sets the text color to red to indicate an error
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error, Please enter a integer");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);
                }
            }

        }
    }
}
