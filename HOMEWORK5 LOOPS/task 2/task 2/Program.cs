using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
              int i;
    for (i = 1; i <= 100; i++) {
        if (i % 7 == 0 || i % 11 == 0) {
            Console.Write(i + " ");
        }
    }
    Console.WriteLine();
    i = 1;
    while (i <= 100) {
        if (i % 7 == 0 || i % 11 == 0) {
            Console.Write(i + " ");
        }
        i++;
    }
    Console.WriteLine();
    i = 1;
    do {
        if (i % 7 == 0 || i % 11 == 0) {
            Console.Write (i + " ");
        }
        i++;
    } while (i < 100);
    Console.WriteLine();
}
        }
    }

