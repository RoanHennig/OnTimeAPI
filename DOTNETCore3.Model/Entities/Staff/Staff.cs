using System;
using System.Collections.Generic;
using System.Text;

namespace DOTNETCore3.Model.Entities
{
    public class Staff : IEntityBase
    {
        public Staff()
        {
            StaffOperatingHours = new List<StaffOperatingHours>();
            StaffShifts = new List<StaffShift>();
        }

        public int Id { get; set; }
        public int BusinessId { get; set; }
        public Business Business { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string StaffFirstName { get; set; }
        public string StaffLastName { get; set; }
        public List<StaffOperatingHours> StaffOperatingHours { get; set; }
        public List<StaffShift> StaffShifts { get; set; }
    }
}
