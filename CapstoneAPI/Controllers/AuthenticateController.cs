using CapstoneAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapstoneAPI.Controllers
{
    [Route("api/Authenticate")]
    [ApiController]
    [EnableCors(PolicyName = "CapstoneProject")]
    public class AuthenticateController : ControllerBase
    {
        readonly CapstoneAPIDbContext db;
        readonly IAuthenticate auth;

        public AuthenticateController(CapstoneAPIDbContext db, IAuthenticate auth)
        {
            this.db = db;
            this.auth = auth;
        }

        [HttpPut]
        [Route("/api/Authenticate/UpdatePwd/{email}/{oldp}/{newp}")]
        public bool Updatepassword(string email, string oldp, string newp)
        {

            return auth.ChangePassword(email, oldp, newp);
        }

        [HttpGet]
        [Route("/api/Authenticate/Login/{email}/{pwd}")]
        public string Login(string email, string pwd)
        {
            return auth.Login(email, pwd);
        }

        [HttpPost]
        [Route("/api/Authenticate/NewRegister")]
        public bool NewRegister([FromBody] Register r)
        {
            return auth.NewRegister(r);
        }

        [HttpGet]
        [Route("/api/Authenticate/GetSecurityQuestion/{email}")]
        public string GetSecurityQuestion(string email)
        {
            return auth.GetSecurityQuestion(email);
        }

        [HttpPut]
        [Route("/api/Authenticate/ForgotPwd/{email}/{answer}/{newp}")]
        public bool Forgotpassword(string email, string answer, string newp)
        {
            return auth.ForgotPassword(email, answer, newp);
        }

        [HttpGet]
        [Route("/api/Authenticate/ShowUserInfo/{email}")]
        public Register ShowUserInfo(string email)
        {
            return auth.ShowUserInfo(email);
        }

        [HttpPut]
        [Route("/api/Authenticate/UpdateUserDetails/{email}")]
        public bool UpdateUserDetails(string email, [FromBody] Register r)
        {
            return auth.UpdateUserDetails(email, r);
        }
    }

}
