using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (b <= a)
            {
                Console.WriteLine("b should be bigger than a");
                return;
            }

            for (; a <= b; a++)
            {
                if (a % 3 == 0)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}
