using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // table name: Activities
        // properties are based on the Activity class
        public DbSet<Activity> Activities { get; set; }
    }
}