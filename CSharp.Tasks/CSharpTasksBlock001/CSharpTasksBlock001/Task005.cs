using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasksBlock001
{
    class Task005
    {
        public static void SolveTheTask()
        {
            int num1, num2, num3, upperBound;
            num1 = 3;
            num2 = 5;
            num3 = 15;
            upperBound = 1000;
            int result = ArithmeticProgression(num1, upperBound) + ArithmeticProgression(num2, upperBound) - ArithmeticProgression(num3, upperBound);
            Console.WriteLine("Сумма всех чисел до {0}, кратных {1} или {2} равна: {3}", upperBound.ToString(), num1.ToString(), num2.ToString(), result.ToString());
        }
        private static int ArithmeticProgression(int step, int upperBound)
        {
            int a = upperBound - 1;
            int b = a / step;
            int sum = (step*((1 + b) * b)) / 2;
            return sum;
        }
    }

}
