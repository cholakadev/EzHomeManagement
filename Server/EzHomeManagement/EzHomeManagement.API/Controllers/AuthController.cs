namespace EzHomeManagement.API.Controllers
{
    using EzHomeManagement.Business.Abstraction;
    using EzHomeManagement.Business.Models.Auth.Entrance;
    using EzHomeManagement.Business.Models.Auth.User;
    using FluentResult;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            this._authService = authService;
        }

        [HttpPost]
        [Route("RegisterEntrance")]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> RegisterEntrance([FromBody] RegisterEntranceModel entrance)
            => this._authService.RegisterEntrance(entrance).ToActionResultAsync(this);

        [HttpPost]
        [Route("RegisterUser")]
        [ProducesResponseType(typeof(Result<UserModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> RegisterUser([FromBody] RegisterUserModel user)
            => this._authService.RegisterUser(user).ToActionResultAsync(this);

    }
}
