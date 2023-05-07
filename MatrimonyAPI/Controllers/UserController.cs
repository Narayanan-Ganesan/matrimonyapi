using MatrimonyAPI.Requests;
using MatrimonyAPI.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace MatrimonyAPI.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpPost]
        [Route("CreateUser")]
        public async Task<IActionResult> CreateUser(UserRequest userRequest)
        {
            var user =await _userService.CreateUserAsync(userRequest);
            return Created(new Uri($"{Request.Scheme}://{Request.Host.Value}/api/v1/User/GetUserbyID/{user.Data.MatrimonyID}"),user);
        }

        [HttpGet]
        [Route("GetUserbyID")]
        public async Task<IActionResult> GetUserbyID(string MatrimonyID)
        {
            var user = await _userService.GetUserbyIDAsync(MatrimonyID);
            if(user.Data == null) return NotFound(user);
            return Ok(user);
        }


    }
}
