namespace CoderWarsArrays;

public class WillThereBeSpace
{
    public static int Enough(int cap, int on, int wait)
    {
        return  cap >= on +wait ?  0 : - cap + on + wait ;
    }
}