using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaDecorator
{
    public class ChocolateDecorator : OptionalDecorator
    {
        public ChocolateDecorator(ICoffee coffee) : base(coffee)
        {
            _optional = "add chocolate";
            _price = 3.00M;
        }
    }
}
