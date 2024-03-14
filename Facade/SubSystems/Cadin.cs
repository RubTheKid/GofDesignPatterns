using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.SubSystems
{
    public class Cadin 
    {
        public bool IsOnCadin(Client client)
        {
            Console.WriteLine($"Verifying if the client {client.Name} is registered on Cadin");
            return false;
        }
    }
}
