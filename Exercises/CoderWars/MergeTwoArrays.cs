using System;
using System.Collections.Generic;

public static class MergeTwoArrays
{
  public static int[] Solution(int[] arr1, int[] arr2)
  {
    int[] combined = new int[arr1.Length + arr2.Length];
        Array.Copy(arr1, 0, combined, 0, arr1.Length);
        Array.Copy(arr2, 0, combined, arr1.Length, arr2.Length);

        
        Array.Sort(combined);

        // Remove duplicates using a HashSet
        HashSet<int> uniqueSet = new HashSet<int>(combined);

        
        int[] result = uniqueSet.ToArray();
        Array.Sort(result);

        return result;
  }
}
