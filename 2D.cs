using System;

public class TwoDArrays
{
    public static double[] FindLargest(double[][] values) 
    {
			double[] largest = new double[values.Length];
			for(int i = 0; i < values.Length; i++)
			{
				double currlargest = values[i][0];
				for(int j = 1; j < values.Length; j++)
				{
					if(values[i][j] > currlargest)
					{
						currlargest = values[i][j];
					}
				}
				largest[i] = currlargest;
			}
			return largest;
    }
}