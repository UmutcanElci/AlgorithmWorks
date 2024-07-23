public static class PartialWordSearch
{
  public static string[] Solution(string query, string[] seq)
  {
    // Index of if founds the query returns 0 if it's not -1
    var result = seq.Where(s => s.IndexOf(query,StringComparison.OrdinalIgnoreCase)>= 0).ToArray();
     if (result.Length == 0)
        {
            return new string[] { "Empty" };
        } 
    return result;
  }
}
