//Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.

using System;
using System.Collections.Generic;

class program1
{
	public static void reverseWords(string str)
	{
		Stack<char> st = new Stack<char>();
		for (int i = 0; i < str.Length; ++i) // Пройдите заданную строку и вытолкните все символы в стек, пока не появится пробел.
		{
			if (str[i] != ' ')
			{
				st.Push(str[i]);
			}
			else // Когда мы видим пробел, мы печатаем содержимое стека.
			{
				while (st.Count > 0)
				{
					Console.Write(st.Pop());

				}
				Console.Write(" ");
			}
		}
		while (st.Count > 0) //Так как после последнего слова может не быть пробела после последнего слова.
		{
			Console.Write(st.Pop());
		}
	}

	public static void Main(string[] args)
	{
		string str = "sihT si na !elpmaxe";
		reverseWords(str);
	}
}
