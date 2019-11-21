using System;
using System.Collections.Generic;
using System.Text;

namespace DOTNETCore3.Model.Entities
{
    public class BusinessType : IEntityBase
    {
        public int Id { get; set; }
        public string BusinessSize { get; set; }
    }
}
