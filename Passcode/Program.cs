using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var passcode = "secret";

            Console.WriteLine("Enter the secret word: ");

            var tryThis = Console.ReadLine();
            if (tryThis == passcode)
            {
                Console.WriteLine("Success!");

            } else
            {
                Console.WriteLine("Nope. Fail.");
            }
            Console.ReadLine();
        }
    }
}
