using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_of_hm4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your bonus score");
            int bonusscore = int.Parse(Console.ReadLine());

            if (bonusscore>1 && bonusscore<=3)
            {
                Console.WriteLine(bonusscore*5);
            }
            else if (bonusscore>4 && bonusscore<=6)
            {
                Console.WriteLine(bonusscore*10);  
            }
            else if (bonusscore>7 && bonusscore<=9)
            {
                Console.WriteLine(bonusscore*50);
            }
        }
    }
}
