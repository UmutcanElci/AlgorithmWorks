using System.Linq;
using System.Runtime;
public static class Kata {
    public static int TotalPoints(string[] games) {
       int totalPoint = 0;

    foreach (var item in games)
    {
        string[] scores = item.Split(':');

        int x = int.Parse(scores[0]);
        int y = int.Parse(scores[1]);
        totalPoint += (x > y) ? 3 : (x == y) ? 1 : 0;
    }

    return totalPoint;
    }
}
