using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicGenerator;

public class GraphicAdapter : IGraphic
{
    public string Title { get; set; }
    public List<string> Xvalues { get; set ; }
    public List<int> Yvalues { get ; set ; }

    public void GenerateGraphic(string Title, List<string> x, List<int> y)
    {
        GraphicGeneratorTwo graphic = new GraphicGeneratorTwo();
        graphic.DrawGraphic(Title, x, y);
    }
}
