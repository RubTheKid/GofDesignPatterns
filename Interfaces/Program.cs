namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        var registerOnConsole = new RegisterOc(new RegisterOnConsole());

        registerOnConsole.Register("console register");

        var registerFile = new RegisterOc(new RegisterOnFile(@"d:/teste.txt"));

        registerFile.Register("File registered");

        Console.ReadLine();
    }


}