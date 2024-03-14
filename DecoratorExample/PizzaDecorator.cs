using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample;

public abstract class PizzaDecorator : IPizza
{
    protected readonly IPizza _pizza;

    protected PizzaDecorator(IPizza pizza)
    {
        _pizza = pizza;
    }

    public virtual string Optionals()
    {
        var optional = _pizza.Optionals();
        return optional;
    }

    public virtual decimal Price()
    {
        var price = _pizza.Price();
        return price;
    }
}
