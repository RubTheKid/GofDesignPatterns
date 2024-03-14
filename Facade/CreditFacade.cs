using Facade.SubSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class CreditFacade
    {
        private CreditLimit limit;
        private Serasa serasa;
        private Cadin cadin;
        private Register register;

        public CreditFacade()
        {
            limit = new CreditLimit();
            serasa = new Serasa();
            cadin = new Cadin();
            register = new Register();
        }


        public bool GrantLoan(Client client, double value)
        {
            Console.WriteLine($"Client {client.Name} is requesting a $ {value: C} loan. \n ");

            register.RegisterClient(client);
            bool grantLoan = true;

            if(serasa.IsOnSerasa(client))
            {
                Console.WriteLine("the client has serasa restriction");
                grantLoan = false;
            }
            else if (cadin.IsOnCadin(client))
            {
                Console.WriteLine("the client has cadin restriction");
                grantLoan = false;
            }
            else if (!limit.HasCreditLimit(client, value))
            {
                Console.WriteLine($"the client has inferior credit limit than {value:C}\n");
                grantLoan = false;
            }
            return grantLoan;
        }
    }
}
