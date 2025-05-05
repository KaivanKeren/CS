using CS.Model;
using Microsoft.EntityFrameworkCore;

namespace CS.AppContext;

public class MyDBContext : DbContext
{
    public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }

    public DbSet<User> users { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Name = "Ismail", Age = 17 }
        );
    }

}