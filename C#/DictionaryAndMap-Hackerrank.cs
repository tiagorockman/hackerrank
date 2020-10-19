using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleAPP
{
   static class DictionaryAndMap_Hackerrank
    {
        /* -- Exemplo Input 
        3
        James 23333
        Julio 21454
        Carla 99877
        Julio
        Abraao
        Julipa
        Tucan
        James
        */
        public static void MainDict()
        {
            Dictionary<String, String> PhoneBook = new Dictionary<String, String>();
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var s = Console.ReadLine().Split(' ');
                PhoneBook.Add(s[0], s[1]);
            }

            String name;

            while ((name = Console.ReadLine()) != null)
            {
                try
                {
                    Console.WriteLine($"{name}={PhoneBook[name]}");
                }
                catch
                {
                    Console.WriteLine("Not found");
                }
            }
        }
   }
}
