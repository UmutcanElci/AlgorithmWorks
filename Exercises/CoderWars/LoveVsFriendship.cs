namespace CoderWarsArrays;

public class LoveVsFriendship
{
    public static int Solution(string str)
    {
        int letterValue=0;
        int result=0;

        foreach(char character in str){
            letterValue+=(int)character-96;

        }
        return letterValue;
    }
}