using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            if (str1.Contains(str2))
            {
                Console.WriteLine("str1 contains str2");
            }
            else {
                Console.WriteLine("str1 does not contain str2");

            }
        }
    }
}
