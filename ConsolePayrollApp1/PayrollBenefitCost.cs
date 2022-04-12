using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePayrollApp1
{
    /// <summary>
    /// Payroll Benefit Cost Class.
    /// </summary>
    public class PayrollBenefitCost : IPayrollBenefitCost
    {
        /// <summary>
        /// Calculate Benefit Cost Method.
        /// </summary>
        public double CalculateBenefitCost(Employee employee, List<EmployeeDependent> employeeDependents)
        {
            PayeBenefitCost payeBenefitCost = new PayeBenefitCost();
            if (employee == null || (string.IsNullOrWhiteSpace(employee.FirstName)))
            { 
                return 0; 
            }

            bool discountFlag = false;
            double discountAmount = 0.1;
            double totalBenefitsCost = 0;
            double defaultPayPerPeriod = 2000;
            double defaultPayPeriod = 26;
            double benefitsCostPerEmployee = 1000;
            double benefitsCostPerDependent = 500;

            // Employee Calculation.
            discountFlag = false;
            if (employee.FirstName.StartsWith("A"))
            {
                discountFlag = true;
            }
            totalBenefitsCost += (benefitsCostPerEmployee) * (discountFlag ? (1 - discountAmount) : 1);

            // Employee Dependent Calculation.
            if (employeeDependents != null && employeeDependents.Count > 0)
            { 
                foreach (EmployeeDependent employeeDependent in employeeDependents)
                {
                    if (!string.IsNullOrWhiteSpace(employeeDependent.FirstName))
                    {
                        discountFlag = false;
                        if (employeeDependent.FirstName.StartsWith("A"))
                        {
                            discountFlag = true;
                        }
                        totalBenefitsCost += (benefitsCostPerDependent) * (discountFlag ? (1 - discountAmount) : 1);
                    }
                }
            }

            // Total Benefit Cost and Pay per Year.
            return totalBenefitsCost * defaultPayPeriod;
        }
    }
}
