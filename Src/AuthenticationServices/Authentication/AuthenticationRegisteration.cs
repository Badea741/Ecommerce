using System.IdentityModel.Tokens.Jwt;
using AuthenticationServices.Helpers;
using AuthenticationServices.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AuthenticationServices.Authentication
{
    public partial class Authentication<TUser> where TUser : IdentityUser
    {
        public virtual async Task<AuthenticationResults> RegisterAsync(TUser applicationUserDto, string password)
        {
            if (await _userManager.FindByEmailAsync(applicationUserDto.Email) != null)
                return new AuthenticationResults
                {
                    Message = "Email is already in use",
                };
            if (await _userManager.FindByNameAsync(applicationUserDto.UserName) != null)
                return new AuthenticationResults
                {
                    Message = "Username is already in use",
                };
            var user = _mapper.Map<TUser>(applicationUserDto);
            var result = await _userManager.CreateAsync(user, password);
            var errorMessages = result.Errors.Select(e => e.Description);
            if (!result.Succeeded)
                return new AuthenticationResults
                {
                    Message = String.Join(" , ", errorMessages),
                };
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            return new AuthenticationResults
            {
                IsSuccess = true,
                Message = "User created successfully",
                Token = "Email confirmation token : " + token,
                Username = user.UserName,
                Roles = new List<string>() { Roles.User },
            };
        }
        
        public async Task<AuthenticationResults> ConfirmEmailAsync(string username, string token)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
                return new AuthenticationResults
                {
                    Message = "User not found",
                };
            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (!result.Succeeded)
                return new AuthenticationResults
                {
                    Message = "Email confirmation failed",
                };

            await _userManager.AddToRoleAsync(user, Roles.User);

            return new AuthenticationResults
            {
                IsSuccess = true,
                Message = "Email confirmed successfully",
                Username = user.UserName,
                Roles = new List<string>() { Roles.User },
            };
        }
    }
}
