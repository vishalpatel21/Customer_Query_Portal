using QueryPortalModel;
using System.Threading.Tasks;

namespace QueryPortalServices
{
    public interface ILoginServices
    {
       Task<bool> VerifyLogin(Login login);
    }
}
