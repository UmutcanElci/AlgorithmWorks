namespace CoderWarsArrays;

public class ReversedWords
{
    public static string Solution(string str)
    {
        string[] str1 = str.Split(' ');
        string result = "";
        for(int i = str1.Length-1; i >= 0; i--){
            result += str1[i] + " ";
        }
        string trimResult = result.TrimEnd();
        return trimResult;
    }
}