using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Shared.Entities;
public class Product : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    [Range(1, 10000)]
    public decimal ListPrice { get; set; }
    [Range(1, 10000)]
    public decimal Price { get; set; }
    [Range(1, 10000)]
    public decimal Price50 { get; set; }
    [Range(1, 10000)]
    public decimal Price100 { get; set; }
    public byte[]? Image { get; set; } = null!;
    public Guid CategoryId { get; set; }
    public Category Category { get; set; } = null!;
    public int CoverTypeId { get; set; }
    public CoverType CoverType { get; set; } = null!;
}