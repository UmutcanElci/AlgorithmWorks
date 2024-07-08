namespace ArraysExamples;

public class Question4
{
    // Merge two arrays of the same size sorted in ascending order

    public void Question()
    {
        int[] arr1 = { 9, 3, 5, 12 };
        int[] arr2 = { 2, 10, 3, 8 };
        int size = arr1.Length + arr2.Length;
        
        int[] arr3 = new int[size];

        for (int i = 0; i < arr1.Length; i++)
        {
            arr3[i] = arr1[i];
            arr3[i + arr1.Length] = arr2[i];
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = i+1; j < size; j++)
            {
                if (arr3[i] >= arr3[j])
                {
                    int temp = arr3[i];
                    arr3[i] = arr3[j];
                    arr3[j] = temp;
                }
            }
        }

        for (int i = 0; i < size; i++)
        {
            Console.Write($" {arr3[i]} ");
        }
    }
}