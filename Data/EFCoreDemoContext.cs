using Microsoft.EntityFrameworkCore;
namespace ConsoleApp4
{

    public class EFCoreDemoContext : DbContext
    {
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Travel> Travels { get; set; }
        public DbSet<Address> Address { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Driver>()
            //        .Ignore(b => b.Travels);

            base.OnModelCreating(modelBuilder);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Context;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
