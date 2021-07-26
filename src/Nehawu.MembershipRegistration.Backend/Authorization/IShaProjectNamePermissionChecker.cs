using Shesha.Domain;
using System.Threading.Tasks;

namespace Nehawu.MembershipRegistration.Backend.Authorization
{
    /// <summary>
    /// ShaProjectName Permission checker
    /// </summary>
    public interface IShaProjectNamePermissionChecker
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        Task<bool> IsDataAdministrator(Person person);
    }
}
