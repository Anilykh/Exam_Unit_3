using System;

public static class AreaOfCircle
{
    public static double Calculate(double radius)
    {
        const double pi = 3.14159265359;
        return pi * (radius * radius);
    }
    static void Main(string[] args)
    {
        double areaResult = AreaOfCircle.Calculate(4);
        Console.WriteLine($"Area of a circle with radius 4: {areaResult}");
    }
}







