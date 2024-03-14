using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaDecorator;

public class Filtered : ICoffee
{
    public string Description()
    {
        return "Filtered coffee";
    }

    public decimal Price()
    {
        return 4.00M;
    }
}
