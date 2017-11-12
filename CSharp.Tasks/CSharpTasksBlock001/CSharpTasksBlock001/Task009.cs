using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasksBlock001
{
    class Task009
    {
        public static void SolveTheTask(Random rnd)
        {
            Console.WriteLine("Задан случайный массив:");
            int[] array = Common.CreateRandArr(10, rnd, -25 , 25);
            Common.PrintArray(array);
            Console.WriteLine();
            Console.WriteLine("Сумма положительных элементов данного массива равна: {0}", SumOfPositiveElements(array).ToString());
        }
        private static int SumOfPositiveElements(int[] Arr)
        {
            int sum = 0;
            for (int h = 0; h < Arr.Length; h++)
            {
                if (Arr[h] > 0)
                {
                    sum += Arr[h];
                }
                else
                {
                    continue;
                }
            }
            return sum;
        }
    }
}
