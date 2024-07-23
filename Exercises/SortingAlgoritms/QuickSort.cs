using System.Collections.Concurrent;

namespace SortingAlgoritms;
/*
 * Choosing Pivot(Mostly last index)
 * Partitioning(If less then pivot go to left is not go to right)
 * Swap
 * Recursion
 */
public class QuickSort
{
    public static void Sort(int[] array, int left, int right)
    {
        // Only process if there are elements to sort
        if (left < right)
        {
            // Partition the array and get the pivot index
            int pivotIndex = Partition(array, left, right);

            // Recursively sort elements before and after partition
            Sort(array, left, pivotIndex - 1);
            Sort(array, pivotIndex + 1, right);
        }
    }

    static int Partition(int[] array, int left, int right)
    {
        // Choose the pivot element
        int pivot = array[right];
        int i = (left - 1);

        // Rearrange elements based on pivot
        for (int j = left; j < right; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }
        // Place pivot in the correct position
        Swap(array, i + 1, right);
        return i + 1;
    }

    static void Swap(int[] array, int a, int b)
    {
        int temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }
    
}