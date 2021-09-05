using QueryPortalModel;
using QueryPortalRepositories;
using System.Threading.Tasks;

namespace QueryPortalServices
{
    public class LoginServices : ILoginServices
    {
        private readonly ILoginRepository _ILoginRepository;

        public LoginServices(ILoginRepository ILoginRepository)
        {
            this._ILoginRepository = ILoginRepository;
        }

        public async Task<bool> VerifyLogin(Login login)
        {
            return await this._ILoginRepository.VerifyLogin(login);
        }

    }
}
