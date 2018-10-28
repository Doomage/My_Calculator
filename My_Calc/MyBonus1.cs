using System;
namespace MyBonus1
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
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                // Use a switch statement to do the math
                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2)); // Line 32
                        break;
                    case "s":
                        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "m":
                        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "d":
                        // Ask the user to enter a non-zero divisor until they do so
                        while (num2 == 0)
                        {
                            Console.WriteLine("Enter a non-zero divisor: ");
                            num2 = Convert.ToInt16(Console.ReadLine());
                        }
                        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                        break;
                    // Return text for an incorrect option entry
                    default:
                        Console.WriteLine("That is an incorrect option entry, please try again.");
                        break;
                }

            } while (true);
        }
    }
}
