namespace DesignPatternsGof;

class Client
{
    //fields
    public string nome;
    //methods

    //ctor
    public Client(string nome)
    {
        this.nome = nome;
    }
    public void Salutation()
    {
        Console.WriteLine("howdy, my name is " + nome);
    }
}