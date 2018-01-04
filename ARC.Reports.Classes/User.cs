using ARC.Reports.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARC.Reportss.Classes
{
    public partial class User
    {
        public User()
        {
            this.Roles = new HashSet<Role>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IP { get; set; }
        public string Host { get; set; }
        public string Email { get; set; }
        public string Ext { get; set; }
        public string Mobile { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsLockedOut { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}