namespace CoderWarsArrays;

public class DoIGetBonus
{
    public static string bonus_time(int salary, bool bonus)
    {
        if(bonus == false)
        {
            return new string($"${salary.ToString()}");
        }else{
            return new string($"${(salary*10).ToString()}");
        }
    }
}