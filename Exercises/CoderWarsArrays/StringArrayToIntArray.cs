public static class StringArrayToIntArray
{
  public static double[] Solution(string[] stringArray)
  {
     return Array.ConvertAll(stringArray,Double.Parse);
  }
}
