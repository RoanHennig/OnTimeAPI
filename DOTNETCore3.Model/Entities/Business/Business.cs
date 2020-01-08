using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOTNETCore3.Model.Entities
{
    public class Business : IEntityBase
    {
        public Business()
        {
            Staff = new List<Staff>();
            OperatingHours = new List<BusinessOperatingHours>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        public int BusinessOwnerId { get; set; }
        public BusinessOwner BusinessOwner { get; set; }
        [Required]
        [MaxLength(100)]
        public string BusinessName { get; set; }
        [MaxLength(16)]
        public string Phone { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(50)]
        public string Province { get; set; }
        [MaxLength(8)]
        public string Zipcode { get; set; }
        public BusinessCategory BusinessCategory { get; set; }
        public List<BusinessOperatingHours> OperatingHours { get; set; }
        public List<Staff> Staff { get; set; }
        public bool SubscriptionActive { get; set; }
        public DateTime TrialExpiry { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastEditTime { get; set; }
    }
}
