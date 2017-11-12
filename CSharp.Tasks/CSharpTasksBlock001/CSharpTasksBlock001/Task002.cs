using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasksBlock001
{
    class Task002
    {
        public static void SolveTheTask()
        {
            Console.WriteLine("Для отображения фигуры ведите число строк:");
            DrawTriangle(Common.InputNumber(0));
        }
        private static void DrawTriangle(int LinesNumber)
        {
            for (int i = 0; i < LinesNumber; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
