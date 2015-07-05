using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_dim_array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,] { {1, 5}, {2, 5}, {3, 4}, {12, 24} };

            foreach (int i in arr)
            {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
