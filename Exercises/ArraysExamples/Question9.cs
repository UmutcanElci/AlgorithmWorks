namespace ArraysExamples;

public class Question9
{//Get only odd values from a give integer array
    public void Question()
    {
        int[] arr = { 1, 4, 7, 23, 5, 2, 12, 56, 33, 7, 22, 106, 71 };

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
               Console.Write(arr[i] + "  "); 
            }
        }
    }
}