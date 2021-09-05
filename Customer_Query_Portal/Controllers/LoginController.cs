using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QueryPortalModel;
using QueryPortalServices;

namespace Customer_Query_Portal.Controllers
{
    public class LoginController : BaseApiController
    {
        private readonly ILoginServices _ILoginServices;

        public LoginController(ILoginServices ILoginServices)
        {
            this._ILoginServices = ILoginServices;
        }

        [HttpGet]
        public async Task<IActionResult> Test()
        {
            return Ok("testing");
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {            
            return Ok(await this._ILoginServices.VerifyLogin(login));
        }
    }
}