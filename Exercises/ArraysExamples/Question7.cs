using SortingAlgoritms;

namespace ArraysExamples;

public class Question7
{
    //Find the second largest number in an array
    public void Question()
    {
        int[] arr = { 3,42,71,5,35,82,101,2,45 };
        int size = arr.Length;//size = 9
        SelectionSort.Sort(arr);//[2, 3, 5, 35, 42, 45, 71, 82, 101]
        int secondLargest = 0;
        for (int i = 0; i < size; i++)
        {
            if (arr[size-1] != arr[size -2])//if the largest number is not the second largest
            {
                Console.WriteLine(arr[size - 2]);//print the second largest
                break;
            }
        }
        //This solution is true only if the array is sorted and the values in the array are unique
    }
}