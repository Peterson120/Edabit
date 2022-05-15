using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(collatz(345));
    }

	public static int collatz(int num)
	{
		return col(num,0);
	}
	
	public static int col(int num, int depth)
	{
		if(num == 1)
		{
			return 1;
		}
		int result = num % 2 == 0 ? num/2:num*3+1;
		return col(num,depth+1);
	}
}