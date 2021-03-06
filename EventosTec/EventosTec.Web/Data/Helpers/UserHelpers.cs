﻿using EventosTec.Web.Models.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventosTec.Web.Models;

namespace EventosTec.Web.Data.Helpers
{
    public class UserHelpers : IUserHelper
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;
        //-------------------------------------------------------------------------------
        public UserHelpers( UserManager<User> userManager, RoleManager<IdentityRole> roleManager,
            SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<SignInResult> LoginAsync(LoginViewModel model)
        {
            return await _signInManager.PasswordSignInAsync(
            model.Username,
            model.Password,
            model.RememberMe,
            false);
        }
        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }
        //-------------------------------------------------------------------------------
        public async Task<IdentityResult> AddUserAsync(User user, string Password)
        {
            return await _userManager.CreateAsync(user, Password);

        }
        //-------------------------------------------------------------------------------
        public async Task AddUserToRoleAsync(User user, string roleName)
        {
            await _userManager.AddToRoleAsync(user, roleName);
        }
        //-------------------------------------------------------------------------------
        public async Task CheckRoleAsync(string roleName)
        {
            var roleExists = await _roleManager.RoleExistsAsync(roleName);
            if (!roleExists)
            {
                await _roleManager.CreateAsync(new IdentityRole
                {
                    Name = roleName
                });
            }
        }
       
        //-------------------------------------------------------------------------------
        public async Task<User> GetUserByEMailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            return user;
        }
        //-------------------------------------------------------------------------------
        public async Task<bool> IsUserInRoleAsync(User user, string roleName)
        {
            return await _userManager.IsInRoleAsync(user, roleName);
        }
    }
}
