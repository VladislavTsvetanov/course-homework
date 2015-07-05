using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 30; i >= 1; i--)
            {
                Console.Write(i + "\t");

                if ((i - 1) % 6 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
