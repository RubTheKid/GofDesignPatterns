using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicGenerator;

public interface IGraphic
{
    string Title { get; set; }
    List<string> Xvalues { get; set; }
    List<int> Yvalues { get; set; }

    void GenerateGraphic(string Title, List<string> Xvalues, List<int> Yvalues);
}
