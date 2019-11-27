using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Fizz_Buzz
{
    class Program
    {
        // Print numbers from 1 to 100
        // replace multiples of 3 with Fizz
        // replace multiples 5 with Buzz
        // replace multiple of 15 or both 3 &  5 with FizzBuzz
        // What will I need
        // For Loop
        // if statements
        // 
        static void Main(string[] args)
        {
            int i = 0;
            for (; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
