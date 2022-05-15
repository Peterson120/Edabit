using System;

public class Bitmap
{
    public static void Main(string[] args)
    {
        Console.WriteLine(WhatsTheTime("1110010000111011110101100100010100101001000011101111010010010001000111101110001110111"));
    }

    public static string WhatsTheTime(string bitmap)
    {
        string result = "";
        string[] rowList = new string[5];
        for(int i = 0; i < 5; i++) rowList[i] = bitmap.Substring(i*17,17);

        string[] numList = {
            rowList[0].Substring(0,3) + rowList[1].Substring(0,3) + rowList[2].Substring(0,3) + rowList[3].Substring(0,3) + rowList[4].Substring(0,3),
            rowList[0].Substring(4,3) + rowList[1].Substring(4,3) + rowList[2].Substring(4,3) + rowList[3].Substring(4,3) + rowList[4].Substring(4,3),
            rowList[0].Substring(10,3) + rowList[1].Substring(10,3) + rowList[2].Substring(10,3) + rowList[3].Substring(10,3) + rowList[4].Substring(10,3),
            rowList[0].Substring(14) + rowList[1].Substring(14) + rowList[2].Substring(14) + rowList[3].Substring(14) + rowList[4].Substring(14)
        };
        for(int i = 0; i < numList.Length; i++)
        {
            if(i == 2) result += ":";
            if(isZero(numList[i])) result += "0";
            else if(isOne(numList[i])) result += "1";
            else if(isTwo(numList[i])) result += "2";
            else if(isThree(numList[i])) result += "3";
            else if(isFour(numList[i])) result += "4";
            else if(isFive(numList[i])) result += "5";
            else if(isSix(numList[i])) result += "6";
            else if(isSeven(numList[i])) result += "7";
            else if(isEight(numList[i])) result += "8";
            else if(isNine(numList[i])) result += "9";
        }
        return result;
    }

    public static bool isZero(string row)
    {
        return row == "111101101101111";
    }
    public static bool isOne(string row)
    {
        return row == "010110010010111";
    }
    public static bool isTwo(string row)
    {
        return row == "111001111100111";
    }
    public static bool isThree(string row)
    {
        return row == "111001111001111";
    }
    public static bool isFour(string row)
    {
        return row == "101101111001001";
    }
    public static bool isFive(string row)
    {
        return row == "111100111001111";
    }
    public static bool isSix(string row)
    {
        return row == "100100111101111";
    }
    public static bool isSeven(string row)
    {
        return row == "111001001001001";
    }
    public static bool isEight(string row)
    {
        return row == "111101111101111";
    }
    public static bool isNine(string row)
    {
        return row == "111101111001001";
    }
}
