using System;

public static class CubeOfNumber
{
    public static double Cube(double num)
    {
        return num * num * num;
    }
    static void Main(string[] args)
    {
        double cubeResult = CubeOfNumber.Cube(3);
        Console.WriteLine($"Cube of 3: {cubeResult}");
    }
        
}