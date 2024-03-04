using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism;

class Figure
{
    //virtual allow the methot to be overwritten in the derivated class
    public virtual void Draw()
    {
        Console.WriteLine("drawing some stuff");
    }
}
