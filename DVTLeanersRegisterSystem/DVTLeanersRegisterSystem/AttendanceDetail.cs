//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DVTLeanersRegisterSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class AttendanceDetail
    {
        public int AttndncDtlsID { get; set; }
        public int AttndncMstrID { get; set; }
        public int MenteeID { get; set; }
        public double Hours { get; set; }
    
        public virtual AttendanceMaster AttendanceMaster { get; set; }
        public virtual Person Person { get; set; }
    }
}