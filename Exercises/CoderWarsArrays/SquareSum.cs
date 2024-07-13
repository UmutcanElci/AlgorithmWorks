public static class SquareSum
{
  public static int Solution(int[] numbers)
  {
    int sum = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i] * numbers[i];
        sum += numbers[i];
    }
    return sum;
  }
}
