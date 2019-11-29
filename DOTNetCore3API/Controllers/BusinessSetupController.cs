using AutoMapper;
using DOTNETCore3.Data.Abstract;
using DOTNetCore3API.ViewModels.BusinessSetup;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DOTNetCore3API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class BusinessSetupController : Controller
    {
        private readonly IBusinessRepository _businessRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public BusinessSetupController(IBusinessRepository businessRepository,
                                       IUserRepository userRepository,
                                       IMapper mapper)
        {
            _businessRepository = businessRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpPost("save")]
        public ActionResult<BusinessSetupStepsViewModel> SaveSteps([FromBody]BusinessSetupStepsViewModel model)
        {
            var business = _businessRepository.GetSingle(x => x.Id == model.UserId);

            _mapper.Map(model.Step1, business);

            _businessRepository.Commit();

            return model;
        }
    }
}