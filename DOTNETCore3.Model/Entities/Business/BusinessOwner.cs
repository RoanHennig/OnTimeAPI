using System;
using System.Collections.Generic;
using System.Text;

namespace DOTNETCore3.Model.Entities
{
    public class BusinessOwner : IEntityBase
    {
        public int Id { get; set; }
        public Business Business { get; set; }
        public int BusinessId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
