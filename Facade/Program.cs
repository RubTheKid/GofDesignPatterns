using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreditFacade grantCreditFacade = new CreditFacade();

            Client client1 = new Client("Jarbas");

            bool result = grantCreditFacade.GrantLoan(client1, 19000.00);

            Console.WriteLine($"the client {client1.Name} loan was " + (result ? "Approved" : "Denied"));

            Console.ReadKey();
        }
    }
}
