using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNetCore3API.ViewModels.BusinessSetup
{
    public class BusinessSetupStepsViewModel
    {
        public Step1ViewModel Step1 { get; set; }
        public int BusinessId { get; set; }
        public int UserId { get; set; }
    }
}
