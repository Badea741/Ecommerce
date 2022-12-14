using AuthenticationServices.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace AuthenticationServices.Authentication
{
    public partial interface IAuthentication<TUser> where TUser : IdentityUser
    {
        Task<AuthenticationResults> RegisterAsync(TUser applicationUserDto, string password);
        Task<AuthenticationResults> GetTokenAsync(Credentials credentials);
        Task<AuthenticationResults> ForgotPasswordAsync(string username, string newPassword, string url = null!);
        Task<AuthenticationResults> ResetPasswordAsync(string username, string token, string newPassword);
        Task<AuthenticationResults> AddUserToRoleAsync(string username, string role);
        Task<AuthenticationResults> RemoveUserFromRoleAsync(string username, string role);
        List<TUser> GetAllUsers();
        Task<List<TUser>> GetUsersInRoleAsync(string role);

    }
}