using Microsoft.AspNetCore.Mvc;
using Taskify.Core.Interfaces;
using Taskify.Application.DTOs;
using Taskify.Core.Entities;

namespace Taskify.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserControllers : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserControllers(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userRepository.GetAllAsync();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser (CreateUserDto createUserDto)
        {
            var existingUser = await _userRepository.GetEmailAsync(createUserDto.Email);
            if(existingUser != null)
            {
                return BadRequest("Email already exists");
            }

            var user = new User 
            {
                Username = createUserDto.Username,
                Email = createUserDto.Email,
                PasswordHash = createUserDto.Password,
                Level = 1,
                Experience = 0
            };
            await _userRepository.CreateAsync(user);
            return Ok("User created successfully");
        }
    }
}