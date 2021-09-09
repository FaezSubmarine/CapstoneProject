using System.Collections.Generic;
using System.Threading.Tasks;

namespace CapstoneProject.Service
{
    public interface IUserService
    {
        Task<string> GetUserId();
        Task<string> GetUserName();
        bool IsAuthenticated();
        Task<IList<string>> GetRoles();
        Task<bool> isAdministator();
    }
}