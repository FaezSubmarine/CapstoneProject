using CapstoneProject.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneProject.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager; // DbContext
        private RoleManager<IdentityRole> _roleManager;

        public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager) 
        {
            _userManager = userManager; // deal with all user related tables 
            _signInManager = signInManager; // authentication will happen in signin manage
            _roleManager = roleManager;
        }

        public async Task<IdentityResult> CreateUser( SignUpUserModel signUpUser)
        {
            // add to db
            ApplicationUser user = new ApplicationUser()
            {
                Email = signUpUser.Email,
                UserName = signUpUser.Email,
                FirstName = signUpUser.FirstName,
                LastName = signUpUser.LastName
            };

            var result= await _userManager.CreateAsync(user, signUpUser.Password);
            var role = _roleManager.Roles.FirstOrDefault(e => e.Name == "User");
            var result1 = await _userManager.AddToRoleAsync(user, role.ToString());

            return result;
        }

        public async Task<SignInResult> SigInUserAsync(LogInModel loginUser)
        {
            return await _signInManager.PasswordSignInAsync(loginUser.Email, loginUser.Password, loginUser.RememberMe, false);
        }

        public async Task LogOutUserAsync()
        {
             await _signInManager.SignOutAsync(); // you are loging out 
        }

    }
}
