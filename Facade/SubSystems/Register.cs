using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.SubSystems
{
    public class Register
    {
        public void RegisterClient(Client client)
        {
            Console.WriteLine($"Client {client.Name} has no pendencies");
        }
    }
}
