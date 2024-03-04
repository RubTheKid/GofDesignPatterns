namespace Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        var figures = new List<Figure>()
        {
            new Circle(),
            new Triangle(),
        };

        foreach(var fig in figures)
        {
            fig.Draw();
        }

        Console.ReadLine();
    }
}