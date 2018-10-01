using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ciucalauEmployee = new PartTimeEmployee("Ciucalau",180,45);
            Employee patrocleEmployee = new FullTimeEmployee("Patrocle",9600);
            Company myCompany = new Company();
            myCompany.EmployNewEmployee(ciucalauEmployee);
            myCompany.EmployNewEmployee(patrocleEmployee);
            Console.WriteLine($"Name: {ciucalauEmployee.name}, Salary: {ciucalauEmployee.GetMonthlySalary()}");
            Console.WriteLine($"Name: {patrocleEmployee.name}, Salary: {patrocleEmployee.GetMonthlySalary()}");
            Console.WriteLine($"Total company expenses: {myCompany.GetMonthlySalaryTotal()}");
        }
    }
}
//using a delegate while creating a log class
//public delegate void MessageLogger(String message);
//public static MessageLogger  HandleMEssage;
//
//