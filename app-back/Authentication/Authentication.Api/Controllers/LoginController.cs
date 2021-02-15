using Authentication.Core.DTOs;
using Authentication.Core.Entities;
using Authentication.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _loginRepository;
        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        [HttpGet]
        public JsonResult Validate(UserDTO pUser)
        {
            Response r = _loginRepository.Check(pUser);                
            return new JsonResult(r);
        }
    }
}
