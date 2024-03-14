using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaDecorator
{
    public class MilkDecorator : OptionalDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
            _optional = "add milk";
            _price = 2.00M;
        }
    }
}
