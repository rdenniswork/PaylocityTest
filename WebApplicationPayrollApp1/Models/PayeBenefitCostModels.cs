using System.Collections.Generic;
using ConsolePayrollApp1;

namespace WebApplicationPayrollApp1.Models
{
    public class PayeBenefitCostModels
    {
        public class PayeBenefitCostVM
        {
            public Employee employee { get; set; }
            public List<EmployeeDependent> employeeDependents { get; set; }
        }
    }
}
