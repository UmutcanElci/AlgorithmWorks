namespace CoderWarsArrays;

public class TwoToOne
{
    public static string Solution(string s1, string s2)
    {
        IEnumerable<char> combined = s1.Concat(s2);

      
        string result = new string(combined.Distinct().OrderBy(c => c).ToArray());

        return result;
    }
}