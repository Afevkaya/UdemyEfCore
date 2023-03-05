// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using UdemyEfCore.CodeFirst;
using UdemyEfCore.CodeFirst.Dal;

Initializer.Build();

// #region Delete Behavior
//
// using (AppDbContext _context = new())
// {
//     // Cascade --> EfCore'un default davranışıdır. Parent data silindiği zaman child datalarda var ise silinir. Db de bulunan bir özelliktir.
//     // Category category = new()
//     // {
//     //     Name = "Kalemler",
//     //     Products = new()
//     //     {
//     //         new() {Name = "Kalem1", Price = 100, Stock = 100, Barcode = 123},
//     //         new() {Name = "Kalem2", Price = 200, Stock = 200, Barcode = 234},
//     //         new() {Name = "Kalem3", Price = 300, Stock = 300, Barcode = 345},
//     //     }
//     // };
//     //
//     // await _context.AddAsync(category);
//     // var category =  await _context.Categories.FirstAsync();
//     // _context.Categories.Remove(category);
//     
//     
//     // Restrict --> Child tablodaki datalar silinmeden parent tablodaki dataları silmez hata verir.
//     // Category category = new()
//     // {
//     //     Name = "Kalemler",
//     //     Products = new()
//     //     {
//     //         new() {Name = "Kalem1", Price = 100, Stock = 100, Barcode = 123},
//     //         new() {Name = "Kalem2", Price = 200, Stock = 200, Barcode = 234},
//     //         new() {Name = "Kalem3", Price = 300, Stock = 300, Barcode = 345},
//     //     }
//     // };
//     //
//     // await _context.AddAsync(category);
//     // var category =  await _context.Categories.FirstAsync();
//     // var products = await _context.Products.Where(p => p.CategoryId == category.Id).ToListAsync();
//     // _context.Products.RemoveRange(products);
//     // _context.Categories.Remove(category);
//     
//     
//     // NoAction --> EfCore hiç birşey yapmaz herşey db 'ye bırakılır.
//     
//     
//     
//     // SetNull --> EfCore parent tabloda data sildiğinde child tablodaki foreignkey sütünundaki dataları null'a set eder.
//     // Önemli olan foreignkey datası nullable olabilmesidir. Yoksa hata verir.
//     // Category category = new()
//     // {
//     //     Name = "Kalemler",
//     //     Products = new()
//     //     {
//     //         new() {Name = "Kalem1", Price = 100, Stock = 100, Barcode = 123},
//     //         new() {Name = "Kalem2", Price = 200, Stock = 200, Barcode = 234},
//     //         new() {Name = "Kalem3", Price = 300, Stock = 300, Barcode = 345},
//     //     }
//     // };
//     //
//     // await _context.AddAsync(category);
//     // var category =  await _context.Categories.FirstAsync();
//     // _context.Categories.Remove(category);
//     
//     
//     await _context.SaveChangesAsync();
//     Console.WriteLine("İşlem bitti");
// }
//
//
// #endregion



// #region Many-to-Many Added
//
// using (AppDbContext _context = new())
// {
//     // Student üzerinden teacher ekleme
//     // Student student = new() {Name = "Ahmet Öğrenci", Age = 23};
//     // student.Teachers.Add(new() {Name = "Ahmet Öğretmen1"});
//     // student.Teachers.Add(new() {Name = "Ahmet Öğretmen2"});
//     // await _context.AddAsync(student);
//
//     
//     
//     // Teacher üzerinden student ekleme
//     // Teacher teacher = new() {Name = "Hasan Öğretmen"};
//     // teacher.Students.AddRange(new List<Student>()
//     // {
//     //     new(){Name = "Hasan100", Age = 20},
//     //     new(){Name = "Hasan200",Age = 30},
//     // });
//     // await _context.Teachers.AddAsync(teacher);
//
//     
//     // Var olan Teacher datası üzerinden student ekleme
//     // var teacher = await _context.Teachers.FirstAsync(t => t.Name == "Hasan Öğretmen");
//     // teacher.Students.AddRange(new List<Student>()
//     // {
//     //     new() {Name = "Hasan300",Age = 23},
//     //     new(){Name = "Hasan400", Age = 24},
//     // });
//     
//     
//     await _context.SaveChangesAsync();
//     Console.WriteLine("Kaydedildi");
// }
//
//
// #endregion


// #region One-to-One Added
//
// using (AppDbContext _context = new())
// {
//     // Product --> Parent
//     // ProductFeature --> Child
//
//     
//     // Product üzerinden ProductFeature Ekleme
//     // var product = new Product
//     // {
//     //     Name = "Silgi2", Price = 200, Stock = 200, Barcode = 234, Category = new() {Name = "Sigiler"},
//     //     ProductFeature = new() {Color = "Darkblue", Height = 200, Width = 200}
//     // };
//     // await _context.AddAsync(product);
//
//     
//     // ProductFeature üzerinden Product ekleme
//     // var category = await _context.Categories.FirstAsync(c => c.Name == "Silgiler");
//     // var product = new Product {Name = "Silgi3", Price = 300, Stock = 300, Barcode = 345, Category = category};
//     // var productFeature = new ProductFeature() {Color = "Yellow", Width = 300, Height = 300, Product = product};
//     // await _context.ProductFeatures.AddAsync(productFeature);
//     
//     await _context.SaveChangesAsync();
//     Console.WriteLine("Kaydedildi");
// }
//
// #endregion


// #region One-to-Many Added
//
// using (var _context = new AppDbContext())
// {
//     var category = new Category() {Name = "Kalemler"};
//
//     // Product üzerinde category ekleme
//     // var product = new Product() {Name = "kalem1", Price = 100, Stock = 100, Barcode = 123, Category = category};
//     // _context.Products.Add(product); 
//
//     
//     // Catyegory üzerinden product ekleme
//     category.Products.Add(new() {Name = "kalem2", Price = 200, Stock = 200, Barcode = 123});
//     category.Products.Add(new() {Name = "kalem3", Price = 300, Stock = 300, Barcode = 123});
//     _context.Add(category);
//     await _context.SaveChangesAsync();
//     Console.WriteLine("Kaydedildi");
// }
//
// #endregion


// #region List
//
// using (var _context = new AppDbContext())
// {
//     var products = await _context.Products.ToListAsync();
//     
//     products.ForEach(p =>
//     {
//         Console.WriteLine($"{p.Id}: {p.Name} - {p.Price} - {p.Stock}");
//     });
// }
//
// #endregion

