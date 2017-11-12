using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasksBlock001
{
    class Task003
    {
        public static void SolveTheTask()
        {
            Console.WriteLine("Для отображения фигуры ведите число строк:");
            DrawTriangle1(Common.InputNumber(0));
        }
        private static void DrawTriangle1(int LinesNumber)
        {
            int i = 0;
            while (i < LinesNumber)
            {
                int j = LinesNumber - i;
                i += 1;

                while (j > 0)
                {
                    j -= 1;

                    Console.Write(" ");
                }
                int h = 0;
                while (h < i * 2 - 1)
                {
                    h += 1;
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
