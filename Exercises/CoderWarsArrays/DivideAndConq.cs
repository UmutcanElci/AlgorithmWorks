public static class DivideAndConq
{
  public static int Solution(Object[] objArray)
  {
     int strValues = 0;
        int intValues = 0;

        foreach (var item in objArray)
        {
            if (item is int)
            {
                intValues += (int)item;
            }
            else if (item is string)
            {
                if (int.TryParse((string)item, out int parsedValue))
                {
                    strValues += parsedValue;
                }
            }
        }

        return intValues - strValues;
  }
}
