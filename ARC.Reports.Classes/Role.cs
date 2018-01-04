using ARC.Reportss.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARC.Reports.Classes
{
    public class Role
    {
        public Role()
        {
            this.Users = new HashSet<User>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int? Application_ApplicationId { get; set; }
        public virtual Application Application { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}