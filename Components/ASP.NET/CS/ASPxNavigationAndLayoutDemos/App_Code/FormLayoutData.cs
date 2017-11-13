using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public enum Gender { Male = 0, Female = 1 }
public class Person {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }
    public DateTime? BirthDate { get; set; }
    public string Country { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
}
