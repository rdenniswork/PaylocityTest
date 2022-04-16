using Microsoft.EntityFrameworkCore;
using PayrollApp.Domain;

namespace PayrollApp.Data
{
    public class PayrollContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Dependants> Dependants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {           
            optionsBuilder.UseSqlServer("Data Source = .\\SQLEXPRESS; Initial Catalog = PayrollAppData; Integrated Security = True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
