using System.ComponentModel.DataAnnotations;

namespace ECommerce.Shared.Entities;
public class CoverType : BaseEntity
{

    [Required]
    [MaxLength(100)]
    [Display(Name = "cover type")]
    public string Name { get; set; } = string.Empty;
}