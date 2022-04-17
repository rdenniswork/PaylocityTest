using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PayrollApp.BusinessLogic;
using static PayrollApp.WebApplication.Models.PayeBenefitCostModels;
using PayrollApp.Data;
using PayrollApp.Domain;
using System.Collections.Generic;
using System.Linq;

namespace PayrollApp.WebApplication.Controllers
{
    [ApiController]
    public class PayrollController : ControllerBase
    {
        private readonly ILogger<PayrollController> _logger;
        private readonly IPayrollBenefitCost _payrollBenefitCost;
        private static PayrollContext dbContext = new PayrollContext();

        public PayrollController(ILogger<PayrollController> logger, IPayrollBenefitCost payrollBenefitCost)
        {
            dbContext.Database.EnsureCreated();
            _logger = logger;
            _payrollBenefitCost = payrollBenefitCost;
        }

        [HttpPost]
        [Route("Payroll/CalculateBenefitCost")]
        public double CalculateBenefitCost([FromBody] PayeBenefitCostVM payeBenefitCostVM)
        {
            return _payrollBenefitCost.CalculateBenefitCost(payeBenefitCostVM.employee, payeBenefitCostVM.employeeDependents);
        }

        [HttpGet]
        [Route("Payroll/Employee/Get")]
        public List<PayrollApp.Domain.Employee> Get()
        {
            var employees = dbContext.Employee
                      .ToList();

            return employees;
        }
        [HttpPost]
        [Route("Payroll/Employee/Add")]
        public void Add([FromBody] PayeBenefitCostVM payeBenefitCostVM)
        {
            PayrollApp.Domain.Employee employee = new PayrollApp.Domain.Employee()
            {
                FirstName = payeBenefitCostVM.employee.FirstName,
                LastName = payeBenefitCostVM.employee.LastName
            };
            if (payeBenefitCostVM.employeeDependents != null && payeBenefitCostVM.employeeDependents.Count > 0)
            {
                foreach (EmployeeDependent empdep in payeBenefitCostVM.employeeDependents)
                {
                    employee.Dependants.Add(new Dependants()
                    {
                        FirstName = empdep.FirstName,
                        LastName = empdep.LastName
                    });
                };
            }
            dbContext.Employee.Add(employee);
            dbContext.SaveChanges();
        }

        [HttpPost]
        [Route("Payroll/Employee/Update")]
        public void Update([FromBody] PayeBenefitCostVM payeBenefitCostVM)
        {
            var employee = dbContext.Employee
                      .Where(w => w.Id == (int)payeBenefitCostVM.employee.Id)
                      .FirstOrDefault<PayrollApp.Domain.Employee>();

            employee.FirstName = payeBenefitCostVM.employee.FirstName;
            employee.LastName = payeBenefitCostVM.employee.LastName;

            if (payeBenefitCostVM.employeeDependents != null && payeBenefitCostVM.employeeDependents.Count > 0)
            {
                employee.Dependants.Clear();
                foreach (EmployeeDependent empdep in payeBenefitCostVM.employeeDependents)
                {
                    employee.Dependants.Add(new Dependants()
                    {
                        Id = (int)empdep.Id,
                        FirstName = empdep.FirstName,
                        LastName = empdep.LastName
                    });
                };
            }
            dbContext.Employee.Update(employee);
            dbContext.SaveChanges();
        }

        [HttpGet]
        [Route("Payroll/Employee/Delete/{employeeId}")]
        public void Delete(int employeeId)
        {
            var employee = dbContext.Employee
                      .Where(w => w.Id == employeeId)
                      .FirstOrDefault<PayrollApp.Domain.Employee>();

            dbContext.Employee.Remove(employee);
            dbContext.SaveChanges();
        }
    }
}
