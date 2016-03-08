using System;
using System.Collections.Generic;

namespace LeanerRegisterAppCVersion.Models
{
    public partial class Person
    {
        public Person()
        {
            this.AttendanceDetails = new List<AttendanceDetail>();
            this.AttendanceMasters = new List<AttendanceMaster>();
        }

        public int PersonID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Contact { get; set; }
        public string EmailAdress { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public virtual ICollection<AttendanceDetail> AttendanceDetails { get; set; }
        public virtual ICollection<AttendanceMaster> AttendanceMasters { get; set; }
        public virtual Role Role { get; set; }
    }
}
