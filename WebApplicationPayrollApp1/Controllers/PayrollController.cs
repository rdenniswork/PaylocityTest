using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConsolePayrollApp1;

namespace WebApplicationPayrollApp1.Controllers
{
    [ApiController]
    public class PayrollController : ControllerBase
    {
        private readonly ILogger<PayrollController> _logger;
        private readonly IPayrollBenefitCost _payrollBenefitCost;

        public PayrollController(ILogger<PayrollController> logger, IPayrollBenefitCost payrollBenefitCost)
        {
            _logger = logger;
            _payrollBenefitCost = payrollBenefitCost;
        }

        [HttpPost]
        [Route("Payroll/CalculateBenefitCost")]
        public double CalculateBenefitCost(PayeBenefitCostVM payeBenefitCostVM)
        {
            return _payrollBenefitCost.CalculateBenefitCost(payeBenefitCostVM.employee, payeBenefitCostVM.employeeDependents);
        }

        public class PayeBenefitCostVM
        {
            public Employee employee { get; set; }
            public List<EmployeeDependent> employeeDependents { get; set; }
        }
    }
}
