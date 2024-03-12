using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample;

public class CalculateSalary : File
{
    public CalculateSalary(IGenerateFile genFile) : base(genFile)
    {
    }
    public void ProcessEmployeeSalary(Employee employee)
    {
        employee.TotalSalary = employee.BaseSalary + employee.BonusSalary;
        Console.WriteLine($"{employee.Nome} total salary: {employee.TotalSalary}");

        generateFile.GenerateFile(employee );
    }
}
