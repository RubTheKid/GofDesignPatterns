using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite;

public class EmployeeLeaf : WorkedHour
{
    public int Hours { get; set; }

    public override int GetWorkedHour()
    {
        Console.WriteLine($"the employee {Name} registered {Hours}  worked hours");

        return Hours;
    }
}
