namespace UdemyEfCore.CodeFirst.Dal;


public class ProductFeature
{
    public int Id { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public string Color { get; set; }
    // Navigation Property
    public Product Product { get; set; }
}