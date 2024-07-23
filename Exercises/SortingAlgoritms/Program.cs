// See https://aka.ms/new-console-template for more information

using SortingAlgoritms;

int[] arr = new int[5] { 2, 8, 5, 3, 7 };
QuickSort.Sort(arr,0,arr.Length-1);

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(arr[i]);
}
