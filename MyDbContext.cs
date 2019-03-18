using Microsoft.EntityFrameworkCore;

namespace EFCoreEnumToStringTest
{
    public class MyDbContext : DbContext
    {
        internal const string connectionString = "Host=localhost;Port=5432;Username=test;Password=test;Database=test";

        internal DbSet<MyEntity> MyEntities { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MyEntityConfiguration());
        }
    }
}
