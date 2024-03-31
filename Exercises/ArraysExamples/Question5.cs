namespace ArraysExamples;

public class Question5
{
    //Insert and additional value into an array (sorted array)
    public void Question()
    {
        int[] arr = new int[3];// Creating an array
        
        Console.WriteLine("Enter the 3 elements of array : ");
        for (int i = 0; i < arr.Length; i++)// Taking input from user
        {
            arr[i] = int.Parse(Console.ReadLine()!);
        }
        
        Array.Sort(arr);// Sorting the array
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" " + arr[i]);// Printing the array
        }
        
        
        Array.Resize(ref arr,arr.Length + 1);// Resizing the array
        Console.WriteLine("Input the value to be inserted");
        int value = int.Parse(Console.ReadLine()!);
        arr[arr.Length - 1] = value;// Inserting the additional value
        
        Array.Sort(arr);// Sorting the array
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" " + arr[i]);// Printing the array
        }

    }
}