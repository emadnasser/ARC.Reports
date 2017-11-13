﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExpress.Web.Demos {
    public class EmployeeData {
        public EmployeeData(Employee employee) {
            LastName = employee.LastName;
            FirstName = employee.FirstName;
            BirthDate = employee.BirthDate;
            Country = employee.Country;
            City = employee.City;
            Address = employee.Address;
            Notes = employee.Notes;
            HomePhone = employee.HomePhone;
            Photo = employee.Photo.ToArray();
            Title = employee.Title;
            TitleOfCourtesy = employee.TitleOfCourtesy;
            HireDate = employee.HireDate;
            Region = employee.Region;
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public string HomePhone { get; set; }
        public byte[] Photo { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime? HireDate { get; set; }
        public string Region { get; set; }
    }

    public class EmployeesDataProvider {
        public static IList<EmployeeData> GetEmployees() {
            List<EmployeeData> list = new List<EmployeeData>();
            foreach(Employee employee in NorthwindDataProvider.GetEmployees())
                list.Add(new EmployeeData(employee));
            return list;
        }
    }
}
