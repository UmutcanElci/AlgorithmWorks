namespace CoderWarsArrays;

public class GeometryBasics2d
{
    public static double Solution(double a, double b)
    {
        double xPoint = ((a - b) * (a - b));
        double yPoint = ((a - b) * (a - b));
    
        double result = Math.Sqrt(Math.Abs(xPoint + yPoint));
    
        return result; 
    }
}