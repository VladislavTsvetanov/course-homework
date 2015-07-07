using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            {
                if (num < 2 || num > 9)
                    return;
            }
            {
                int elementsNum = num * num;
                int[] arr = new int[elementsNum];
                int sum = 0;
                int i;
                for (i = 0; i < elementsNum; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                    sum += arr[i];
                }
                int[,] arr2 = new int[num, num];
                int k = 0;
                for (i = 0; i < num; i++)
                    for (int j = 0; j < num; j++)
                    {
                        arr2[j, i] = arr[k++];
                    } Console.WriteLine(sum);
            } 
        }
    }
}

