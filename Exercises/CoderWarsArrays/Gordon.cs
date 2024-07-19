public static class Gordon
{
  public static string Solution(string a)
  {
    char[] b = a.ToUpper().ToCharArray();
for (int i = 0; i < b.Length; i++)
{
    if (b[i] == 'A')
    {
        b[i] = '@';
    }
    if (b[i] == 'E' || b[i] == 'I' || b[i] == 'O' || b[i] == 'U')
    {
        b[i] = '*';
    }
}

string transformed = new string(b);
string[] words = transformed.Split(' ');
string result = string.Join("!!!! ", words) + "!!!!";
return result;

  }
}
