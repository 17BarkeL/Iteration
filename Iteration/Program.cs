using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        static void Repeat()
        {
            // Repeat 561 times
            for (int i = 1; i <= 561; i++)
            {
                Console.WriteLine("This is iteration number " + i);
            }
        }
  
        static void Hello()
        {
            // Repeat until user says "Hello"
            string input = "";

            while (input.ToUpper() != "HELLO")
            {
                Console.WriteLine("Hello?");
                input = Console.ReadLine();
            }
        }

        static void EvenOddThreeAllInOne()
        {
            for (int i = 1; i <= 50; i++)
            {
                string evenOrOdd = i % 2 == 0 ? "even" : "odd";
                string div3 = i % 3 == 0 ? "divisible by 3" : "not divisible by 3";

                Console.WriteLine($"{i}: {evenOrOdd}, {div3}");
            }
        }

        static void EvenOrOdd()
        {
            // Is number even or odd
            string evenOrOdd = "";
            int number = 3;

            if (number % 2 == 0)
            {
                evenOrOdd = "even";
            }

            else
            {
                evenOrOdd = "odd";
            }
        }

        static void DivisibleByThree()
        {
            // Is number divisible by 3
            int number = 27;
            string divisibleBy3 = number % 3 == 0 ? "Divisible by 3" : "Not divisible by 3";

            Console.WriteLine(divisibleBy3);
        }
    }
}
