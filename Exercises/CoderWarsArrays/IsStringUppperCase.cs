using System;
using System.Linq;
public static class IsStringUpperCase
{
  public static bool Solution(this string text)
  {
    foreach (char item in text)
    {
        if (char.IsLower(item)) return false;
    }
    return true;
  }
}
