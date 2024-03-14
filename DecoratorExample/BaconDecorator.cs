using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample;

public class BaconDecorator : PizzaDecorator
{
    public BaconDecorator(IPizza pizza) : base(pizza)
    {
    }

    public override string Optionals()
    {
        var optional = base.Optionals();
        optional += "\r\n with extra bacon";
        return optional;
    }

    public override decimal Price()
    {
        var price = base.Price();
        price += 4.00M;
        return price;
    }
}
