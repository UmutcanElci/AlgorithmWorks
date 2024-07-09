using System;
using System.Collections.Generic;
using System.Linq;

public static class SpeedCode2
{
  public static bool Solution(int[] a, int[] b)
  {
    var squares = a.Select(x => x * x);
    var cubes = b.Select(y => y * y * y);

    int sum1 = 0;
    int sum2 = 0;
    foreach (var square in squares)
    {
      sum1 += square;
    }

    foreach (var cubic in cubes)
    {
        sum2 += cubic;
    }

    return sum1 > sum2;
  }
}
