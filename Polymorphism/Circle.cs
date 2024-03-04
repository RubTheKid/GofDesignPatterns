using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism;

class Circle : Figure
{
    //override the base class (was virtual)
    public override void Draw()
    {
        Console.WriteLine("drawing a circle");
    }
}
