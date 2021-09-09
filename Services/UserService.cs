using CapstoneProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CapstoneProject.Service
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContext;

        public UserManager<ApplicationUser> _userManager;
    
        public UserService(IHttpContextAccessor httpContext, UserManager<ApplicationUser> userManager)
        {
            _httpContext = httpContext;
            _userManager = userManager;
        }
        public async Task<string> GetUserId()
        {
            ApplicationUser user = await _userManager.GetUserAsync(_httpContext.HttpContext.User);
            return user.Id;
        }

        public async Task<string> GetUserName()
        {
            ApplicationUser user = await _userManager.GetUserAsync(_httpContext.HttpContext.User);
            return user.FirstName+" "+user.LastName;
        }

        public bool IsAuthenticated()
        {
            return _httpContext.HttpContext.User.Identity.IsAuthenticated;
        }

        public async Task<IList<string>> GetRoles()
        {
            ApplicationUser user = await _userManager.GetUserAsync(_httpContext.HttpContext.User);
            return await _userManager.GetRolesAsync(user);
        }

        public async Task<bool> isAdministator()
        {
            ApplicationUser user = await _userManager.GetUserAsync(_httpContext.HttpContext.User);
            if(user != null)
                return await _userManager.IsInRoleAsync(user, "Admin");
            return false;
        }
    }
}
