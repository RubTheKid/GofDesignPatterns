using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation;

internal class Account
{
    public decimal balance { get; set; }

    private decimal privatebalance { get; set; }
    public decimal PrivateBalance { 
        get 
            {  return privatebalance; }
        set
        {
            if ( value < 0)
            {
                throw new ArgumentException("the balance can't be negative");
            }
            else
            {
                privatebalance = value;
            }
        }
    
    }
}
