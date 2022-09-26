using ECommerce.Shared.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Shared.Configurations;
public class ProductConfiguration : BaseConfiguration<Product>
{
    public override void Configure(EntityTypeBuilder<Product> builder)
    {
        base.Configure(builder);
        builder.Property(x => x.Author).IsRequired().HasMaxLength(1000);
    }
}