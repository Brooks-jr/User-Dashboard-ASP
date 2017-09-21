using Microsoft.EntityFrameworkCore;
 
namespace userDashboardASP.Models
{
    public class DashContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public DashContext(DbContextOptions<DashContext> options) : base(options) { }
        public DbSet<Person> User { get; set; }
    }
}
