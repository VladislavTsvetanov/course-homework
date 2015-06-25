using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] y =  { 10, 25, 29, 36, 35, 48, 29 , 58, 66 };
            int number = 29;

            for (int i = 0; i < y.Length; i++)
            {
                if (y[i]==number)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }
    }
}
