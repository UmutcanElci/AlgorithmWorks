namespace CoderWarsArrays;

public class WillYouMakeIt
{
    public static bool Solution(uint distanceToPump, uint mpg, uint fuelLeft)
    {
        return (fuelLeft*mpg)>=distanceToPump;
    }
}