using Microsoft.EntityFrameworkCore;
using CoderFirst.DataAccess.Model;

namespace CoderFirst.DataAccess
{

    public class BaseContext : DbContext
    {
         
        public BaseContext(DbContextOptions<BaseContext> options): base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseMySQL //Cannot find this method
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //using modelBuilder to map some relationships
        }

        public DbSet<Advertisment> Advertisment { get; set; }
    }
}
