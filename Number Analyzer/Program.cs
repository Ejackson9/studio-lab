using System;

namespace Number_Analyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat;
            do
            {
                Console.WriteLine("Enter a number between 1 and 100:");
                double number = double.Parse(Console.ReadLine());
                if (number % 2 != 0)
                {
                    Console.WriteLine($"{number} Odd");
                }
                if (number % 2 == 0 && number >= 2 && number <= 25)
                {
                    Console.WriteLine($"{number} Even and less than 25");
                }
                if (number % 2 == 0 && number >= 26 && number <= 60)
                {
                    Console.WriteLine($"{number}and Even ");
                }
                if (number % 2 == 0 && number >= 60)
                {
                    Console.WriteLine($"{number}and Even");
                }
                if (number % 2 != 0 && number >= 60)
                {
                    Console.WriteLine($"{number}and Odd");
                }
                Console.WriteLine("Continue? (y/n)");
                repeat = Console.ReadLine();
            } while (repeat == "y" || repeat == "Y");
            Console.WriteLine("BYE!");
        }
    }
}
