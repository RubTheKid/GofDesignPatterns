using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample;

public class Pizza : IPizza
{
    public string Name { get; set; }
    public Pizza(string name)
    {
        Name = name;
    }

    public string Optionals()
    {
        var optional = $"{Name} pizza";

        return optional;
    }

    public decimal Price()
    {
        var price = 10.00M;
        return price;
    }
}
