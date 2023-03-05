// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using UdemyEfCore.CodeFirst;
using UdemyEfCore.CodeFirst.Dal;

Initializer.Build();

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

