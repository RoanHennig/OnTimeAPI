using System;
using System.Collections.Generic;
using System.Text;

namespace DOTNETCore3.Model.Entities
{
    public class StaffOperatingHours : IEntityBase
    {
        public StaffOperatingHours()
        {
            StaffShifts = new List<StaffShift>();
        }
        public int Id { get; set; }
        public int BusinessOperatingHoursId { get; set; }       
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public int DayOfTheWeek { get; set; }
        public List<StaffShift> StaffShifts { get; set; }

    }
}
