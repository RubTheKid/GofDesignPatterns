using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces;

public class RegisterOc
{
    //implementation without interface
    //public void RegisterOnConsole(string message)
    //{
    //    Console.WriteLine(message + DateTime.Now);
    //}

    //public void RegisterOnFile(string path)
    //{
    //    //
    //}
    //public void RegisterOnDatabase(string connection, string message)
    //{
    //    //
    //}

    private readonly IRegisterOc _interface;

    public RegisterOc(IRegisterOc register)
    {
        _interface = register;
    }

    public void Register(string message)
    {
        _interface.RegisterInfo(message + DateTime.Now);
    }
}
