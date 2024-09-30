namespace CoderWarsArrays;

public class SnailEnter
{
    public static bool Solution(double x, double y, double z)
    {
        y = (525600.0 * y) - (525600.0 * z );
  
        if(x <= y){
            return true;
        }
        return false;
    }
}