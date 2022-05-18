// The following libraries may be useful 

using System;
using System.Linq;
using System.Collections.Generic;

public class SumProb
{
	public static void Main(string[] args)
	{
		List<int[]> list = ThreeSum(new int[] {0,1,2,3,1,23,-23,232,-23,-0,-1});
		string print = "";
		foreach(int[] i in list)
			print += "{" + string.Join(", ", i) + "}";
		Console.WriteLine(print);
	}

	public static List<int[]> ThreeSum(int[] arr) 
	{
		List<int[]> list = new List<int[]>();

		for(int i = 0; i <= arr.Length-1; i++)
		{
			for(int j = i+1; j <= arr.Length; j++)
			{
				for(int k = j+1; k < arr.Length; k++)
				{
					if((arr[i] + arr[j] + arr[k]) == 0) 
						list.Add(new int[]{arr[i],arr[j],arr[k]});
				}
			}
		}

		if(list.Count() < 1) list.Add(new int[1]);
		for(int i = 0; i < list.Count(); i++)
		{
			for(int j = i + 1; j < list.Count(); j++)
			{
				if(list[i].SequenceEqual(list[j]))
					list.RemoveAt(i);
			}
		}
		return list;
	}
}
