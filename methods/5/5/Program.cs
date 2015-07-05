using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            printSimetric();
        }

        private static void printSimetric()
        {
            for (int i = 10; i <= 999; i++)
            {
                String num = i + "";
                char[] arr = num.ToCharArray();
                Array.Reverse(arr);
                String rev = new String(arr);

                if (num == rev)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
