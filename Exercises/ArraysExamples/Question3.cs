namespace ArraysExamples;

public class Question3
{
    // Count duplicate elements in an array
    
    public void Question()
    {
        int[] arr;// Define an array
        int n,count = 0;// Size of an array and count
        Console.WriteLine("Enter size of an array : ");
        n = int.Parse(Console.ReadLine()!);// Take input from user
        arr = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter element : ");
            arr[i] = int.Parse(Console.ReadLine()!);// Take input from user for array
        }
        
        for (int i = 0; i < n; i++)
        {
            for (int j = i+1; j < n; j++)
            {
                if (arr[i] == arr[j])// Checking for duplicate
                {
                    count++;// Incrementing count 
                }
            }
        }
        
        Console.WriteLine("Duplicate elements in an array are : " + count);
    }
}