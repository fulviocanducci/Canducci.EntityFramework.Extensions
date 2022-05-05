using Microsoft.EntityFrameworkCore;
namespace DataAccess
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext()
        {
        }

        public DbSet<People> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("database", c =>
            {                
            });
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<People>(c =>
           {
               c.HasKey(x => x.Id);
               c.Property(x => x.Id);
               c.Property(x => x.Name).IsRequired().HasMaxLength(100);
               c.Property(x => x.CreatedAt).IsRequired();
               c.Property(x => x.UpdateAt).IsRequired(false);
               c.Property(x => x.Active).IsRequired();
           });
        }
    }
}
