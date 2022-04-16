namespace ConsolePayrollApp1
{
    public class Employee
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class EmployeeDependent
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class PayeBenefitCost
    {
        public double TotalPayPerYear = 0;
        public double TotalBenefitCostPerYear = 0.0;
    }
}
