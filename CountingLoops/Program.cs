using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // count from 1 to 10, then back down again. 
            //Do this 5 times

            for (int f = 1; f <= 5; f++)
            {

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }

                for (int j = 10; j >= 1; j--)
                {
                    Console.WriteLine(j);
                }

                Console.WriteLine("That was the " + f);

            }

            Console.ReadKey();

        }
    }
}

