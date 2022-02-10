
using System;
using System.Collections.Generic;
class Program
{
	public static String FindLongestSubstring(String str)
	{
		int i;
		int n = str.Length;
		int st = 0;       //начальная точка
		int currlen = 0;  //длина текущей подстроки
		int maxlen = 0;   //макс длина
		int start = 0;    //начальная страка, макс длинна подстраки

		Dictionary<char, int> pos = new Dictionary<char,int>();  //для хранения последнего появление каждого уже посещенного символа.
		pos.Add(str[0], 0);  //Последнее вхождение первого символа является индексом 0

		for (i = 1; i < n; i++)
		{

			if (!pos.ContainsKey(str[i]))   // Если этот символ отсутствует, то это первое появление этого символ, сохраните его.
			{
				pos.Add(str[i], i);
			}
			else
			{
				if (pos[str[i]] >= st) /* Если этот символ присутствуетв, то этот символ имеет предыдущее вхождение,проверить, 
				                         является ли это появление находится до или после начала точки текущей подстроки.*/
				{
					currlen = i - st; // найти длину текущей подстроки и обновить maxlen и начать соответственно.
					if (maxlen < currlen)
					{
						maxlen = currlen;
						start = st;
					}
					st = pos[str[i]] + 1; // Следующая подстрока будет начинаться после последнего появлениятекущего символа, чтобы избежать его повторения.
				}
				pos[str[i]] = i; // Обновление последнего вхождения текущего символа.
			}
		}
		if (maxlen < i - st)  // Сравнить длину последней подстроки с maxlen и обновить maxlen и start соответственно.
		{
			maxlen = i - st;
			start = st;
		}
		return str.Substring(start,maxlen);  // находится от str[start]до str[start+maxlen-1].
	}

	public static void Main(String[] args)
	{
		String str = "str";
		Console.Write(FindLongestSubstring(str));
	}
}


