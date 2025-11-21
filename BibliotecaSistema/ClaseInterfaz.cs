using System;

namespace BibliotecaSistema
{
    public class ClaseInterfaz
    {
        public static void n()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                                                            ");
            Console.WriteLine("                              SISTEMA DE VENTAS - TIENDA MASS                               ");
            Console.WriteLine("                                                                                            ");
            Console.ResetColor();

            Console.SetCursorPosition(0, 4);
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                                                            ");
            Console.ResetColor();

            for (int i = 5; i < 25; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  ");
                Console.ResetColor();
            }

            for (int i = 5; i < 25; i++)
            {
                Console.SetCursorPosition(90, i);
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  ");
                Console.ResetColor();
            }

            Console.SetCursorPosition(0, 25);
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                                                                                            ");
            Console.ResetColor();
        }
    }
}
