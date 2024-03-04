using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism;

internal class Triangle : Figure
{
    //override the base class (was virtual)
    public override void Draw()
    {
        Console.WriteLine("drawing a triangle...");
    }
}
