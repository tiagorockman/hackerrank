using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAPP
{
    class Lista
    {

        public static void MainLista()
        {
            
            List<string> list1 = new List<string> { "doc", "helder", "tac", "turn" };
            List<string> list2 = new List<string> { "dcl", "doc", "tac" };

            ListCount(list1, list2);
            ListToString(list1);
            StringToList("Essa é uma lista separada por espaço.");
        }
    
        public static void ListCount(List<string> list1, List<string> list2)
        {
            Console.WriteLine("/********** LIST COUNT *************/");
            //LINQ to count itens of two list
            // conta a quantidade de item que contem da lista 2 na lista 1
            int qtd = list2.Where(l => list1.Contains(l)).Count();
             Console.WriteLine(qtd);

            qtd = list2.Count(l => list1.Contains(l));
             Console.WriteLine(qtd);
        }

        public static void ListToString(List<string> list1)
        {
            Console.WriteLine("/********** LIST TO STRING *************/");
            string stringered = string.Join(", ", list1);
            Console.WriteLine(stringered);
        }

        public static void StringToList(string str)
        {
            Console.WriteLine("/********** STRING TO LIST *************/");
            List<string> stringered = str.Split(' ').ToList();
            stringered.ForEach(s => Console.WriteLine($"[index]{stringered.IndexOf(s)} - {s}"));
        }
    }
    
}
