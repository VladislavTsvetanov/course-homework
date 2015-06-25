using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {5, 10, 20, 30, 45, 52, 7, 80, 3, 2};
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    sum += a[i];
            }

            Console.WriteLine("sum=" + sum);
        }
    }
}
