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
        foreach (int[] row in arr)
        {
            foreach (int element in row)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}