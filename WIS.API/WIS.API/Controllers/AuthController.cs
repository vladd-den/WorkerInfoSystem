using FastMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WIS.API.Models;
using WIS.BLL.Services.Interfaces.Interfaces;
using WIS.BLL.Services.Models.Models;

namespace WIS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService { get; set; }
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("SignIn")]
        public async Task<object> Login(SignInViewModel signInViewModel)
        {
            return await _authService.SignInAsync(TypeAdapter.Adapt<UserDTO>(signInViewModel));
        }

        [HttpPost]
        [Route("SignUp")]
        public async Task<object> SignUp(SignUpViewModel signUpViewModel)
        {
            return await _authService.SignUpAsync(TypeAdapter.Adapt<UserDTO>(signUpViewModel));
        }
    }
}
