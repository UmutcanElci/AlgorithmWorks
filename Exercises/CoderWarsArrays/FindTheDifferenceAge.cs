using System;
public static class FindTheDifferenceAge
{
    public static int[] Solution(int[] ages) 
    {
      int youngest = 0;
      int oldest = 0;
      int diff = 0;

      Array.Sort(ages);

      youngest = ages[0];
      oldest = ages[ages.Length - 1];

      diff = oldest - youngest;

      return new int[] {youngest,oldest,diff};

    }
}
