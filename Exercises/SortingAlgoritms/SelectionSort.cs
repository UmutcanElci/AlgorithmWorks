namespace SortingAlgoritms;

public class SelectionSort
{//Selection sort algorithm 
    public static void Sort(int []arr)
    {
        int size = arr.Length;//Finding the size of the array
        for (int i = 0; i < size; i++)// First index
        {
            for (int j = i+1; j < size; j++)// Second index
            {
                if (arr[i] > arr[j])// Checking if the first index is greater than the second
                {
                    int temp = arr[i];// Swapping the two indexes
                    arr[i] = arr[j];
                    arr[j] = temp;
                    // Also wanted to add the shorter code here for readability (arr[i], arr[j]) = (arr[j], arr[i]); ==> this called deconstruction(It's a tuple)
                }
            }
        }
    }
}