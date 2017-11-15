using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARC.ControlPanel.Models
{
    public class User
    {
        public String UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
    }
}