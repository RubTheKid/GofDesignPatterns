using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample
{
    public class XmlGenerate : IGenerateFile
    {
        public void GenerateFile(Employee employee)
        {
            //xml generation logic
            Console.WriteLine($"employee {employee.Nome} data generated in xml");
        }
    }
}
