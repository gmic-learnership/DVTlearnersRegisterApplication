using System;
using System.Collections.Generic;

namespace LeanerRegisterAppCVersion.Models
{
    public partial class AttendanceDetail
    {
        public int AttndncDtlsID { get; set; }
        public int AttndncMstrID { get; set; }
        public int MenteeID { get; set; }
        public Nullable<double> hours { get; set; }
        public virtual AttendanceMaster AttendanceMaster { get; set; }
        public virtual Person Person { get; set; }
    }
}
