namespace MyLibrary;

public class MyAssembly
{
    public int X { get; set; }
    public int Y { get; set; }
    public MyAssembly(int x, int y)
    {
        X = x;
        Y = y;
    }
   public int Metod (int x, int y)
    {
        return x * y;
    }
    public static void MetodB(int x, int y)
    {
        Console.WriteLine($"Hello {x} {y} ");
    }

}