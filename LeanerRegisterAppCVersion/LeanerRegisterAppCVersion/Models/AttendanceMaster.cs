using System;
using System.Collections.Generic;

namespace LeanerRegisterAppCVersion.Models
{
    public partial class AttendanceMaster
    {
        public AttendanceMaster()
        {
            this.AttendanceDetails = new List<AttendanceDetail>();
        }

        public int AttndncMstrID { get; set; }
        public int MentorID { get; set; }
        public System.DateTime Date { get; set; }
        public string TrainingOn { get; set; }
        public virtual ICollection<AttendanceDetail> AttendanceDetails { get; set; }
        public virtual Person Person { get; set; }
    }
}
