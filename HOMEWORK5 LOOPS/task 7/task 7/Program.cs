using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number for n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter a number for k");
            int k = int.Parse(Console.ReadLine());    
            Console.WriteLine("N!*K!/(N-K)! = " + factorial(n) * factorial(k) / factorial(n - k));
        }
        private static int factorial(int num)
        {
            int factorial = num--;
            for (; num >= 1; num--)
            {
                factorial *= num;
            }
            return factorial;
        }

    }

}