using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaDecorator;

public interface ICoffee
{
    string Description();
    decimal Price();
}
