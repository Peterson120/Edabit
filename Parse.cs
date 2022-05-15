using System;
public class ArrayParse
{
    public static void Main(string[] args)
    {
        object[] arr = {1,2,"a",'b'};
        foreach(string i in ParseArray(arr))
        {
            Console.Write(i);
        }
    }

	public static string[] ParseArray (object[] arr)
	{
		string result = string.Join(",",arr).Replace('[',' ').Replace(']',' ').Trim();
		return result.Split(',');
	}
}