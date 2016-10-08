using Microsoft.EntityFrameworkCore;
using WorkRecord.Models;

namespace WorkRecord.Controllers
{
    public class EmployeesContext : DbContext
    {
        public EmployeesContext(DbContextOptions<EmployeesContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
