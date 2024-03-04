using System.Xml.Linq;

namespace DesignPatternsGof;

class Program
{
    static void Main(string[] args)
    {
        Client cliente = new Client("teste");
        cliente.Salutation();
        
        //cliente.nome = "teste";

        //Console.WriteLine(cliente.nome);
    }

    
}

