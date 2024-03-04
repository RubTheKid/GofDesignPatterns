namespace Adapter;

class Program
{
    static void Main(string[] args)
    {
        //no cant do it babydoll. the systems are incompatible. for that we will use the adapter pattern.
        //guess why? adapt. lol

        //var studentArray = SchoolSystem.GetStudentsFeesList();
        //var feeSystem = new FeeSystem();

        //feeSystem.CalculateFee(studentList);

        //for that we will use the interface with the method to calculate the fees.

        var studentsArray = SchoolSystem.GetStudentsFeesList();

        ICalculateFee calculate = new StudentsAdapter();

        calculate.ProcessCalculateFee(studentsArray);

        Console.ReadKey();
    }
}