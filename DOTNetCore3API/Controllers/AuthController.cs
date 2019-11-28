using AutoMapper;
using DOTNETCore3.Data.Abstract;
using DOTNETCore3.Model.Entities;
using DOTNetCore3API.ViewModels.Auth;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNetCore3API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public AuthController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("register")]
        public ActionResult<AuthData> Post([FromBody]RegisterViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var emailUniq = _userRepository.IsEmailUnique(model.Email);
            if (!emailUniq) return BadRequest(new { email = "user with this email already exists" });

            var user = _mapper.Map<User>(model);
            var business = _mapper.Map<Business>(model);
            business.BusinessOwner = new BusinessOwner()
            {
                User = user
            };

            var id = Guid.NewGuid().ToString();
            var user = new User
            {
                Id = id,
                Username = model.Username,
                Email = model.Email,
                Password = authService.HashPassword(model.Password)
            };
            userRepository.Add(user);
            userRepository.Commit();

            return authService.GetAuthData(id);
        }
    }
}
