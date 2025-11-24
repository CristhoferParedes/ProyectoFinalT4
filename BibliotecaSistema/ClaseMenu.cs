using System;

namespace BibliotecaSistema
{
    public class ClaseMenu
    {
        public static void MenuPrincipalDinamico()
        {
            string[] menuPrincipal = { " REGISTRAR ", "   VENTA   ", "  REPORTE  ", " MODIFICAR ", "   SALIR   " };
            int controlFila = 1, indice = 0;

            ClaseInterfaz.Interfaz();

            ConsoleKey tecla;

            for (int i = 0; i < menuPrincipal.Length; i++)
            {
                Console.WriteLine(" ");
                if (indice == i)
                {
                    Console.SetCursorPosition(controlFila,3);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(" " + menuPrincipal[i] + " ");
                    Console.ResetColor();
                }
                else
                {
                    Console.SetCursorPosition(controlFila, 3);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(" " + menuPrincipal[i] + " ");
                    Console.ResetColor();

                }
                controlFila = controlFila + 14;
            }

            //Continuar para que el menu cambie de opcion con las teclas de derecha e izquierda
            //No olvidar la Est. Repetitiva Do{} while();

            ConsoleKeyInfo Info = Console.ReadKey(true);
            tecla = Info.Key;
            Console.SetCursorPosition(0, 10);
        }
    }
}
