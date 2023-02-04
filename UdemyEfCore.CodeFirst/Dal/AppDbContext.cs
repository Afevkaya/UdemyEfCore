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

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent API
        // modelBuilder.Entity<Product>().ToTable("ProductTBB", "productstbb");
        // modelBuilder.Entity<Product>().HasKey(p => p.Id);
        // modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired();
        // modelBuilder.Entity<Product>().Property(x => x.Name).HasMaxLength(100);
        modelBuilder.Entity<Product>().Property(x => x.Name).HasMaxLength(100).IsFixedLength();
        base.OnModelCreating(modelBuilder);
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