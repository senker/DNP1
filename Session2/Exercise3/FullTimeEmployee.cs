using System;

namespace Exercise2
{
    class FullTimeEmployee:Employee
    {
        double monthlySalary{get; set;}
        public FullTimeEmployee(String name, double monthlySalary):base(name)
        {
            this.monthlySalary=monthlySalary;
        }
        public override double GetMonthlySalary()
        {
            return monthlySalary;
        }
    }
}