using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasksBlock001
{
    class Task008
    {
        public static void SolveTheTask(Random rnd)
        {
            int[] array = Common.CreateRandArr(10, rnd, -20, 20);
            Console.WriteLine("Задан массив, наполненный случаныйми числами в диапазоне от -20 до 20:");
            Common.PrintArray(array);
            PositiveElementsToZero(array);
            Console.WriteLine();
            Console.WriteLine("После преобразования всех положительных элементов массива в 0 получается:");
            Common.PrintArray(array);
        }
        private static void PositiveElementsToZero(int[] Arr)
    {
        for (int h = 0; h < Arr.Length; h++)
        {
            if (Arr[h] > 0)
            {
                Arr[h] = 0;
            }
            else
            {
                continue;
            }
        }
    }
    }
}
