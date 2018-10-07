using System;

namespace Exercise2
{
    class PartTimeEmployee:Employee
    {
        double hourlyWage{get; set;}
        int hoursPerMonth{get; set;}
        public PartTimeEmployee(String name, double hourlyWage, int hoursPerMonth):base(name)
        {
            this.hourlyWage=hourlyWage;
            this.hoursPerMonth=hoursPerMonth;
        }
        public override double GetMonthlySalary()
        {
            return (this.hourlyWage*this.hoursPerMonth);
        }
    }
}