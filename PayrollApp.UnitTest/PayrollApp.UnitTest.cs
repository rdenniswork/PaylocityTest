using NUnit.Framework;
using System.Collections.Generic;
using PayrollApp.BusinessLogic;

namespace PayrollApp.UnitTest
{
    public class UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Description("Test with No Employee and No Depemdants")]
        public void TestNoEmployeeNoDepemdants()
        {
            // Arrange.
            double ExpectedPayeBenefitCost = 0;
            PayrollBenefitCost payrollBenefitCost = new PayrollBenefitCost();

            // Act.
            double payeBenefitCost = payrollBenefitCost.CalculateBenefitCost(null, null);

            // Assert.
            Assert.AreEqual(payeBenefitCost, ExpectedPayeBenefitCost);
        }

        [Test]
        [Description("Test with No Employee and No Depemdants")]
        public void Test1EmployeeNoDepemdants()
        {
            // Arrange.
            double ExpectedPayeBenefitCost = 38.46;
            PayrollBenefitCost payrollBenefitCost = new PayrollBenefitCost();
            Employee employee = new Employee() { FirstName = "Test", LastName = "Test" };
            List<EmployeeDependent> employeeDependents = new List<EmployeeDependent>();

            // Act.
            double payeBenefitCost = payrollBenefitCost.CalculateBenefitCost(employee, employeeDependents);

            // Assert.
            Assert.AreEqual(payeBenefitCost, ExpectedPayeBenefitCost);
        }

        [Test]
        [Description("Test with 1 Employee and 2 Depemdants")]
        public void Test1Employee2Depemdants()
        {
            // Arrange.
            double ExpectedPayeBenefitCost = 76.92;
            PayrollBenefitCost payrollBenefitCost = new PayrollBenefitCost();
            Employee employee = new Employee() { FirstName = "Test", LastName = "Test" };
            List<EmployeeDependent> employeeDependents = new List<EmployeeDependent>();
            employeeDependents.Add(new EmployeeDependent() { FirstName = "Test1", LastName = "Test1" });
            employeeDependents.Add(new EmployeeDependent() { FirstName = "Test2", LastName = "Test2" });

            // Act.
            double payeBenefitCost = payrollBenefitCost.CalculateBenefitCost(employee, employeeDependents);

            // Assert.
            Assert.AreEqual(payeBenefitCost, ExpectedPayeBenefitCost);
        }

        [Test]
        [Description("Test with 1 Employee With A in Name and No Depemdants")]
        public void Test1EmployeeWithAinNameNoDepemdants()
        {
            // Arrange.
            double ExpectedPayeBenefitCost = 34.62;
            PayrollBenefitCost payrollBenefitCost = new PayrollBenefitCost();
            Employee employee = new Employee() { FirstName = "ATest", LastName = "Test" };
            List<EmployeeDependent> employeeDependents = new List<EmployeeDependent>();

            // Act.
            double payeBenefitCost = payrollBenefitCost.CalculateBenefitCost(employee, employeeDependents);

            // Assert.
            Assert.AreEqual(payeBenefitCost, ExpectedPayeBenefitCost);
        }

        [Test]
        [Description("Test with 1 Employee With A in Name and 2 Depemdants With A in Name")]
        public void Test1EmployeeWithAinName2DepemdantsWithAinName()
        {
            // Arrange.
            double ExpectedPayeBenefitCost = 69.23;
            PayrollBenefitCost payrollBenefitCost = new PayrollBenefitCost();
            Employee employee = new Employee() { FirstName = "ATest", LastName = "Test" };
            List<EmployeeDependent> employeeDependents = new List<EmployeeDependent>();
            employeeDependents.Add(new EmployeeDependent() { FirstName = "ATest1", LastName = "Test1" });
            employeeDependents.Add(new EmployeeDependent() { FirstName = "ATest2", LastName = "Test2" });

            // Act.
            double payeBenefitCost = payrollBenefitCost.CalculateBenefitCost(employee, employeeDependents);

            // Assert.
            Assert.AreEqual(payeBenefitCost, ExpectedPayeBenefitCost);
        }
    }
}