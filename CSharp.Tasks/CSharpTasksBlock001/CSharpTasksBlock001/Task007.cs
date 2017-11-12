using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasksBlock001
{
    class Task007
    {
        public static void SolveTheTask(Random rnd)
        {
            Console.WriteLine("Введите размер массива:");
            int s = Common.InputNumber(0);
            int[] array = Common.CreateRandArr(s, rnd);
            Console.WriteLine("Был создан массив размером {0} элементов:", s);
            Common.PrintArray(array);
            Console.WriteLine();
            Console.WriteLine("После сортировки по возрастанию массив выглядит следующим образом:");
            Common.PrintArray(SortArray(array));
            Console.WriteLine();
            Console.WriteLine("Максимальный элемент в массиве равен: \t " + FindMaxElementInArray(array));
            Console.WriteLine();
            Console.WriteLine("Минимальный элемент в массиве равен: \t " + FindMinElementInArray(array));
        }
        
        private static int[] SortArray(int[] a)
        {
            int[] cache = new int[a.Length];
            for (int w = 0; w < a.Length - 1; w++)
            {
                for (int e = 0; e < a.Length - 1; e++)
                {
                    if (a[e] <= a[e + 1])
                        continue;
                    else
                        SwapElements(a, e);
                }
            }
            return a;
        }
        private static void SwapElements(int[] array, int i)
        {
            int T = array[i];
            array[i] = array[i + 1];
            array[i + 1] = T;
        }
        public static int FindMaxElementInArray(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
                else
                {
                    continue;
                }
            }
            return max;
        }
        public static int FindMinElementInArray(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
                else
                {
                    continue;
                }
            }
            return min;

        }
    }
}
