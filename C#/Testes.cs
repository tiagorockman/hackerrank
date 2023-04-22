using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAPP
{
    public static class Testes
    {
        public static void MainTestes()
        {
            DateTime? start = null;
            DateTime? end = null;
            string texto = "ANA";
            string invertido = new string(texto.Reverse().ToArray());
            Console.WriteLine("Original Text = " + texto);

            start = DateTime.Now;
            Console.WriteLine("\n[libraryReverse]Reversed Text = " + invertido);
            end = DateTime.Now;
            TimeSpan ts = ((TimeSpan)(end - start));
            Console.WriteLine(String.Format("The execution time is {0} ms", ts));

            start = DateTime.Now;
            Console.WriteLine("\n[func]Reversed Text = " + inverter(texto));
            end = DateTime.Now;
            Console.WriteLine(String.Format("The execution time is {0} ms", (end - start)));

            if (texto == invertido)
                Console.WriteLine("\nTexto é Palindromo");
            else
                Console.WriteLine("\nTexto Não é Palindromo");

        }
        internal static string inverter(string param)
        {
            string textInvert = "";
            for (var i = param.Count() - 1; i >= 0; i--)
            {
                textInvert += param[i];
            }
            return textInvert;
        }


    }
}
