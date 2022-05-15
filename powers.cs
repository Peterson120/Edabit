using System;

public class RecursivePower
{
    public static void Main(string[] args)
    {
        int bottom = Convert.ToInt32(Console.ReadLine());
        int exponent = Convert.ToInt32(Console.ReadLine());
        Console.Write(power(bottom,exponent));
    }

    private static int power(int bottom,int exponent)
    {
        if(exponent == 0) {return 1;}
        return bottom*power(bottom,exponent-1);
    }
}