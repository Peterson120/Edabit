using System;
using System.Linq;
using System.Collections.Generic;
public class Capitals 
{
    public static void Main(string[] args)
    {
        int[] stuff = IndexOfCapitals("ASD");
        foreach(int i in stuff)
        {
            Console.Write(i);
        }
    }

    public static int[] IndexOfCapitals(string str) 
    {
        List<int> result = new List<int>();
		for(int i = 0; i < str.Length; i++)
		{
			if(Char.IsUpper(str[i]))
			{
				result.Add(i+1);
			}
		}
        int[] array = result.ToArray();
		return array;
    }
}