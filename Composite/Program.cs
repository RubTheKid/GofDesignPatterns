namespace Composite;

class Program
{
    static void Main(string[] args)
    { 
        OrganizationComposite organization = new OrganizationComposite { Name = "TestOrg" };

        OrganizationComposite department = new OrganizationComposite { Name = "TestDI" };

        department.Add(new EmployeeLeaf { Name = "John Amos", Hours = 10 });
        department.Add(new EmployeeLeaf { Name = "Amos Roses", Hours = 40 });

        OrganizationComposite rhDepartment = new OrganizationComposite { Name = "RH" };

        rhDepartment.Add(new EmployeeLeaf { Name = "Anna ", Hours=10 });

        organization.Add(rhDepartment);
        organization.Add(department);


        organization.GetWorkedHour();

        Console.ReadKey();
    }
}