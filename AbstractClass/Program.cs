namespace AbstractClass;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();

        Console.WriteLine(square.Description());

        Console.WriteLine("insert the square side in meters");

        square.Side = Convert.ToDouble(Console.ReadLine());

        square.CalculatePerimeter();
        square.CalculateArea();

        Console.WriteLine("area: " + square.Area + " m2");
        Console.WriteLine("perimeter " + square.Perimeter + " m");

        Console.ReadLine();
    }
}