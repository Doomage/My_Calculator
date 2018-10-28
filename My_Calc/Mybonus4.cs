using System;
namespace MyBonus4
{
    public class Calculator
    {
        public string x;
        public float num1, num2;
        public Calculator()
        {
            do
            {
                // Display title as the C# console calculator app
                Console.WriteLine("Console Calculator in C#\r");
                Console.WriteLine("------------------------\n");

                // Ask the user to type the first number
                do
                {
                    Console.WriteLine("Type 1st number, and then press Enter");
                    num1 = float.Parse(Console.ReadLine());
                    // Line 13: convert num1 to integer

                    // Ask the user to type the second number
                    Console.WriteLine("Type 2nd number, and then press Enter");
                    num2 = float.Parse(Console.ReadLine());
                    // Line 18: convert num2 to integer
                } while ((num1 < -100.0 || num1 > 100.0) || (num2 < -100.0 || num2 > 100.0));//float numbers answer 10
               //while ((num1<-100 || num1 > 100) || (num2 < -100 || num2 > 100)); answer 9

                //while (num1 < 100 || num2 < 100);answer 8

                //while (num1 < 0 || num2 < 0); answer 7
                // Ask the user to choose an option
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\tAdd or 1");
                Console.WriteLine("\tSubtract or 2");
                Console.WriteLine("\tMultiply or 3");
                Console.WriteLine("\tDivide or 4");
                Console.Write("Your option? ");
                string choice = Console.ReadLine();
                // Use a switch statement to do the math
                if (choice == "add" || choice == "1")
                {
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2)); // Line 32
                }
                else if (choice == "subtract" || choice == "2")
                {
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));

                }
                else if (choice == "multiply" || choice == "3")
                {
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));

                }
                else if (choice == "divide" || choice == "4")
                {
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = Convert.ToInt16(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));

                }
                else
                {
                    Console.WriteLine("That is an incorrect option entry, please try again.");

                }

                Console.WriteLine("Press X if u want to close the program");
                x = Console.ReadLine();
            } while (x != "X" && x != "x");

        }
    }
}