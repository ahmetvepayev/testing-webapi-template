using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Tester> Testers { get; set; }

    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }
}