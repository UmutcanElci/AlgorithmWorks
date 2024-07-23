public static class StringRepeat
{
  public static string Solution(int n, string s)
  {
    return string.Concat(Enumerable.Repeat(s,n));
  }
}
