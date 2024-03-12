using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample;

public class JsonGenerate : IGenerateFile
{
    public void GenerateFile(Employee employee)
    {
        //json generating logic
        Console.WriteLine( $"employee {employee.Nome} data generated in json ");
    }
}
