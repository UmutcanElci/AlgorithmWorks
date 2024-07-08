namespace ArraysExamples;

public class Question8
{//Adding two matrices of the same size
    public void Question()
    {
        int[][] arr1 = new int[2][];
        int[][] arr2 = new int[2][];
        int[][] arr3 = new int[2][];
        
        //Initializing
        for (int i = 0; i < 2; i++)
        {
            arr1[i] = new int[2];
            arr2[i] = new int[2];
            arr3[i] = new int[2];
        }
        Console.WriteLine("Enter the value of array 1");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("Enter the value of arr1[{0}][{1}]", i, j);
                arr1[i][j] = int.Parse(Console.ReadLine()!);
            }
        }
        Console.WriteLine("Enter the value of array 2");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("Enter the value of arr2[{0}][{1}]", i, j);
                arr2[i][j] = int.Parse(Console.ReadLine()!);
            }
        }

        

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                arr3[i][j] = arr1[i][j] + arr2[i][j];
                Console.Write(arr3[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
    
}