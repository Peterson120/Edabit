using System;

public class Prefix
{
    public static void Main(string[] args)
    {
        Console.WriteLine(prefix("+ 5 4"));
        Console.WriteLine(prefix("* 12 2"));
        Console.WriteLine(prefix("+ -10 10"));
    }

    public static int prefix(string exp) 
	{
	  	string[] nums = exp.Split(' ');
		return operation(nums);
	}
	
	private static int operation(string[] list)
	{
		int result = 0;
		if(list[0] == "-")
		{
			result = Convert.ToInt32(list[1])-Convert.ToInt32(list[2]);
		}
		else if(list[0] == "*")
		{
			result = Convert.ToInt32(list[1])*Convert.ToInt32(list[2]);
		}
		else if(list[0] == "+")
		{
			result = Convert.ToInt32(list[1])+Convert.ToInt32(list[2]);
		}
		else if(list[0] == "/")
		{
			result = Convert.ToInt32(list[1])/Convert.ToInt32(list[2]);
		}
		return result;
	}
}