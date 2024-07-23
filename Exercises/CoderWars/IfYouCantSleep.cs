using System.Linq;
public static class IfYouCantSleep
{
   public static string Solution(int n)
   {
     return String.Join("",Enumerable.Range(1,n).Select(i => (i+" sheep...")));
   }
}

