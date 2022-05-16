using System;

public class NicoCipher
{
	private static int[] order;
	public static void Main(string[] args)
	{
		Console.WriteLine(Cipher("mubashirhassan","crazy"));
	}

    public static string Cipher(string message, string key) 
	{
		int numLoops = message.Length / key.Length;
		string result = "";
		order = new int[key.Length];
		analyze(key);
		if(message.Length % key.Length != 0)
		{
			numLoops++;
			for(int i = 0; i < message.Length % key.Length; i++)
				message += " ";
		}
		
		for(int i = 0; i < numLoops; i++)
		{
			string temp = message.Substring(i*key.Length,key.Length);
			result += reorder(temp);
		}

	 	return result;
	}	
		
	private static void analyze(string key)
	{
		for(int i = 0; i < key.Length; i++)
		{
			int num = 0;

			for(int j = 0; j < key.Length; j++)
			{
				if(key[j] < key[i])
					num++;
			}
			order[i] = num+1;
		}
	}

	private static string reorder(string message)
	{
		string result = "";
		for(int i = 1; i <= order.Length; i++)
		{
			for(int j = 0; j < order.Length; j++)
			{
				if(order[j] == i)
					result += message[j];
			}
		}
		return result;
	}
}
