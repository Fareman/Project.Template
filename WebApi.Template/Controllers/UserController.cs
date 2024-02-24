namespace Template.WebApi.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Template.Abstractions.Services;
    using Template.Domain.Entities;

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(ILogger<UserController> logger,
                              IUserService userService,
                              IMapper mapper)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet("users")]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            _logger.LogInformation("Getting users.");
            var users = await _userService.GetUsersAsync();

            //_mapper.Map<>(users);

            return Ok(users);
        }

        //[HttpGet("users/{id}")]
        //public IActionResult GetUser([FromQuery] int id)
        //{
        //    _logger.LogInformation("Getting users.");

        //    return Ok();
        //}

        //[HttpPost("users")]
        //public IActionResult CreateUser([FromBody] UserDto user)
        //{
        //    return Created();
        //}

        //[HttpPut("users/{id}")]
        //public IActionResult EditUser([FromBody] UserDto user)
        //{
        //    return NoContent();
        //}

        //[HttpPatch("users/{id}")]
        //public IActionResult ChangeEmail([FromQuery] int id, [FromBody] string email)
        //{
        //    return NoContent();
        //}

        //[HttpDelete("users/{id}")]
        //public IActionResult DeleteUser([FromQuery] int id)
        //{
        //    return NoContent();
        //}
    }
}
