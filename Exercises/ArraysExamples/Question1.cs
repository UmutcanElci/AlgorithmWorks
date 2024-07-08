namespace ArraysExamples;

public class Question1
{
    public void Question()
    {
        int[] arr; // Define an array
        int n; // Size of array
        Console.WriteLine("Enter the size of array");
        n = int.Parse(Console.ReadLine()); // Read size of array
        arr = new int[n]; // Create an array of size n
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Values:");
            arr[i] = int.Parse(Console.ReadLine()); // Giving values to array
        }

        for (int i = n-1; i >= 0; i--)// Printing array in reverse order
        {
            Console.Write($" {arr[i]} ");
        }
    }
}