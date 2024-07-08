namespace ArraysExamples;

public class Question2
{
    //Copy the elements of one array into another array.

    public void Question()
    {
        int[] arr1 = { 2, 5, 7, 4, 2 }; // Define an array
        int[] arr2 = new int[arr1.Length]; // Defined an second array for copying

        for (int i = 0; i < arr1.Length; i++)
        {
            arr2[i] = arr1[i]; // Copying elements
        }

        for (int i = 0; i < arr1.Length; i++)
        {
            Console.WriteLine($"First array : {arr1[i]} ");
            Console.WriteLine($"Second array : {arr2[i]} ");
        }
    }
}
