using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            greet(Console.ReadLine());
        }

        private static void greet(string name)
        {
            Console.WriteLine("Greetings, " + name);
        }
    }
}
