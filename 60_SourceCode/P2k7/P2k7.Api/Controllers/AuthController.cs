using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using P2k7.Api.Service;
using P2k7.Entities;

namespace P2k7.Api.Controllers
{
    public class AuthController : BaseController
    {
        private readonly AuthService service;

        public AuthController(AuthService service )
        {
            this.service = service;
        }
        [Route("api/Auth/AuthenticateAndGenerateToken")]
        public async Task<IHttpActionResult> AuthenticateAndGenerateToken(LoginEntity model)
        {

                var user = service.Login(model);
                if (user != null)
                {
                    string token = service.GetToken(user.UserName);
                    return Ok(token);
                }
                else
                {
                    return Unauthorized();
                }

        }
    }
}
