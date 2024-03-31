// See https://aka.ms/new-console-template for more information

using SortingAlgoritms;

int[] arr = new int[5] { 7, 2, 1, 4, 5 };
SelectionSort.Sort(arr);

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(arr[i]);
}
