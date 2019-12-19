using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNetCore3API.ViewModels.BusinessSetup
{
    public class BusinessSetupStepsViewModel
    {
        public int BusinessId { get; set; }
        public string Auth0Id { get; set; }
        public Step1ViewModel Step1 { get; set; }
        public Step2ViewModel Step2 { get; set; }
    }
}
