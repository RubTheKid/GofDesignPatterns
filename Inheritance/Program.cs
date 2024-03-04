namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        var account1 = new SavingsAccount();

        account1.Number = 1;
        account1.Balance = 10;
        account1.Interest = 0.10;

        account1.getBalance();

        Console.ReadLine();

    }


    class Account
    {
        public int Number { get; set; }
        public double Balance { get; set; }

        public double getBalance()
        {
            return Balance;
        }
    }

    //class SavingsAccount
    //{
    //    public int Number { get; set; }
    //    public double Balance { get; set; }
    //    public double Interest { get; set; }
    //}

    class SavingsAccount : Account
    {
        //public int Number { get; set; }
        //public double Balance { get; set; }
        public double Interest { get; set; }
    }
}