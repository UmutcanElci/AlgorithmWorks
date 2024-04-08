namespace SortingAlgoritms;

public class InsertionSort
{
    public void Sort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int temp = array[i]; // Step 1
            int j = i - 1;// Other index to check

            while (j >= 0 && array[j] > temp) // We make sure the j is not zero and the array[j] is greater than temp
            {
                array[j +1] = array[j];//if the array[j] is greater than temp, we swap them
                j--;//we decrement j
            }
            array[j + 1] = temp;//Step 3 (If the previous element is not greater than the current element, we equalize the same indexes )
            
        }
    }
}

//Step 1: Start from index 1 and hold in a temporary variable
//Step 2: Compare the current element with the previous element
//Step 3: If the previous element is greater than the current element, swap them 