using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasksBlock001
{
    class Common
    {
        public static int InputNumber(int lowerBound)
        {
            int number;
            for (; ; )
            {
                if (Int32.TryParse(Console.ReadLine(), out number) && (number > lowerBound))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное значение, попробуйте еще раз");
                    continue;
                }
            }
            Console.WriteLine();
            return number;
        }
        public static int[] CreateRandArr(int k, Random rnd, int lowerBound = 0, int UpperBound = 150)
        {
            int[] array = new int[k];
            for (int j = 0; j < k; j++)
            {
                array[j] = rnd.Next(lowerBound, UpperBound);
            }
            return array;
        }
        public static int[,] CreateRandTwoDimensionalArray(int k, int h, Random rnd, int lowerBound = -20, int upperBound = 20)
        {
            int[,] array = new int[k, h];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(lowerBound, upperBound);
                }
            }
            return array;
        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" {0} \t", array[i]);
            }
            Console.WriteLine();
        }
        public static void PrintTwoDimensionalArray(int [,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("\t {0}", array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
