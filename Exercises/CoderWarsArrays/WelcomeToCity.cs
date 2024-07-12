using System.Linq;
public static class WelcomeToCity
{
  public static string Solution(string[] name, string city, string state)
  {
    return "Hello, " +String.Join(" ",name) + $"! Welcome to {city}, {state}!";
  }
}
