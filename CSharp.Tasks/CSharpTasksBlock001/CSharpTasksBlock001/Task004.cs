using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasksBlock001
{
    class Task004
    {
        public static void SolveTheTask()
        {
            Console.WriteLine("Для отображения фигуры ведите число строк:");
            DrawSpruce(Common.InputNumber(0));
        }
        private static void DrawSpruce(int LinesNumber)
        {
            int c = 0; 
            while (c < LinesNumber + 1)
            {
                int i = 0;
                while (i < c)
                {
                    int j = LinesNumber - i;
                    i ++;

                    while (j > 0)
                    {
                        j --;

                        Console.Write(" ");
                    }
                    int h = 0;
                    while (h < i * 2 - 1)
                    {
                        h ++;
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                c ++;
            }
        }
    }
}
