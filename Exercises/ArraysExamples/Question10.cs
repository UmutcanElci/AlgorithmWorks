namespace ArraysExamples;

public class Question10
{//Remove the duplicated elements from an integer array
    public void Question()
    {
        object[] arr = { 25, "Tom", 1, false,System.DateTime.Now,5,"Mel",25,"Tom",false};//Define the array(Object help us to add any type of values in it)
        //Print the array
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Removed duplicates from the array \n");
        
        object[] resultArr = arr.Distinct().ToArray();//Distinct help us to remove the duplicated elements from array
        foreach (var item in resultArr)
        {
            Console.WriteLine(item);
        }
        
    }
}