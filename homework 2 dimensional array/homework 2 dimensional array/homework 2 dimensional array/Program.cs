using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2_dimensional_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 4];

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = i * 4 + j;
                }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (arr[i, j] % 2 != 0)
                    {
                        arr[i, j] *= 2;
                    }

                    Console.Write(arr[i, j] + " ");
                }

                Console.WriteLine();
            }

        }
    }
}
