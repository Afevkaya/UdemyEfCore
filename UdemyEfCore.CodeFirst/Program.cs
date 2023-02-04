// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using UdemyEfCore.CodeFirst;
using UdemyEfCore.CodeFirst.Dal;

// Unchanged --> Db'deki data ile projedeki data'nın aynı olduğu durumlarda EfCore'un data için verdiği state.
// Added --> EfCore tarafından yeni eklenen data için verilen state.
// Modified --> EfCore tarafından herhangi bir property'si değiştirilen data için verilen state.
// Deleted --> EfCore tarafından silinen data için verilen state
// Detached --> EfCore tarafından tracke edilmeyen datalar için verdiği state


Initializer.Build();
using (var _context = new AppDbContext())
{
    // Detached
    // EfCore tarafından Detached olarak işaretlenen data üzerinde yapılan hiçbir değişiklik db ye yansıtılmaz.
    // var product = await _context.Products.FirstAsync();
    // Console.WriteLine($"ilk state: {_context.Entry(product).State}");
    // _context.Entry(product).State = EntityState.Detached;
    //
    // Console.WriteLine($"son state: {_context.Entry(product).State}");
    // product.Name = "Kalem 2000";
    // await _context.SaveChangesAsync();
    // Console.WriteLine($"state after savechanges: {_context.Entry(product).State}");

    // Deleted
    // var product = await _context.Products.FirstAsync();
    // Console.WriteLine($"ilk state: {_context.Entry(product).State}");
    // _context.Remove(product);
    //
    // Console.WriteLine($"son state: {_context.Entry(product).State}");
    // await _context.SaveChangesAsync();
    // Console.WriteLine($"state after savechanges: {_context.Entry(product).State}");

    // Updated
    // var product = await _context.Products.FirstAsync();
    // Console.WriteLine($"ilk state: {_context.Entry(product).State}");
    // product.Stock = 1000;
    //
    //
    // Console.WriteLine($"son state: {_context.Entry(product).State}");
    // await _context.SaveChangesAsync();
    // Console.WriteLine($"state after savechanges: {_context.Entry(product).State}");

    // Added
    // Product newProduct = new() {Name = "Kalem 4", Price = 400, Stock = 400, Barcode = "456"};
    // Console.WriteLine($"ilk state: {_context.Entry(newProduct).State}");
    //
    // await _context.AddAsync(newProduct);
    // Console.WriteLine($"son state: {_context.Entry(newProduct).State}");
    //
    // await _context.SaveChangesAsync();

    // var products = await _context.Products.ToListAsync();
    //
    // products.ForEach(p =>
    // {
    //     var state = _context.Entry(p).State;
    //     Console.WriteLine($"{p.Id}: {p.Name} - {p.Price} - {p.Stock} - state: {state}");
    // });
}
