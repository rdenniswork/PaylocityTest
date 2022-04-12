using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePayrollApp1
{
    public interface IPayrollBenefitCost
    {        
        public double CalculateBenefitCost(Employee employee, List<EmployeeDependent> employeeDependents);
    }
}
