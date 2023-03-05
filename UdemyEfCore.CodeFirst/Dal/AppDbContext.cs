using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace UdemyEfCore.CodeFirst.Dal;

// Context class
public class AppDbContext: DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductFeature> ProductFeatures { get; set; }


    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Initializer.Build();
        optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon"));
    }

    // Fluent Api
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // One-to-Many RelationShip
        // modelBuilder.Entity<Category>().HasMany(x => x.Products).WithOne(x => x.Category)
        //     .HasForeignKey(x => x.CategoryId);

        // One-to-One RelationShip
        // modelBuilder.Entity<Product>().HasOne(x => x.ProductFeature).WithOne(x => x.Product)
        //     .HasForeignKey<ProductFeature>(x => x.Id);
        
        // Many-to-Many RelationShip
        // modelBuilder.Entity<Student>().HasMany(x => x.Teachers).WithMany(x => x.Students)
        //     .UsingEntity<Dictionary<string, object>>(
        //         "StudentTeacherManyToMany",
        //         x => x.HasOne<Teacher>().WithMany().HasForeignKey("Teacher_Id").HasConstraintName("FK__TeacherId"),
        //         x => x.HasOne<Student>().WithMany().HasForeignKey("Student_Id").HasConstraintName("FK__StudentId"));
        
        base.OnModelCreating(modelBuilder);
    }
}