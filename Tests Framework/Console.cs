using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tests_Framework
{
    public class Example
    {
        static void Main(string[] args)
        {
            int c = 0;
            Console.WriteLine("The series is:");
            for (int i = 1; i < 10; i++)
            {
                c = c + i;
                Console.Write(c + " ");
            }

            Console.Write("\nPress 'Enter' to exit the process...");

            // another use of "Console.ReadKey()" method 
            // here it ask for press the enter key to exit 
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }

        }
    }
    }
