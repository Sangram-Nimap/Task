using Crud30_06_25.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud30_06_25.Data
{
    public class AppDbConnection:DbContext
    {
        public AppDbConnection(DbContextOptions<AppDbConnection> options) : base(options) { }

       public DbSet<Employee>  Employees { get; set; }
    }
}
