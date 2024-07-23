public static class WellOfIdeas
{
  public static string Solution(string[] x)
  {
    int goodCount = 0;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] == "good")
        {
            goodCount++;
        }
    }

    if (goodCount>=1 && goodCount<=2)
    {
        return "Publish!";
    }else if (goodCount > 2)
    {
        return "I smell a series!";
    }else
    {
      return "Fail!";
    }
  }
}
