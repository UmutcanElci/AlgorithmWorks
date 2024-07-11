using System.Collections.Generic;
public static class ReversedString
{
  public static string Solution(string str)
  {
    return string.Concat(str.Reverse());
    // return new string(str.ToArray().Reverse().ToArray());
  }
}
