// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using UdemyEfCore.CodeFirst;
using UdemyEfCore.CodeFirst.Dal;

// Unchanged --> Db'deki data ile projedeki data'nın aynı olduğu durumlarda EfCore'un data için verdiği state.
// Added --> EfCore tarafından yeni eklenen data için verilen state.
// Modified --> EfCore tarafından herhangi bir property'si değiştirilen data için verilen state.
// Deleted --> EfCore tarafından silinen data için verilen state
// Detached --> EfCore tarafından tracke edilmeyen datalar için verdiği state
// AsNoTracking() metod --> Dbden gelen dataların memory'de track edilmememsini sağlar.
// ChangeTracker property --> EfCore tarafından track edilen datalar üzerinde state'i değiştirilmiş datalara erişmeyi sağlar
// ContextId --> Proje de birden fazla Context instance'ı(Context class örneği) varsa bunları birbirinden ayırmak için kullanılır. Unique değerdir.
// Update() metod --> EfCore tarafından track edilmeyen datalar üzerinde bir değişiklik yapıldığında db'ye datayı yansıtmak için kullanılır.
// First() metod --> Şarta uygun ilk datayı getirir. Yoksa exception fırlatır. Async metodu bulunmaktadır.
// FirstOrDefault() metod --> Şarta uygun ilk datayı getirir. Yoksa geriye null döner. Async metodu bulunmaktadır.
// Single() metod --> Şarta uygun datayı getirir. Birden fazla data var ise veya data yok ise hata fırlatır. Async metodu bulunmaktadır.
// SingletOrDefault() metod --> Şarta uygun datayı getirir. Birden fazla data var ise hata fırlatır. Şartın sağlanmadığı durumlarda default değer döner. Async metodu bulunmaktadır.
// Where() metod --> Şarta uygun bir liste döner. 
// Find() metod --> PrimaryKey alanına göre bir arama yapar ve tek bir data döner. Async metodu bulunmaktadır.
Initializer.Build();
using (var _context = new AppDbContext())
{
    // Find() metod
    // var product = _context.Products.Find(3);

    // Where() metod
    // var product = await _context.Products.Where(p => p.Id > 3 || p.Price > 500).ToListAsync();

    // SingleOrDefault() metod
    // var product = _context.Products.SingleOrDefault(x => x.Id == 100);
    // Single() metod
    // var product = _context.Products.Single(x => x.Id == 100);

    // FirstOrDefault() metod
    // var product = _context.Products.FirstOrDefault(x => x.Id == 100, new Product());
    // First() metod
    // var product = _context.Products.First(x => x.Id == 100);


    // ContextId
    // Console.WriteLine($"ContexId: {_context.ContextId}");


    // ChangeTracker property
    // var products = await _context.Products.ToListAsync();
    // _context.Products.Add(new() {Name = "Kalem 5", Price = 500, Stock = 500, Barcode = "567"});
    // _context.Products.Add(new() {Name = "Kalem 6", Price = 600, Stock = 600, Barcode = "678"});
    // _context.Products.Add(new() {Name = "Kalem 7", Price = 700, Stock = 700, Barcode = "789"});
    // _context.SaveChanges();


    // var products = await _context.Products.AsNoTracking().ToListAsync();
    // products.ForEach(p =>
    // {
    //     var state = _context.Entry(p).State;
    //     Console.WriteLine($"{p.Id}: {p.Name} - {p.Price} - {p.Stock} - state: {state}");
    // });


    // AsNoTracking metod
    // var products = await _context.Products.AsNoTracking().ToListAsync();
    // products.ForEach(p =>
    // {
    //     var state = _context.Entry(p).State;
    //     Console.WriteLine($"{p.Id}: {p.Name} - {p.Price} - {p.Stock} - state: {state}");
    // });


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
