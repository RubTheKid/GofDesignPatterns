using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaDecorator;

public class Espresso : ICoffee
{
    public string Description()
    {
        return "Espresso Coffee";
    }

    public decimal Price()
    {
        return 5.00M;
    }
}
