using System;
public class GFG
{
	static int NO_OF_CHARS = 256;
	static int longestUniqueSubsttr(string str)
	{
		int n = str.Length;
		int res = 0; 

		int[] lastIndex = new int[NO_OF_CHARS];
		Array.Fill(lastIndex, -1);

		int i = 0;

		for (int j = 0; j < n; j++)
		{

			i = Math.Max(i, lastIndex[str[j]] + 1);

			res = Math.Max(res, j - i + 1);

			lastIndex[str[j]] = j;
		}
		return res;
	}

	static public void Main()
	{
		string str = "str";
		Console.WriteLine("The input string is " + str);
		int len = longestUniqueSubsttr(str);
		Console.WriteLine("The length of the longest non repeating character is " + len);
	}
}

