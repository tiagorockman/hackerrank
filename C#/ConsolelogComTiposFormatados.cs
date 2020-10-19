using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAPP
{
    class ConsolelogComTiposFormatados
    {
        public static void MainConsole()
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            // Declare second integer, double, and String variables.
            int varInt;
            double varDouble;
            string varString;
            // Read and save an integer, double, and String to your variables.
            varInt = Convert.ToInt32(Console.ReadLine());
            varDouble = Convert.ToDouble(Console.ReadLine());
            varString = Console.ReadLine();
            varInt += i;
            varDouble += d;
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(varInt);
            // Print the sum of the double variables on a new line.
            Console.WriteLine(String.Format("{0:0.0}", varDouble));
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine($"{s}{varString}");
        }
    }
}
