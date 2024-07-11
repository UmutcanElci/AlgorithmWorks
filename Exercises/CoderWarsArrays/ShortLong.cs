public static class ShortLong
{
  public static string Solution(string a, string b)
  {
  /*
        if (a.Length <= b.Length)
        {
            return a + b + a;
        }
        else
        {
            return b + a + b;
        }
    */

    return (a.Length > b.Length) ? (b+a+b) : (a+b+a);

    }
}
