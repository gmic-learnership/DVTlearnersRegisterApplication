using System;
using System.Collections.Generic;

namespace LeanerRegisterAppCVersion.Models
{
    public partial class Role
    {
        public Role()
        {
            this.Person = new List<Person>();
        }

        public int RoleID { get; set; }
        public string RoleType { get; set; }
        public virtual ICollection<Person> Person { get; set; }
    }
}
