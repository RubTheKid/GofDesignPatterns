using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.SubSystems
{
    public class Serasa
    {
        public bool IsOnSerasa(Client client)
        {
            Console.WriteLine($"Verifying if the client {client.Name} is registered on serasa");
            return false;
        }
    }
}
