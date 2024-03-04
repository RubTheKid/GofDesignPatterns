using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicGenerator;

public class GraphicGenerator : IGraphic
{
    public string Title { get; set; }
    public List<string> Xvalues { get; set; }
    public List<int> Yvalues { get; set; }

    public void GenerateGraphic(string title, List<string> x, List<int> y)
    {
        //insert logic here.............

        Console.WriteLine("\n << Graphic generator: " + "generating graphic >>");
    }
}
