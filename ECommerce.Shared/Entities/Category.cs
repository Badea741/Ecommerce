using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Shared.Entities;
public class Category : BaseEntity
{
    [Required]
    public string Name { get; set; } = string.Empty;
    [DisplayName("Display Order")]
    public int DisplayOrder { get; set; }
    public DateTime CreateDateTime { get; set; } = DateTime.Now;
}