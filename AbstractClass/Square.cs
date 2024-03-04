using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass;

class Square : Form
{
    public double Side { get; set; }
    public override void CalculateArea()
    {
        this.Area = Side * Side;
    }

    public override void CalculatePerimeter()
    {
        this.Perimeter = 4 * Side;
    }
}
