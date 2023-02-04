using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UdemyEfCore.CodeFirst.Dal;

// Product class
// Data Annotations Attribute
// [Table("ProductTB", Schema = "products")]
public class Product
{
    // [Key]
    // [Column(Order = 1)]
    public int Id { get; set; }
    // [Column("name2",Order = 1)]
    // [Required]
    // [MaxLength(100)]
    // [StringLength(100,MinimumLength = 100)]
    public string Name { get; set; }
    // [Column("name2",Order = 2,TypeName = "decimal(18,2)")]
    // [Required]
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string Barcode { get; set; }
}