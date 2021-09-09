using CapstoneProject.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace CapstoneProject.Repository
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> CreateUser(SignUpUserModel signUpUser);

        public Task<SignInResult> SigInUserAsync(LogInModel loginUser);

        public Task LogOutUserAsync();
    }
}