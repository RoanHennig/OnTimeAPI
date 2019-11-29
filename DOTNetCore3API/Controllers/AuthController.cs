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
        private readonly IBusinessRepository _businessRepository;
        private readonly IMapper _mapper;
        public AuthController(IUserRepository userRepository,
                              IBusinessRepository businessRepository,
                              IMapper mapper)
        {
            _userRepository = userRepository;
            _businessRepository = businessRepository;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public ActionResult<AuthData> Post([FromBody]RegisterViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var emailUnique = _userRepository.IsEmailUnique(model.Email);
            if (!emailUnique) return BadRequest(new { email = "user with this email already exists" });

            var user = _mapper.Map<User>(model);
            var business = _mapper.Map<Business>(model);
            business.BusinessOwner = new BusinessOwner()
            {
                User = user
            };

            _userRepository.Add(user);
            _userRepository.Commit();

            _businessRepository.Add(business);
            _businessRepository.Commit();

            return new AuthData()
            {
                BusinessId = business.Id,
                UserId = user.Id
            };
        }
    }
}
