public static class ArrayPlusArray
{
  public static int Solution(int[] arr1,int[] arr2)
  {
     int sum = 0;

     int sum1 = 0;
     int sum2 = 0;
     for (int i = 0; i < arr1.Length; i++)
     {
         sum1 = arr1[i] + sum1;
     }
     for (int i = 0; i < arr2.Length; i++)
     {
         sum2 = arr2[i] + sum2;
     }

     sum = sum1 + sum2;

     return sum;
  }
}

