using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.SubSystems
{
    public class CreditLimit
    {
        public bool HasCreditLimit(Client client, double value)
        {
            Console.WriteLine($"Verifying client {client.Name} credit limit");

            if (value > 20000.00)
                return false;
            else
                return true;
        }
    }
}
