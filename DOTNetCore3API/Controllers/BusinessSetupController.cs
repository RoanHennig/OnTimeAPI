using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        [HttpPost("save")]
        public string SaveSteps([FromBody]BusinessSetupStepsViewModel model)
        {


            return "Hello!";
        }
    }
}