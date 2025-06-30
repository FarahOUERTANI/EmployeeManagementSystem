using System.Data.Entity;

namespace EmployeeManagementSystem.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("DefaultConnection") { }
        public DbSet<Employee> Employees { get; set; }
    }
}