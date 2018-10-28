using System;

namespace My_Calc
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t1 - Bonus1");
            Console.WriteLine("\t2 - Bonus2");
            Console.WriteLine("\t3 - Bonus3");
            Console.WriteLine("\t4 - Bonus4");
            Console.WriteLine("\tPress anything else if u want to check Default");
            Console.Write("Your option? ");
            string x = Console.ReadLine();

            switch (x)
            {
                case "1":
                    MyBonus1.Calculator mybonus1 = new MyBonus1.Calculator();
                    break;
                case "2":
                    MyBonus2.Calculator mybonus2 = new MyBonus2.Calculator();
                    break;
                case "3":
                    MyBonus3.Calculator mybonus3 = new MyBonus3.Calculator();
                    break;
                case "4":
                    MyBonus4.Calculator mybonus4 = new MyBonus4.Calculator();
                    break;
                default:
                    My_Calc.Calculator calc = new My_Calc.Calculator();
                    break;
            }

            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}

