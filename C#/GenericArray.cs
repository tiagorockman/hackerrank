using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAPP
{
    class GenericArray
    {
		/* INPUT
		 
		3 
		1
		2
		3

		2
		Hello
		World

		 * */

		/**
	*    Name: PrintArray
	*    Print each element of the generic array on a new line. Do not return anything.
	*    @param A generic array
	**/
		// Write your code here

		static void PrintArray<T>(T[] array)
		{
			foreach (T i in array)
				Console.WriteLine(i);
		}

		public static void MainGenericArray()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int[] intArray = new int[n];
			for (int i = 0; i < n; i++)
			{
				intArray[i] = Convert.ToInt32(Console.ReadLine());
			}

			n = Convert.ToInt32(Console.ReadLine());
			string[] stringArray = new string[n];
			for (int i = 0; i < n; i++)
			{
				stringArray[i] = Console.ReadLine();
			}

			PrintArray<Int32>(intArray);
			PrintArray<String>(stringArray);
		}
	}
}
