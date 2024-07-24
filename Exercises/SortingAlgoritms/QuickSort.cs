using System.Collections.Concurrent;

namespace SortingAlgoritms;
/*
 * Choosing Pivot(Mostly last index)
 * Partitioning(If less then pivot go to left is not go to right)
 * Swap
 * Recursion
 */
public class QuickSort
{// I leave my comments for this specific array { 2, 8, 5, 3, 7 }
    public static void Sort(int[] array, int left, int right)
    {
        // Only process if there are elements to sort
        if (left < right)
        {
            
            /*
             * Partition the array and get the pivot index
             * This first action for split the array and
             * return the last position of the pivot
             */
            int pivotIndex = Partition(array, left, right);

            /*
             * Recursively sort elements before and after partition
             * We make a recursion for look for the left and right side
             */
            // Ordering Left side
            Sort(array, left, pivotIndex - 1);
            // Ordering Right side
            Sort(array, pivotIndex + 1, right);
        }
    }

    static int Partition(int[] array, int left, int right)
    {
        // Choose the pivot element(Mostly last selected)
        int pivot = array[right];
        // Second index for Swap (yes starts with -1 don't worry)
        int i = (left - 1);

        // Rearrange elements based on pivot
        for (int j = left; j < right; j++)
        {
            // If the pivot bigger we make sure the lower values in left
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
            /*
             * Here is the logic j is just to loop through the values
             * i is the helper to put the lower values to the left
             * when the pivot is not higher than the value we pass it to next
             * that mean we don't raise  the i value by one so next time the lower value
             * swap to the higher value of array
             * I courage you to use the debugger to see in action 
             */
        }
        // Move the pivot element to its correct position
        Swap(array, i + 1, right);
        //Return the index of the pivot element
        return i + 1;
    }

    static void Swap(int[] array, int a, int b)
    {
        (array[a], array[b]) = (array[b], array[a]);
    }
    /* Same thing
    int temp = array[a];
    array[a] = array[b];
    array[b] = temp;
     */
    
}