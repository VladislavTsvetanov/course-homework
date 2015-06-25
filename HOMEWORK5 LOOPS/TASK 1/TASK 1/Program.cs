using System;

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
                sum += number; //sum = sum + number
            } while (number != 0);
            Console.WriteLine("Sum is: " + sum);
        }
    }

}
    

