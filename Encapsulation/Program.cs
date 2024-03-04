namespace Encapsulation;

class Program
{
    static void Main(string[] args)
    {
        //Account Account1 = new Account();
        var account1 = new Account();

        account1.balance = 100;

        //Console.WriteLine(account1.balance);

        var account2 = new Account();
        //cannot assign because its private
        //account2.privatebalance = 100;

        //otherwise, can assign by attribute

        account2.PrivateBalance = -500;
        Console.WriteLine($"saldo {account2.PrivateBalance}");
    }
}