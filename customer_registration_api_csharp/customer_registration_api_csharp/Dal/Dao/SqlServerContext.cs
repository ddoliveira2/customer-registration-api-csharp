using customer_registration_api_csharp.Model.Model;
using Microsoft.EntityFrameworkCore;
namespace customer_registration_api_csharp.Dal.Dao
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
    }
}
