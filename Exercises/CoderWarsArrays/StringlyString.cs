using System.Linq;

public static class StringlyString { 
  public static string Solution(int size) {
    return string.Concat(Enumerable.Range(0,size).Select(i => i % 2 == 0 ? "1" : "00"));
  }
}
