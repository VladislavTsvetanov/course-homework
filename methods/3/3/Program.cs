using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = (int)Math.Pow(int.MaxValue, 1.0/3);
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int a = (int)(r.NextDouble() * max);
                int b = (int)(r.NextDouble() * max);
                int c = (int)(r.NextDouble() * max);
                Console.WriteLine(a + " X " + b + " X " + c + " = " + mult(a, b, c));
            }
        }

        private static int mult(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}
