namespace CoderWarsArrays;

public class ArraysInversion
{
    public int[] InvertValues (int[] input)
    {
	    if(input.Length == 0)
	    {
		    return input;
	    }else
	    {
		    for(int i = 0; i < input.Length;i++)
		    {
			    input[i] = input[i] * -1;
		    }
	    }
	    return input;
    }
}

