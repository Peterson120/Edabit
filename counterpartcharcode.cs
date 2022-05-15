using System.Text;
using System.Security.AccessControl;
using System;
public class CharCounterpart
{
    public static void Main(string[] args)
    {
        Console.Write(CounterpartCharCode('a'));
    }

    public static int CounterpartCharCode(char symbol) 
    {
			if(Char.IsLetter(symbol))
			{
				if(Char.IsUpper(symbol))
				{
					char lowered = Char.ToLower(symbol);
					return Convert.ToChar(lowered);
				}
				else
				{
                    char upper = Char.ToUpper(symbol);
					return Convert.ToChar(upper);
				}
			}
			return Convert.ToChar(symbol);
    }
}