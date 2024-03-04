using Adapter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter;

public class StudentsAdapter : ICalculateFee
{
    private FeeSystem feeSystem = new FeeSystem();

    public void ProcessCalculateFee(string[,] studentsArray)
    {
        //list of students => list of object 'student'

        string Id = null;
        string Name = null;
        string MonthlyFee = null;

        List<Student> studentList = new List<Student>();

        ConvertArrayToList(studentsArray, Id, Name, MonthlyFee, studentList);

        //now sending to feesystem that receives a list
        feeSystem.CalculateFee(studentList);


    }

    private void ConvertArrayToList(string[,] studentsArray, string? Id, string? Name, string? MonthlyFee, List<Student> studentList)
    {
        for (int i = 0; i < studentsArray.GetLength(0); i++)
        {
            for(int j = 0; j < studentsArray.GetLength(1); j++)
            {
                if(j == 0)
                {
                    Id = studentsArray[i, j];
                }
                else if(j == 1)
                {
                    Name = studentsArray[i, j];
                }
                else
                {
                    MonthlyFee = studentsArray[i, j];
                }
            }

            //creating the list of object 'student'

            studentList.Add(new Student(Convert.ToInt32(Id), Name, Convert.ToDecimal(MonthlyFee)));
        }
    }
}
