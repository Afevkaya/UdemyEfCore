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

    // SaveChanges metod override
    // public override int SaveChanges()
    // {
    //     // ChangeTracker property
    //     ChangeTracker.Entries().ToList().ForEach(e =>
    //     {
    //         if (e.Entity is Product p)
    //         {
    //             if (e.State == EntityState.Added)
    //             {
    //                 p.CreatedDate = DateTime.Now;
    //             }
    //             Console.WriteLine($"{p.Id}: {p.Name} - {p.Price} - {p.Stock}");
    //         }
    //     });
    //     return base.SaveChanges();
    // }
}