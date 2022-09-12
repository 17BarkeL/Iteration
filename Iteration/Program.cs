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
            // Repeat 561 times
            /*for (int i = 1; i <= 561; i++)
            {
                Console.WriteLine("This is iteration number " + i);
            }*/

            // Repeat until user says "Hello"
            string input = "";

            while (input.ToUpper() != "HELLO")
            {
                Console.WriteLine("Hello?");
                input = Console.ReadLine();
            }



            // Console.ReadLine();
        }
    }
}
