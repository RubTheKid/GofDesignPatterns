namespace CafeteriaDecorator;

class Program
{
    static void Main(string[] args)
    {
        var drinks = new List<ICoffee>
        {
            new ChocolateDecorator(new Filtered()),
            new MilkDecorator(new Filtered()),
            new ChocolateDecorator(new MilkDecorator(new Espresso())),
        };

        var filteredChocolate = drinks.First();
        Console.WriteLine(filteredChocolate.Description());
        Console.WriteLine($"{filteredChocolate.Price()} \n");

        var filteredMilk = drinks.Skip(1).First();
        Console.WriteLine(filteredMilk.Description());
        Console.WriteLine($"{filteredMilk.Price()}\n");

        var espressoMilkChocolate = drinks.Skip(2).First();
        Console.WriteLine(espressoMilkChocolate.Description());
        Console.WriteLine($"{espressoMilkChocolate.Price()}\n");

        Console.ReadKey();
    }
}