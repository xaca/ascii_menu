using System;
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
            /* Imprimiendo una cade con comillas
               si intenta imprimir Console.WrtiLine(""hola"");
               aparece un error de sintaxis, solución usar
               una secuencia de escape
            */

            Console.WriteLine("\"hola\"");
            Console.WriteLine("\\hola\\");

            //Esta línea es para que no se cierre el programa si no lo ejecuta con ctrl + f5
            Console.ReadKey();
        }
    }
}
