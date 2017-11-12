using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasksBlock001
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            Random rnd = new Random();
            DisplayTaskName(count++);
            Task001.SolveTheTask();
            GoToNextTask();
            DisplayTaskName(count++);
            Task002.SolveTheTask();
            GoToNextTask();
            DisplayTaskName(count++);
            Task003.SolveTheTask();
            GoToNextTask();
            DisplayTaskName(count++);
            Task004.SolveTheTask();
            GoToNextTask();
            DisplayTaskName(count++);
            Task005.SolveTheTask();
            GoToNextTask();
            DisplayTaskName(count++);
            Task006.SolveTheTask();
            DisplayTaskName(count++);
            Task007.SolveTheTask(rnd);
            GoToNextTask();
            DisplayTaskName(count++);
            Task008.SolveTheTask(rnd);
            GoToNextTask();
            DisplayTaskName(count++);
            Task009.SolveTheTask(rnd);
            GoToNextTask();
            DisplayTaskName(count++);
            Task010.SolveTheTask(rnd);
            EndProgram();
   

        }
        private static void GoToNextTask()
        {
            for (; ; )
            {
                Console.WriteLine();
                Console.WriteLine("Нажмите Tab для продолжения или Esc для выхода из консоли");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Tab)
                {
                    Console.Clear();
                    break;
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }   
        }
        private static void DisplayTaskName(int taskName)
        {
            Console.WriteLine("Решение задач по первому блоку \"CSharpBasic\"");
            Console.WriteLine("Решение задачи 1.{0}", taskName.ToString());
            Console.WriteLine();
        }
        private static void EndProgram()
        {
            for (; ; )
            {
                Console.WriteLine();
                Console.WriteLine("Нажмите Esc для выхода из консоли");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
        }

    }
}
