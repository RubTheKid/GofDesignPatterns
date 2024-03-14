using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaDecorator;

public abstract class OptionalDecorator : ICoffee
{
    protected ICoffee _coffee;
    protected string _optional = "Undefined";
    protected decimal _price = 0.00M;

    public OptionalDecorator(ICoffee coffee)
    {
       _coffee = coffee;
    }
    public string Description()
    {
        return _coffee.Description() + _optional;
    }

    public decimal Price()
    {
        return _coffee.Price() + _price;    
    }
}
