using Microsoft.AspNetCore.Mvc;
using SesaPay.Services.Admin.Interfaces;

namespace SesaPay.API.Controllers.AdminPanel
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IManagePrivilegeServices _managePrivilege;
        public AuthController(IManagePrivilegeServices managePrivilege)
        {
            _managePrivilege = managePrivilege;
        }
        [HttpGet]
        [Route("TestList")]
        public IActionResult TestList()
        {
           var data= _managePrivilege.GetList();
            return Ok(data);
        }
    }
}
