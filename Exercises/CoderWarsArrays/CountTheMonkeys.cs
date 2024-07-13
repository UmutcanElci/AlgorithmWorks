public static class CountTheMonkeys
{
  public static int[] Solution(int n)
  {
    
    int[] arr = new int[n];

    for (int i = 0; i < n; i++)
    {
        arr[i] = i + 1;
    }

    return arr;
  }
}
