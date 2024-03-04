using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter;

public class SchoolSystem
{
    public static string[,] GetStudentsFeesList()
    {
        string[,] studentsArray = new string[5, 4]
        {
            {"101","Maria","Arts", "1000" },
            {"102", "Pedro", "Engineering", "2000" },
            {"103", "Bianca", "Veterinary", "3000" },
            {"104","Pamela", "Arts", "900" },
            {"105", "Sergio", "Computing", "850" }
        };

        return studentsArray;
    }
}
