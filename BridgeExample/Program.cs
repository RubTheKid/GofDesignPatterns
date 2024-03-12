namespace BridgeExample;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee
        {
            Nome="test",
            BaseSalary = 3000,
            BonusSalary = 1000
        };

        CalculateSalary calculate = new CalculateSalary(new XmlGenerate());

        calculate.ProcessEmployeeSalary(employee);

        employee.BonusSalary = 3000;

        calculate = new CalculateSalary(new JsonGenerate());

        calculate.ProcessEmployeeSalary(employee);

        Console.ReadKey();
    }

}