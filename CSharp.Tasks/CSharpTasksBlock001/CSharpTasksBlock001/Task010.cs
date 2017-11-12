using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasksBlock001
{
    class Task010
    {
        public static void SolveTheTask(Random rnd)
        {
            Console.WriteLine("Введите число строк двумерного массива:");
            int rows = Common.InputNumber(0);
            Console.WriteLine("Введите число столбцов двумерного массива:");
            int cols = Common.InputNumber(0);
            int[,] array = Common.CreateRandTwoDimensionalArray(rows, cols, rnd);
            Console.WriteLine("Двумерный массив заданного размера был наполнен случаными числами:");
            Common.PrintTwoDimensionalArray(array);
            Console.WriteLine("Сумма элементов стоящих на четной позиции равна:");
            Console.WriteLine(SumOfEvenElements(array));
        }
        private static int SumOfEvenElements(int[,] array)
        {
            int sum = 0;
            for (int h = 0; h < array.GetLength(0); h++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                    if ((k + h) % 2 == 0)
                    {
                        sum += array[h, k];
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
