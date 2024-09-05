namespace CoderWarsArrays;

public class TheWheatAndChessboard
{
    public static int Solution(long grains)
    {
        int cells = 0;
        if(grains == 0){
            return 0;
        }
      
        while(true){
            if(grains != 0){
                grains = grains / 2;
                cells++;
            }else{
                break;
            }
        
        }
        return cells;
    }
}