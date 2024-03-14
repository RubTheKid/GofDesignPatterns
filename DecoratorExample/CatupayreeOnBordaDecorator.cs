using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample;

public class CatupayreeOnBordaDecorator : PizzaDecorator
{
    public CatupayreeOnBordaDecorator(IPizza pizza) : base(pizza)
    {
    }

    public override string Optionals()
    {
        var optional = base.Optionals();
        optional += "\r\n with stuffed pizza crust";
        return optional;
    }

    public override decimal Price()
    {
        var price = base.Price();
        price += 10.00M;
        return price;
    }
}
