using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNetCore3API.ViewModels.BusinessSetup
{
    public class Step2ViewModel
    {
        public List<BusinessTypeViewModel> BusinessTypes { get; set; }
        public int SelectedBusinessTypeId { get; set; }
    }
}
