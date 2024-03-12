using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample;

public class File
{

    protected IGenerateFile generateFile;
    public File(IGenerateFile genFile) 
    {
        this.generateFile = genFile;
    }

    public virtual void RegisterFile(Employee employee)
    {
        generateFile.GenerateFile(employee);
    }
}
