using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAPP
{
    public static class Anagrama
    {
       public static void AnagramaCheck()
        {
            Console.WriteLine("/********** Anagrama Check *************/");
            List<string> dic = new List<string> { "heater", "cold", "clod", "reheat", "docl" };
            List<string> que = new List<string> { "cold", "heater", "abcd" };
            List<int> resultado = stringAnagram(dic, que);
            /*
                        foreach (var q in que)
                        {
                            int cont = 0;
                            foreach (var letter in dic)
                            {
                                if (IsAnagram(q, letter))
                                    cont += 1;
                            }
                            ret.Add(cont);
                        }
                       ret.ForEach(r => Console.WriteLine(r));

                        */
        }

        public static List<int> stringAnagram(List<string> dictionary, List<string> query)
    {
        List<int> ret = new List<int>();
        query.ForEach(q =>
        {
            int cont = 0;
            dictionary.ForEach(d =>
            {
                if (IsAnagram(q, d))
                    cont += 1;

            });
            ret.Add(cont);
        });

        // var r = IsAnagram("cold", "clod");
        ret.ForEach(r => Console.WriteLine(r));
        return ret;
    }

    public static bool IsAnagram(this string a, string b)
    {
        //check the length are not same ? not Anagram
        if (a.Length != b.Length)
            return false;

        // check both the strings are same ? Angram
        if (a == b)
            return true;

        /* debugando - entendendo conteúdo da ultima linha
            var t = a.OrderBy(c => c).Select(c => c); //ordena alfabeticamente e depois compara
            Console.WriteLine(string.Join("", t ));
            var t2 = b.OrderBy(c => c).Select(c => c); //ordena alfabeticamente e depois compara
            Console.WriteLine(string.Join("", t2));
            var isSequenceEqual= t.SequenceEqual(t2);
            Console.WriteLine(isSequenceEqual);
        */
        /********************/

        // Sort the characters alphabetically and compare them to one another.
        return a.OrderBy(c => c).SequenceEqual(b.OrderBy(c => c));
    }

    }
}
