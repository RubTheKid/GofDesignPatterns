using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass;

abstract class Form
{
    public double Area { get; set; }
    public double Perimeter { get; set; }
    public abstract void CalculatePerimeter();
    public abstract void CalculateArea();

    public string Description()
    {
        return "i'm the abstract form.";
    }
}
