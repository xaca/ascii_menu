﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiMenu
{
    class Program
    {
        static void Main(string[] args)
        {

            string temp;
            int opc = 0, n, m;

            do
            {
                Console.WriteLine("  ...............................q(-_-)p.................................");
                Console.WriteLine("  .   o   \\ o /  _ o        __|  '_) (_`   |__         o _  \\ o /   o   .");
                Console.WriteLine("  .  /|\\    |     /\\   __\\o      /__/  \\        o/__   /\\     |    /|\\  .");
                Console.WriteLine("  .  / \\   / \\   | \\  /) |     _(<_   / )_      |   (\\ / |   / \\   / \\  .");
                Console.WriteLine("  .       ....................(__\\_\\_|_/__)......................       .");
                Console.WriteLine("  .       .    ___            _                                 .       .");
                Console.WriteLine("  .       .   / __\\___   ___ | |       /\\/\\   ___ _ __  _   _   .       .");
                Console.WriteLine("  .  __\\o .  / /  / _ \\ / _ \\| |_____ /    \\ / _ \\ '_ \\| | | |  .  __\\o .");
                Console.WriteLine("  . /) |  . / /__| (_) | (_) | |_____/ /\\/\\ \\  __/ | | | |_| |  . /) |  .");
                Console.WriteLine("  .       . \\____/\\___/ \\___/|_|     \\/    \\/\\___|_| |_|\\__,_|  .       .");
                Console.WriteLine("  .  o _  .                                                     .  o _  .");
                Console.WriteLine("  .  /\\   .              Ingrese una opción así:                .  /\\   .");
                Console.WriteLine("  .  / |  .   1. Dibujar un cuadrado de N por M líneas          .  / |  .");
                Console.WriteLine("  .       .   2. Traducir un emoji a una expresión escrita      .       .");
                Console.WriteLine("  . \\ o / .   3. Códificar un texto usando la clave murciélago  . \\ o / .");
                Console.WriteLine("  .   |   .  -1. Para salir                                     .   |   .");
                Console.WriteLine("  .  / \\  .                                                     .  / \\  .");
                Console.WriteLine("  .       .......................................................       .");
                Console.WriteLine("  .   o   \\ o /  _ o        __|    \\ /     |__         o _  \\ o /   o   .");
                Console.WriteLine("  .  /|\\    |     /\\   __\\o   \\o    |    o/     o/__   /\\     |    /|\\  .");
                Console.WriteLine("  .  / \\   / \\   | \\  /) |    ( \\  /o\\  / )    |   (\\  / |   / \\   / \\  .");
                Console.WriteLine("  dc.....................................................................");


                Console.Write(">");
                temp = Console.ReadLine();

                if(int.TryParse(temp,out opc))
                {
                    switch (opc)
                    {
                        case 1: Console.WriteLine("------------Dibujar un cuadrado--------------------");
                                Console.Write("Ingrese n: ");
                                temp = Console.ReadLine();
                                if(int.TryParse(temp,out n))
                                {
                                    Console.Write("Ingrese m: ");
                                    temp = Console.ReadLine();
                                    if (int.TryParse(temp, out m))
                                    {
                                        for (int i = 0; i < m; i++)
                                        {
                                            for (int j = 0; j < n; j++)
                                            {
                                                Console.Write("*");
                                            }
                                            Console.WriteLine();
                                        }
                                    }
                                }
                            Console.WriteLine("< Presione cualquier tecla para volver al menú");
                                Console.ReadKey(); //Para poder ver el resultado 
                                break;
                        case 2: Console.WriteLine("------------Traducir emoji pendiente--------------------");
                                break;
                        case 3: Console.WriteLine("------------Codificar texto clave murcielago--------------------");
                                break;
                        default:
                                break;
                    }
                }
                else
                {
                    Console.WriteLine("Dato incorreto, intente nuevamente");
                }

            } while (opc != -1);
            

            

            //Esta línea es para que no se cierre el programa si no lo ejecuta con ctrl + f5
            Console.ReadKey();
        }
    }
}
