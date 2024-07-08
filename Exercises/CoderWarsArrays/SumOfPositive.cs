namespace CoderWarsArrays;

public class SumOfPositive
{
    public static int PositiveSum (int[] arr)
    {
	    int sum = 0;
	    if(arr.Length == 0)
	    {
		    return 0;
	    }else
	    {
		for(int i = 0; i < arr.Length; i++)
		{
			if(arr[i] > 0)
			{
				sum += arr[i];
			}
		}
	    }

	    return sum;
    }
}

