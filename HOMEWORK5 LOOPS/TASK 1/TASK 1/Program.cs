using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number;
            int sum = 0;
            do
            {
                number = Int32.Parse(Console.ReadLine());
                sum += number;
            } while (number != 0);
            Console.WriteLine("Sum is: " + sum);
        }
    }

}
    

