using System;
using System.Collections.Generic;

namespace DOTNETCore3.Model.Entities
{
    public class Business : IEntityBase
    {
        public Business()
        {
            Staff = new List<Staff>();
            OperatingHours = new List<BusinessOperatingHours>();
        }

        public int Id { get; set; }
        public int BusinessOwnerId { get; set; }
        public BusinessOwner BusinessOwner { get; set; }
        public string BusinessName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Zipcode { get; set; }
        public List<BusinessOperatingHours> OperatingHours { get; set; }
        public BusinessType Type { get; set; }
        public List<Staff> Staff { get; set; }
        public bool SubscriptionActive { get; set; }
        public DateTime TrialExpiry { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastEditTime { get; set; }
    }
}
