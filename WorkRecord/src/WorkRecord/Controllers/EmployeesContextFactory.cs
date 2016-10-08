using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore.Extensions;

namespace WorkRecord.Controllers
{
    public class EmployeesContextFactory
    {
        public static EmployeesContext Create(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EmployeesContext>();
            optionsBuilder.UseMySQL(connectionString);

            //Ensure database creation
            var context = new EmployeesContext(optionsBuilder.Options);
            context.Database.EnsureCreated();

            return context;
        }
    }
}
