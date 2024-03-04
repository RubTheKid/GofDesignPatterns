using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Domain;

namespace Adapter;

public class FeeSystem
{
    public void CalculateFee(List<Student> studentList)
    {
        foreach (Student student in studentList)
        {
            var fee = student.MonthlyFee * 1.1M;

            Console.WriteLine($"Student: {student.Name} " + $", onthly fee: $ {fee}");
        }
    }
}
