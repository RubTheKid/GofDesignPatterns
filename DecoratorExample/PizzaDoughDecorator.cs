using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample;

public class PizzaDoughDecorator : PizzaDecorator
{
    public PizzaDoughDecorator(IPizza pizza) : base(pizza)
    {
    }

    public override string Optionals()
    {
       var optional = base.Optionals();
        optional += "\r\n with special dough";
        return optional;
    }

    public override decimal Price()
    {
        var price = base.Price();
        price += 2.50M;

        return price;
    }
}
