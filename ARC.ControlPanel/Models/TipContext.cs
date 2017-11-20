using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ARC.ControlPanel.Models
{
    public class TipContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
    }
}
