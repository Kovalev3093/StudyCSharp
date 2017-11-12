using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasksBlock001
{
    class Task006
    {
        [Flags]
        internal enum Fonts : byte
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4,
        }
        public static void SolveTheTask()
        {
            var fonts = Fonts.None;
            ConsoleKeyInfo key;

            while (true)
            {
                Console.Write("Параметры надписи: ");
                Console.WriteLine(fonts);
                Console.WriteLine("Введите:");
                Console.WriteLine("\t 1: bold");
                Console.WriteLine("\t 2: italic");
                Console.WriteLine("\t 3: undeline");
                Console.WriteLine();
                Console.WriteLine("Нажмите Tab для продолжения или Esc для выхода из консоли");
                key = Console.ReadKey();
                Console.WriteLine();
                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                if (key.Key == ConsoleKey.Tab)
                {
                    Console.Clear();
                    break;
                }

                Console.WriteLine();

                switch (key.KeyChar)
                {
                    case '1':
                        fonts ^= Fonts.Bold;
                        break;
                    case '2':
                        fonts ^= Fonts.Italic;
                        break;
                    case '3':
                        fonts ^= Fonts.Underline;
                        break;
                }
            }
        }
    }
}
