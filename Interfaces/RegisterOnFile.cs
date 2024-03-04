using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces;

public class RegisterOnFile : IRegisterOc
{
    private readonly string _pathFileName;

    public RegisterOnFile(string pathFileName)
    {
        _pathFileName = pathFileName;
    }

    public void RegisterInfo(string message)
    {
        Log(message);
    }

    private void Log(string message)
    {
        using (var streamWriter = new StreamWriter(_pathFileName, true))
        {
            streamWriter.WriteLine(message);
        }
    }
}
