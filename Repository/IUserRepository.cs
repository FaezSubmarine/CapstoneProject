using CapstoneProject.Models;
using CapstoneProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneProject.Repository
{
    public interface IUserRepository
    {
        // crud operation on entity
        Task<ApplicationUser> GetUser(int id);

        List<ApplicationUser> GetUsers();

        Task<ApplicationUser> CreateUser(UserCreateViewModel user);

        ApplicationUser UpdateUser(ApplicationUser user);

        ApplicationUser DeleteUser(ApplicationUser user);

    }
}
