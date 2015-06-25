using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int small = 0;
            int big = 0;
            bool initialized = false;
            for (int i = 0; i < 5; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (initialized)
                {
                    if (small > n)
                    {
                        small = n;
                    }
                    if (big < n)
                    {
                        big = n;
                    }
                }
                else
                {
                    small = n;
                    big = n;
                    initialized = true;
                }
            }
            Console.WriteLine("Small: " + small + " Big: " + big);
        }
    }
}

