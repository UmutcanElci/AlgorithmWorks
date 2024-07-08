namespace ArraysExamples;

public class Question6
{
    // Wrıte a 2D array and print it 3x3
    public void Question()
    {
        int[][] arr = new int[3][]; // 3 rows
        arr[0] = new int[3] { 1, 2, 3 }; 
        arr[1] = new int[3] { 4, 5, 6 };
        arr[2] = new int[3] { 7, 8, 9 };
        foreach (int[] row in arr)// 3 rows
        {
            foreach (int element in row) // 3 columns
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++) 
            {
                Console.Write(arr[i][j] + " ");// Another way to print
            }
            Console.WriteLine();
        }
    }
}