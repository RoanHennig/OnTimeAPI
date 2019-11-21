using System;
using System.Collections.Generic;
using System.Text;

namespace DOTNETCore3.Model.Entities
{
    public class StaffShift : IEntityBase
    {
        public int Id { get; set; }
        public int StaffOperatingHoursId { get; set; }
        public StaffOperatingHours StaffOperatingHours { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
    }
}
