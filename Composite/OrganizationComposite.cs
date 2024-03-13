using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite;

public class OrganizationComposite : WorkedHour
{
    protected List<WorkedHour> departments = new List<WorkedHour>();

    public override void Add(WorkedHour component)
    {
        base.Add(component);
    }
    public override int GetWorkedHour()
    {
        var workedHoursDepartment = 0;
        foreach(var department in departments)
        {
            workedHoursDepartment += department.GetWorkedHour();
        }

        Console.WriteLine($"{Name} registered a total of {workedHoursDepartment} worked hours" );
        return workedHoursDepartment;
    }
}
