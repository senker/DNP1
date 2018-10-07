using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee partTimeStudentEmployee = new PartTimeStudent("Ciocan",105, 50, 1998);
            Employee ciucalauEmployee = new PartTimeEmployee("Ciucalau",180,45);
            Employee patrocleEmployee = new FullTimeEmployee("Patrocle",9600);
            Company myCompany = new Company();
            myCompany.EmployNewEmployee(partTimeStudentEmployee);
            myCompany.EmployNewEmployee(ciucalauEmployee);
            myCompany.EmployNewEmployee(patrocleEmployee);
            Console.WriteLine($"Name: {partTimeStudentEmployee.name}, Salary: {partTimeStudentEmployee.GetMonthlySalary()}");
            Console.WriteLine($"Name: {ciucalauEmployee.name}, Salary: {ciucalauEmployee.GetMonthlySalary()}");
            Console.WriteLine($"Name: {patrocleEmployee.name}, Salary: {patrocleEmployee.GetMonthlySalary()}");
            Console.WriteLine($"Total company expenses: {myCompany.GetMonthlySalaryTotal()}");
        }
    }
}