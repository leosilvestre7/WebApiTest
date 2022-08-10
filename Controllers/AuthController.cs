using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApiTest.Data.Interfaces;
using WebApiTest.Dtos;
using WebApiTest.Models;
using WebApiTest.Services.Interfaces;

namespace WebApiTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repository;
        private readonly ItokenService _tokenService;
        private readonly IMapper _mapper;

        public AuthController(IAuthRepository repository, ItokenService tokenService, IMapper mapper)
        {
            _repository = repository;
            _tokenService = tokenService;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterDto userDto)
        {
            userDto.Email = userDto.Email.ToLower();
            if (await _repository.UserExist(userDto.Email))
                return BadRequest("Ya está registrado este correo");

            var newUser = _mapper.Map<User>(userDto);
            var createUser = await _repository.Register(newUser, userDto.Password);
            var resultUser = _mapper.Map<UserListDto>(createUser);
            return Ok(resultUser);
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDto userDto)
        {
            var userRepo = await _repository.Login(userDto.Email, userDto.Password);
            
            if (userRepo == null) 
                return Unauthorized();

            var userData = _mapper.Map<UserListDto>(userRepo);
            var token = _tokenService.CreateToken(userRepo);
            return Ok(new {
                token = token,
                user = userRepo
            });
        }   
    }
}
