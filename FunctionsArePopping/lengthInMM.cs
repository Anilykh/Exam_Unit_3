using System;

public static class LengthInMM
{
    public static double InchesToMM(double inches)
    {
        double mm = 0;
        double inchInMM = 0.1; 

        for (int i = 0; i < inches * 10; i++) 
        {
            mm += inchInMM;
        }

        return mm;
    }

     static void Main(string[] args)
    {
        double mmResult = LengthInMM.InchesToMM(2);
        Console.WriteLine($"Length of 2 inches in millimeters: {mmResult}mm");
    }
}

