using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace UdemyEfCore.CodeFirst.Dal;

// Context class
public class AppDbContext: DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Initializer.Build();
        optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon"));
    }
}