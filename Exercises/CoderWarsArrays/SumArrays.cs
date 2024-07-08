namespace CoderWarsArrays;

public class SumArrays
{
    public  double SumArray(double[] array)
    {
        double sum = 0;
        if (array.Length == 0)
        {
            return 0;
        }else
        {
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
        }

        return sum;
    }
}