public class Kaprekar {
	public static void main(String[] args)
	{
		System.out.println(kaprekar(1234));
	}

	public static int kaprekar(int num) {
		if(num == 6174) 
			return 0;
		String str = Integer.toString(num);
		char[] temp1 = str.toCharArray();
		char[] temp2 = str.toCharArray();
		quickSort(temp1,0,temp1.length-1,false);
		quickSort(temp2,0,temp2.length-1,true);
		str = Integer.toString(Integer.valueOf(new String(temp2)) - Integer.valueOf(new String(temp1)));
		for(int i = 0; i < 4-str.length(); i++)
			str += "0";
		return 1 + kaprekar(Integer.valueOf(str));
  	}

	private static void quickSort(char[] arr,int start,int end,boolean rev)
	{
		if(start < end)
		{
			int index = partition(arr, start, end, rev);
			quickSort(arr,start,index-1,rev);
			quickSort(arr,index+1,end,rev);
		}
	}
	
	private static int partition(char[] arr,int low,int high,boolean reverse)
	{
		int mid = low + (high-low)/2, index = low-1;
		char val = arr[mid];
		arr[mid] = arr[high];
		arr[high] = val;
		if(reverse)
		{
			for(int i = low; i < high; i++)
			{
				if(arr[i] > val)
				{
					index++;
					char temp = arr[i];
					arr[i] = arr[index];
					arr[index] = temp;
				}
			}
		}
		else
		{
			for(int i = low; i < high; i++)
			{
				if(arr[i] < val)
				{
					index++;
					char temp = arr[i];
					arr[i] = arr[index];
					arr[index] = temp;
				}
			}
		}
		arr[high] = arr[index+1];
		arr[index+1] = val;
		return index+1;
	}
}
