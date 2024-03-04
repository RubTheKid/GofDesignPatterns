using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction;

public class EmailService
{
    //the method sendemail will call the private methods
    public void SendEmail()
    {
        Connect();
        Authentication();
        Console.WriteLine("sending email");
        Disconnect();
    }
    //public => private
    private void Connect()
    {
        //dosomething
    }
    //public => private
    private void Authentication()
    {
        //dosomething;
    }
    private void Disconnect()
    {
        //dosomething;
    }
}
