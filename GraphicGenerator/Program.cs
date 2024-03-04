namespace GraphicGenerator;

class Program
{
    static void Main(string[] args)
    {
        //var graphic = new GraphicGenerator();
        //after the adapter...
        IGraphic graphic = new GraphicAdapter();


        graphic.Title = "Test";

        List<string> xvalues = new List<string>();
        xvalues.Add("seg");
        xvalues.Add("ter");

        List<int> yvalues = new List<int>();
        yvalues.Add(10);
        yvalues.Add(20);


        graphic.GenerateGraphic(graphic.Title, xvalues, yvalues);
        Console.ReadKey();
    }
}