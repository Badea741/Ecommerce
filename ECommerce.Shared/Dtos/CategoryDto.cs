namespace ECommerce.Shared.Dtos;
public class CategoryDto : BaseDto
{
    public string Name { get; set; } = string.Empty;
    public int DisplayOrder { get; set; }
    public DateTime CreateDateTime { get; set; } = DateTime.Now;
}