using System;
using System.Collections.Generic;
using System.Text;

namespace DOTNETCore3.Model.Entities
{
    public class BusinessOperatingHours : IEntityBase
    {
        public BusinessOperatingHours()
        {
            StaffOperatingHours = new List<StaffOperatingHours>();
        }
        public int Id { get; set; }
        public Business Business { get; set; }
        public int BusinessId { get; set; }
        public int DayOfTheWeek { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public List<StaffOperatingHours> StaffOperatingHours { get; set; }
    }
}
