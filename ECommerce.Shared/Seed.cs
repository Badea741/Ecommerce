using ECommerce.Shared.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ECommerce.Shared;
public static class Seed
{
    public static ModelBuilder SeedData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = "7ded354e-6f24-4f5d-a8c6-5a1377cf9372",
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Id = "214cacc5-fc13-4167-8d9d-76fdf7cc4616",
                Name = "User",
                NormalizedName = "USER"
            }
        );
        modelBuilder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = "7ded354e-6f24-4f5d-a8c6-5a1377cf9371",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@ecommerce.com",
                NormalizedEmail = "ADMIN@ECOMMERCE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null!, "P@ssw0rd123"),
            });
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "7ded354e-6f24-4f5d-a8c6-5a1377cf9372",
                UserId = "7ded354e-6f24-4f5d-a8c6-5a1377cf9371"
            });
        return modelBuilder;
    }
}