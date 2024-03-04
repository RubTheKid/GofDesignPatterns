using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Domain;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal MonthlyFee { get; set; }

    public Student(int id, string name, decimal monthlyFee)
    {
        Id = id;
        Name = name;
        MonthlyFee = monthlyFee;
    }
}
