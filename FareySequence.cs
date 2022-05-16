// Its possible to solve using some or all of these librarys.

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class FareySequence
{
	public static void Main(string[] args)
	{
		string[] temp = Farey(Convert.ToInt32(Console.ReadLine()));
		printArray(temp);
	}

	private static void printArray(string[] arr) {Console.WriteLine(string.Join(", ",arr));}

	public static string[] Farey(int n)
	{
		List<string> list = new List<string>();
		list.Add("0/1");
		for(int i = n; i > 0; i--)
		{
			for(int j = 1; j < i; j++)
			{
				int gcf = GCF(j,i);
				list.Add((j/gcf)+"/"+(i/gcf));
			}
		}
		list.Add("1/1");
		string[] result = list.Distinct().ToArray();
		insertionSort(result);
		return result;
	}
	
	private static int GCF(int one, int two)
	{
		if(one%two==0)
			return two;
		return GCF(two,one%two);
	}

	private static void insertionSort(string[] arr)
	{
		for(int i = 0 ; i < arr.Length; i++)
		{
			string temp = arr[i];
			int loc = binarySearch(arr,i-1,temp);
			Array.ConstrainedCopy(arr,loc,arr,loc+1,i-loc);
			arr[loc] = temp;
		}
	}

	private static int binarySearch(string[] arr, int r, string key)
	{
		int l = 0, mid;
		string[] values = key.Split('/');

		while(l <= r)
		{
			mid = l + (r-l)/2;
			string[] temp = arr[mid].Split('/');
			int compare = Convert.ToInt32(values[0]) * Convert.ToInt32(temp[1]) - Convert.ToInt32(temp[0]) * Convert.ToInt32(values[1]);

			if(compare == 0) return mid;
			else if(compare > 0) l = mid + 1;
			else if(compare < 0) r = mid -1;
		}
		return l;
	}
}
