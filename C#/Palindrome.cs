using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAPP
{
    class Palindrome
    {
        //racecar
        //yes
        public static void MainPalindrome()
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Solution obj = new Solution();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter()) // compara o ultimo caratere com o primeiro e vai removendo ambos
                {                                                 // se algum for diferente não é palindrome
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }

    public  class Solution
    {
        //Write your code here
        List<char> charStack = new List<char>();
        List<char> charQueue = new List<char>();

       internal void enqueueCharacter(char ch)
        {
            charQueue.Add(ch);
            // Console.WriteLine("enqueueCharacter : {0}", string.Join(", ", charQueue));
        }

         internal char popCharacter()
        {
            char returnChar = charStack[charStack.Count - 1]; //pega ultimo caractere
            // Console.WriteLine("returnChar: {0}", returnChar);
            charStack.RemoveAt(charStack.Count - 1); //remove da lista
            // Console.WriteLine("popCharacter : {0}", string.Join(", ",charStack));
            return returnChar;
        }

        internal char dequeueCharacter()
        {
            char returnChar = charQueue[0]; //pega primeiro caractere
            //  Console.WriteLine("returnChar: {0}", returnChar);
            charQueue.RemoveAt(0); //remove primeiro caractere
            // Console.WriteLine("dequeueCharacter : {0}", string.Join(", ", charQueue));
            return returnChar;
        }

        internal  void pushCharacter(char ch)
        {
            charStack.Add(ch);
            // Console.WriteLine("pushCharacter : {0}", string.Join(", ", charStack));
        }
    }
}
