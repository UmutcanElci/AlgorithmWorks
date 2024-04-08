namespace SortingAlgoritms;

public class BubbleSort
{// O(n^2) 
    public static void Sort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j+1])//If left is greater than right
                {
                    int temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;//Swap
                }
            }
        }
    }
}