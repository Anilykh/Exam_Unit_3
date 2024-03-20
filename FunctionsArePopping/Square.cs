class Program
{
    static void randomNum()
    {
        Console.WriteLine("Type in a number");
        double input = Convert.ToDouble(Console.ReadLine());

        double squareAnwser = Square(input);

        Console.WriteLine($"Square of {input}: {squareAnwser}");
    }

    static double Square(double randomNum)
    {
        double result = randomNum * randomNum;
        return result;
    }

    static void Main (string[] args)
    {
        randomNum();
        Console.ReadLine();
    }
}