using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAPP
{
     class Fibonacci
    {
        public static void MainFibonacci()
        {
            Fibonaci(10);
        }

        private static void Fibonaci(int n)
        {
            if (n <= 0)
                Console.WriteLine("Valor inválido");

            int primeiro = 1, segundo = 1, atual =0;
            List<int> resultado = new List<int>() { primeiro, segundo };
            while(segundo < n)
            {
                atual = primeiro;
                primeiro = segundo;
                segundo = primeiro + atual;
                if(segundo < n)
                    resultado.Add(segundo); 
            }
            resultado.ForEach(r => Console.WriteLine($"{r}"));
        }
    }
}
