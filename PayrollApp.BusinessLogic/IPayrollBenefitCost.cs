using System.Collections.Generic;

namespace PayrollApp.BusinessLogic
{
    public interface IPayrollBenefitCost
    {        
        public double CalculateBenefitCost(Employee employee, List<EmployeeDependent> employeeDependents);
    }
}
