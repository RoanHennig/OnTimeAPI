using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DOTNETCore3.Model.Entities
{
    public class BusinessOperatingHours : IEntityBase
    {
        public BusinessOperatingHours()
        {
            StaffOperatingHours = new List<StaffOperatingHours>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        public Business Business { get; set; }
        public int BusinessId { get; set; }
        [Required]
        public int DayOfTheWeek { get; set; }
        [Required]
        public DateTime OpeningTime { get; set; }
        [Required]
        public DateTime ClosingTime { get; set; }
        public List<StaffOperatingHours> StaffOperatingHours { get; set; }
    }
}
