using ConsolePayrollApp1;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NUnitTestPayrollApp1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test0E0DAsync()
        {
            // Arrange.
            PayrollBenefitCost payrollBenefitCost = new PayrollBenefitCost();

            // Act.
            double payeBenefitCost = payrollBenefitCost.CalculateBenefitCost(null, null);

            // Assert.
            Assert.AreEqual(payeBenefitCost, 0);
        }

        [Test]
        public void Test1E0D()
        {
            // Arrange.
            PayrollBenefitCost payrollBenefitCost = new PayrollBenefitCost();
            Employee employee = new Employee() { FirstName = "Test", LastName = "Test" };
            List<EmployeeDependent> employeeDependents = new List<EmployeeDependent>();

            // Act.
            double payeBenefitCost = payrollBenefitCost.CalculateBenefitCost(employee, employeeDependents);

            // Assert.
            Assert.AreEqual(payeBenefitCost, 38.46);
        }

        [Test]
        public void Test1E2D()
        {
            // Arrange.
            PayrollBenefitCost payrollBenefitCost = new PayrollBenefitCost();
            Employee employee = new Employee() { FirstName = "Test", LastName = "Test" };
            List<EmployeeDependent> employeeDependents = new List<EmployeeDependent>();
            employeeDependents.Add(new EmployeeDependent() { FirstName = "Test1", LastName = "Test1" });
            employeeDependents.Add(new EmployeeDependent() { FirstName = "Test2", LastName = "Test2" });

            // Act.
            double payeBenefitCost = payrollBenefitCost.CalculateBenefitCost(employee, employeeDependents);

            // Assert.
            Assert.AreEqual(payeBenefitCost, 76.92);
        }

        [Test]
        public void Test1EWA0D()
        {
            // Arrange.
            PayrollBenefitCost payrollBenefitCost = new PayrollBenefitCost();
            Employee employee = new Employee() { FirstName = "ATest", LastName = "Test" };
            List<EmployeeDependent> employeeDependents = new List<EmployeeDependent>();

            // Act.
            double payeBenefitCost = payrollBenefitCost.CalculateBenefitCost(employee, employeeDependents);

            // Assert.
            Assert.AreEqual(payeBenefitCost, 34.62);
        }

        [Test]
        public void Test1EWA2DWA()
        {
            // Arrange.
            PayrollBenefitCost payrollBenefitCost = new PayrollBenefitCost();
            Employee employee = new Employee() { FirstName = "ATest", LastName = "Test" };
            List<EmployeeDependent> employeeDependents = new List<EmployeeDependent>();
            employeeDependents.Add(new EmployeeDependent() { FirstName = "ATest1", LastName = "Test1" });
            employeeDependents.Add(new EmployeeDependent() { FirstName = "ATest2", LastName = "Test2" });

            // Act.
            double payeBenefitCost = payrollBenefitCost.CalculateBenefitCost(employee, employeeDependents);

            // Assert.
            Assert.AreEqual(payeBenefitCost, 69.23);
        }
    }
}