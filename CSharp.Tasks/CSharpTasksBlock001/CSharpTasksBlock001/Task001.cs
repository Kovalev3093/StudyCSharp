using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasksBlock001
{
    class Task001
    {
        public static void SolveTheTask()
        {
            Console.WriteLine("Введите длину прямоугольника");
            int length = Common.InputNumber(0);
            Console.WriteLine("Введите ширину прямоугольника");
            int width = Common.InputNumber(0);
            Console.WriteLine("Площадь прямоугольника со сторонами {0} и {1} равна: {2}", length.ToString(), width.ToString(), AreaCalculation(length, width).ToString());
        }
        private static int AreaCalculation(int length, int width)
        {
            int area = length * width;
            return area;
        }
        }
}
