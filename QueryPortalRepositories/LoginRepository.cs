using QueryPortalModel;
using System;
using System.Threading.Tasks;

namespace QueryPortalRepositories
{
    public class LoginRepository : ILoginRepository
    {       
        public async Task<bool> VerifyLogin(Login login)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}
