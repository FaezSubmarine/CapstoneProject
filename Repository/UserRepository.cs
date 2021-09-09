using CapstoneProject.Data;
using CapstoneProject.Models;
using CapstoneProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneProject.Repository
{
    public class UserRepository : IUserRepository
    {
        private RaceContext _dbContext;
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        public UserRepository(RaceContext dbContext, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<ApplicationUser> CreateUser(UserCreateViewModel user)
        {
            // copy the data into application user
             
             ApplicationUser newUser = new ApplicationUser(){
                 FirstName = user.FirstName,
                 LastName = user.LastName,
                 Email = user.Email,
                 UserName = user.Email
             };

            var result = await _userManager.CreateAsync(newUser, user.Password);
            if (result.Succeeded)
            {
               IdentityRole role = _roleManager.Roles.FirstOrDefault(e => e.Id == user.Role.ToString());
               var result1 = await _userManager.AddToRoleAsync(newUser, role.ToString());
            }
            return null;
        }

        public ApplicationUser DeleteUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public async Task<ApplicationUser> GetUser(int id)
        {
            return await _userManager.FindByIdAsync(id.ToString());
        }

        public List<ApplicationUser> GetUsers()
        {
            return _userManager.Users.ToList();

        }

        public ApplicationUser UpdateUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
    }
}
