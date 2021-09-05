using QueryPortalModel;
using System.Threading.Tasks;

namespace QueryPortalRepositories
{
    public interface ILoginRepository
    {
        Task<bool> VerifyLogin(Login login);
    }
}
