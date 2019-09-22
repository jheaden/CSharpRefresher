using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRegurge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name, pls...");
            var name = Console.ReadLine();

            Console.WriteLine("Age? ");
            var age = Console.ReadLine();

            Console.WriteLine("Birth month? ");
            var birthmonth = Console.ReadLine();

            Console.WriteLine("Your name is {0} and you are {1} years old and you were born in {2}. Spiffy!", name, age, birthmonth);
            Console.ReadKey();
        }
    }
}
