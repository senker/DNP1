using System;

namespace Exercise3
{
    public abstract class Employee
    {
        public String name{get;}
        public Employee(String name)
        {
            this.name=name;
        }
        public abstract double GetMonthlySalary();
    }
}