using ECommerce.Shared.Entities;

namespace ECommerce.Shared.Dtos;
public class ProductDto : BaseDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public double ListPrice { get; set; }
    public double Price { get; set; }
    public double Price50 { get; set; }
    public double Price100 { get; set; }
    public byte[]? ImageUrl { get; set; } = null!;
}