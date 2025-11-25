using System;

namespace BibliotecaSistema
{
    public class ClaseInterfaz
    {
        public static void Interfaz()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                                                                         ");
            Console.WriteLine("                      SISTEMA PARA GESTION DE VENTAS                     ");
            Console.WriteLine("                                                                         ");
            Console.ResetColor();

            Console.SetCursorPosition(0, 4);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                                                         ");
            Console.ResetColor();

            for (int i = 5; i < 20; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write("  ");
                Console.SetCursorPosition(71, i);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write("  ");             
                Console.ResetColor();
            }
            
            Console.SetCursorPosition(0, 20);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                                                         ");
            Console.ResetColor();
        }
    }
}
