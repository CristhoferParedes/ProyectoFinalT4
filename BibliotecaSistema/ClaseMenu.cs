using System;

namespace BibliotecaSistema
{
    public class ClaseMenu
    {
        public static void MenuPrincipal()
        {
            string[] arreglomenu = { "REGISTRAR", "  VENTA  ", " REPORTE ", "MODIFICAR", "  AYUDA  ", "  SALIR  " };
            int posicion, opcionseleccionada = 0;
            ConsoleKey tecla;                    

            do
            {
                Console.Clear();
                ClaseInterfaz.Interfaz();
                posicion = 1;

                for (int i = 0; i < arreglomenu.Length; i++)
                {                  
                    if (opcionseleccionada == i)
                    {
                        Console.SetCursorPosition(posicion, 3);
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(" " + arreglomenu[i] + " ");
                        Console.ResetColor();                     
                    }
                    else
                    {
                        Console.SetCursorPosition(posicion, 3);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(" " + arreglomenu[i] + " ");
                        Console.ResetColor();             
                    }
                    posicion = posicion + 12;
                    Console.SetCursorPosition(2, 5);
                }
                tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.RightArrow)
                {
                    opcionseleccionada++;

                    if (opcionseleccionada > arreglomenu.Length - 1)
                    {
                        opcionseleccionada = 0;
                    }
                }
                else if (tecla == ConsoleKey.LeftArrow)
                {
                    opcionseleccionada--;

                    if (opcionseleccionada < 0)
                    {
                        opcionseleccionada = arreglomenu.Length - 1;
                    }
                }

            } while (tecla != ConsoleKey.Enter);

            switch (opcionseleccionada)
            {
                case 0:
                    //SubmenuRegistro();
                    Console.WriteLine("Hola");
                    break;
            }
        }
    }
}
