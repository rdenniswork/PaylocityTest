using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePayrollApp1
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class EmployeeDependent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class PayeBenefitCost
    {
        public double TotalPayPerYear = 0;
        public double TotalBenefitCostPerYear = 0.0;
    }
}
