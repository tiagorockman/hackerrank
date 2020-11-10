using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAPP
{
    class Binary_Number
    {
        public static void MainBinary()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToString(n, 2); //converte para binario base2 
                                            //Console.WriteLine(b);
            string[] arr = b.Split('0').ToArray(); //separa o 0 transforma em array
                                                   // Console.WriteLine(string.Join(", ", arr));
            int c = arr.Select(x => {
                    //Console.WriteLine(x.Length);
                    return x.Length;
                }
            ).Max(); // retorna o máximo de número 1 juntos exemplo 1 = 1 | 11 = 2

            Console.WriteLine(c);
        }
    }
}
