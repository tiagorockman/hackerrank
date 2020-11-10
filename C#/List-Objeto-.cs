using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAPP
{
    class List_Objeto_
    {
        private struct FrameworkData
        {
            public string Version;
            public string Level;
            public FrameworkData(string version, string level)
            {
                Version = version;
                Level = level;
            }

        }

        public static void MainListObject()
        {
            List<FrameworkData> frameworkDatas = new List<FrameworkData>();
            frameworkDatas.Add(new FrameworkData("1", "Leve1"));
            frameworkDatas.Add(new FrameworkData("2", "Level2"));
            Console.WriteLine(ObjetoToString(frameworkDatas));
        }

        private static string ObjetoToString(List<FrameworkData> frameworkDatas)
        {
            string result = String.Concat(frameworkDatas.Select(f => f.Level + " " + f.Version));
                    result = string.Join('\n', frameworkDatas.Select(f => f.Level + " " + f.Version));
            return result;
        }
    }
}
