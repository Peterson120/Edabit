using System;
public class Palindrome 
{
    public static void Main(string[] args)
    {
        Console.WriteLine(PalindromeDescendant(97358817));
    }

    public static bool PalindromeDescendant(int num) 
    {
			string compare = Convert.ToString(num);
            if(compare.Length <= 3) return compare[0] == compare[compare.Length-1];

            bool pal = true;
			for(int i = 0; i < compare.Length/2; i++)
			{
				if(compare[i] != compare[compare.Length-i-1]) pal = false;
			}

            if(pal) return true;
			
			string[] list = new string[compare.Length/2+1];
			int index = 0;
			for(int i = 0; i < compare.Length-1; i+=2) 
            {
                list[index++] = Convert.ToString(Char.GetNumericValue(compare[i])+Char.GetNumericValue(compare[i+1]));
            }

			string result = string.Join(", ",list).Replace(", ","").Replace('[',' ').Replace(']',' ').Trim();
			return PalindromeDescendant(Convert.ToInt32(result));
    }
}