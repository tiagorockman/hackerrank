using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAPP
{
    class Dictionary
    {
        public static void MainDictionary()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("teste1", "Valor para teste1");
            dict.Add("teste2", "Valor para teste2");
            dict.Add("teste3", "Valor para teste3");

            var result = DictionaryToString(dict);
            Console.WriteLine(result);
        }

        private static string DictionaryToString(Dictionary <string, string> dictionary)
        {
            string dictionaryString = "{";
            foreach(KeyValuePair<string, string> keyValues in dictionary)
            {
                dictionaryString += keyValues.Key + ":" + keyValues.Value + ", ";
            }
            return dictionaryString.TrimEnd(',', ' ') + "}";
        }
    }
}
