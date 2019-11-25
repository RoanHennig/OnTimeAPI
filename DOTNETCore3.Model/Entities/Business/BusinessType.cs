using System;
using System.Collections.Generic;
using System.Text;

namespace DOTNETCore3.Model.Entities
{
    public class BusinessType : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public BusinessCategory BusinessCategory { get; set; }
    }
}
