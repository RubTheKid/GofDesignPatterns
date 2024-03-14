namespace DecoratorExample;

class Program
{
    static void Main(string[] args)
    {
        IPizza mozzarellaPizza = new Pizza("Mozzarella");
        Console.WriteLine(mozzarellaPizza.Optionals());
        Console.WriteLine($"Price: ${mozzarellaPizza.Price()}");

        Console.WriteLine("press any key to apply decorator");
        Console.ReadKey();
        Console.WriteLine("applying decorator");

        IPizza specialDough = new PizzaDoughDecorator(mozzarellaPizza);
        IPizza baconDecorator = new BaconDecorator(specialDough);
        IPizza catupaDecorator = new CatupayreeOnBordaDecorator(baconDecorator);

        Console.WriteLine(catupaDecorator.Optionals());

        Console.WriteLine($"Total price: $ {catupaDecorator.Price()}\n");

        Console.ReadKey();
    }
}