using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite;

//component
public abstract class WorkedHour
{

    public string Name { get; set; }

    public virtual void Add(WorkedHour component)
    {}
    //common functionality
    public abstract int GetWorkedHour();
}
