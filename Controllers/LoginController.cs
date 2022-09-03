using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWT;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace googlesigninMVC.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public string Post(string credential)
        {
            //google sign in  後 解析ＪＷＴ
            var token = credential;
            var handler = new JsonWebTokenHandler();
            var jwtSecurityToken = handler.ReadJsonWebToken(token);
            string? email = jwtSecurityToken.Claims.Where(x => x.Type == "email").Select(x => x.Value).FirstOrDefault()?.ToString() ;
            return email;
        }
    }
}

