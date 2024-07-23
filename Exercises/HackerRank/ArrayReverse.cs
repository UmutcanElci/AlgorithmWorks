namespace HackerRankDSArrays;

public class ArrayReverse
{// Hacker rank problem https://www.hackerrank.com/challenges/arrays-ds/problem
    public static List<int> reverseArray(List<int> a)
    {//Using the properties of List
        if (a.Count == 0)// Checking if list is empty
        {
            return a;
        }
        else
        {
            a.Reverse();// Reversing the list
            
        }

        return a;// Returning the list
    }
}