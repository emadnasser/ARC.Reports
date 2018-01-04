using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARC.Reports.Classes
{
    public class Application
    {
        public Application()
        {
            this.Roles = new HashSet<Role>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}