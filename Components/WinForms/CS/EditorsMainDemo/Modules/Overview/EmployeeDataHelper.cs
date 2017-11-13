﻿using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;

namespace DevExpress.XtraEditors.Demos.Modules.Overview {
    #region Data
    public static class EmployeeDataHelper {
        //TODO add EMployee task and Evaluations
        public static Employee CreateDefaultEmployee() {
            Random r = new Random();
            Employee employee = new Employee();
            employee.FirstName = "Leah";
            employee.LastName = "Simpson";
            employee.BirthDate = new DateTime(1983, 4, 19);
            employee.Title = "Test Coordinator";
            employee.Prefix = PersonPrefix.Mrs;
            employee.Address = new Address();
            employee.Address.Line = "6755 Newlin Ave";
            employee.Address.City = "Whittier";
            employee.Address.State = StateEnum.AK;
            employee.Address.ZipCode = "90601";
            employee.HomePhone = "(562) 555-7372";
            employee.MobilePhone = "(562) 559-5830";
            employee.Email = "leahs@dx-email.com";
            employee.Skype = "leahs_DX_skype";
            employee.Department = EmployeeDepartment.Engineering;
            employee.Status = EmployeeStatus.Salaried;
            employee.HireDate = new DateTime(2009, 2, 14);
            employee.AssignedTasks = new List<EmployeeTask>();

            EmployeeTask employeeTask1 = new EmployeeTask();
            employeeTask1.Priority = EmployeeTaskPriority.Normal;
            employeeTask1.DueDate = DateTime.Now + new TimeSpan(10, 10, 0, 0, 0);
            employeeTask1.Subject = string.Format("{0} QA Strategy Report", DateTime.Now.Year);
            employeeTask1.Description = string.Format("In final stages of the {0} R & D Report to Management.Need QA strategy report asap.Remember, {1} was a difficult year product quality-wise and we must step it up in {0}. Leah Simpson: Bart, my apologies about {1}.My report includes remedies to issues we encountered.", DateTime.Now.Year, DateTime.Now.Year - 1);
            employeeTask1.Completion = 100;
            employee.AssignedTasks.Add(employeeTask1);

            EmployeeTask employeeTask2 = new EmployeeTask();
            employeeTask2.Priority = EmployeeTaskPriority.Urgent;
            employeeTask2.DueDate = DateTime.Now + new TimeSpan(40, 10, 0, 0, 0);
            employeeTask2.Subject = "Review Training Course for any Commissions";
            employeeTask2.Description = "Leah, consider this most important item on your agenda. I need this new training material reviewed so it can be submitted to management. Leah Simpson: I only found a few spelling mistakes.";
            employeeTask2.Completion = 70;
            employee.AssignedTasks.Add(employeeTask2);


            EmployeeTask employeeTask3 = new EmployeeTask();
            employeeTask3.Priority = EmployeeTaskPriority.Low;
            employeeTask3.DueDate = DateTime.Now + new TimeSpan(80, 10, 0, 0, 0);
            employeeTask3.Subject = "Review New Training Material";
            employeeTask3.Description = "Just getting ready to push out some new training material for our customers so they can better understand how our product line fits together.Can I get a review of the content so I can send it out to the printer ? Leah Simpson: Nat, I've reviewed everything and it looks really nice.";
            employeeTask3.Completion = 55;
            employee.AssignedTasks.Add(employeeTask3);

            EmployeeTask employeeTask4 = new EmployeeTask();
            employeeTask4.Priority = EmployeeTaskPriority.High;
            employeeTask4.DueDate = DateTime.Now + new TimeSpan(95, 10, 0, 0, 0);
            employeeTask4.Subject = "Test New Automation App";
            employeeTask4.Description = "We are in a rush to ship this and you need to put all your energy behind finding bugs.If you do find bugs, use standard reporting mechanisms. We'll fix what we can as soon as we can.";
            employeeTask4.Completion = 40;
            employee.AssignedTasks.Add(employeeTask4);

            EmployeeTask employeeTask5 = new EmployeeTask();
            employeeTask5.Priority = EmployeeTaskPriority.Urgent;
            employeeTask5.DueDate = DateTime.Now + new TimeSpan(30, 10, 0, 0, 0);
            employeeTask5.Subject = "Email Test Report on New Products";
            employeeTask5.Description = "Leah, we cannot fix our products until we get the test report from you.Please send everything you have by email to me so I can distribute it in the engineering dept. Leah Simpson: Still collecting these";
            employeeTask5.Completion = 15;
            employee.AssignedTasks.Add(employeeTask5);


            employee.Evaluations = new List<Evaluation>();
            for(int i = employee.HireDate.Value.Year; i < DateTime.Now.Year; i++)
                employee.Evaluations.Add(new Evaluation() { CreatedOn = new DateTime(i, r.Next(1, 12), r.Next(1, 25)), Manager = "Bart Simpson", Subject = string.Format("{0} Employee Review", i) });
            return employee;
        }
    }

    public class Employee {
        public Address Address { get; set; }
        public virtual List<EmployeeTask> AssignedTasks { get; set; }
        [Display(Name = "Birth Date")]
        public DateTime? BirthDate { get; set; }
        public EmployeeDepartment Department { get; set; }
        [Required]
        public string Email { get; set; }
        public virtual List<Evaluation> Evaluations { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Full Name")]
        public string FullNameBindable {
            get { return FirstName + " " + LastName; }
        }
        [Display(Name = "Hire Date")]
        public DateTime? HireDate { get; set; }
        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Mobile Phone")]
        [Required]
        public string MobilePhone { get; set; }
        public string PersonalProfile { get; set; }
        public Image Photo { get; set; }
        public PersonPrefix Prefix { get; set; }
        public virtual string ProbationReason { get; set; }
        public string Skype { get; set; }
        public EmployeeStatus Status { get; set; }
        [Required]
        public string Title { get; set; }
    }
    public enum PersonPrefix {
        Dr = 0,
        Mr = 1,
        Ms = 2,
        Miss = 3,
        Mrs = 4
    }
    public enum EmployeeStatus {
        Salaried = 0,
        Commission = 1,
        Terminated = 2,
        OnLeave = 3
    }
    public enum EmployeeDepartment {
        Sales = 1,
        Support = 2,
        Shipping = 3,
        Engineering = 4,
        HumanResources = 5,
        Management = 6,
        IT = 7
    }

    public class Address {
        public string City { get; set; }
        public double Latitude { get; set; }
        [Display(Name = "Address")]
        public string Line { get; set; }
        public double Longitude { get; set; }
        public StateEnum State { get; set; }
        [Display(Name = "Zip code")]
        public string ZipCode { get; set; }
    }
    public enum StateEnum {
        CA = 0,
        AR = 1,
        AL = 2,
        AK = 3,
        AZ = 4,
        CO = 5,
        CT = 6,
        DE = 7,
        DC = 8,
        FL = 9,
        GA = 10,
        HI = 11,
        ID = 12,
        IL = 13,
        IN = 14,
        IA = 15,
        KS = 16,
        KY = 17,
        LA = 18,
        ME = 19,
        MD = 20,
        MA = 21,
        MI = 22,
        MN = 23,
        MS = 24,
        MO = 25,
        MT = 26,
        NE = 27,
        NV = 28,
        NH = 29,
        NJ = 30,
        NM = 31,
        NY = 32,
        NC = 33,
        OH = 34,
        OK = 35,
        OR = 36,
        PA = 37,
        RI = 38,
        SC = 39,
        SD = 40,
        TN = 41,
        TX = 42,
        UT = 43,
        VT = 44,
        VA = 45,
        WA = 46,
        WV = 47,
        WI = 48,
        WY = 49,
        ND = 50
    }

    public class EmployeeTask {
        public int Completion { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public EmployeeTaskPriority Priority { get; set; }
        public DateTime? StartDate { get; set; }
        public string Subject { get; set; }
    }
    public enum EmployeeTaskPriority {
        Low = 0,
        Normal = 1,
        High = 2,
        Urgent = 3
    }

    public class Evaluation {
        public DateTime CreatedOn { get; set; }
        public virtual string Manager { get; set; }
        public string Subject { get; set; }
    }

    #endregion
    static class EditorHelpers {
        static ImageCollection CreatePersonPrefixImageCollection() {
            ImageCollection ret = new ImageCollection();
            ret.ImageSize = new Size(16, 16);
            ret.AddImage(Properties.Resources.Doctor);
            ret.AddImage(Properties.Resources.Mr);
            ret.AddImage(Properties.Resources.Ms);
            ret.AddImage(Properties.Resources.Miss);
            ret.AddImage(Properties.Resources.Mrs);
            return ret;
        }
        static ImageCollection CreateTaskPriorityImageCollection() {
            ImageCollection ret = new ImageCollection();
            ret.ImageSize = new Size(16, 16);
            ret.AddImage(Properties.Resources.LowPriority);
            ret.AddImage(Properties.Resources.NormalPriority);
            ret.AddImage(Properties.Resources.MediumPriority);
            ret.AddImage(Properties.Resources.HighPriority);
            return ret;
        }

        public static TEdit CreateEdit<TEdit>(TEdit edit = null, RepositoryItemCollection collection = null, Action<TEdit> initialize = null)
    where TEdit : RepositoryItem, new() {
            edit = edit ?? new TEdit();
            if(collection != null) collection.Add(edit);
            if(initialize != null)
                initialize(edit);
            return edit;
        }
        public static RepositoryItemImageComboBox CreateEnumImageComboBox<TEnum>(RepositoryItemImageComboBox edit = null, RepositoryItemCollection collection = null,
        Converter<TEnum, string> displayTextConverter = null) {
            return CreateEdit<RepositoryItemImageComboBox>(edit, collection, (e) => e.Items.AddEnum<TEnum>(displayTextConverter));
        }
        public static RepositoryItemImageComboBox CreatePersonPrefixImageComboBox(RepositoryItemImageComboBox edit = null, RepositoryItemCollection collection = null) {
            RepositoryItemImageComboBox ret = CreateEnumImageComboBox<PersonPrefix>(edit, collection);
            ret.SmallImages = CreatePersonPrefixImageCollection();
            if(edit == null)
                ret.GlyphAlignment = HorzAlignment.Center;
            return ret;
        }
        public static RepositoryItemImageComboBox CreateTaskPriorityImageComboBox(RepositoryItemImageComboBox edit = null, RepositoryItemCollection collection = null) {
            RepositoryItemImageComboBox ret = CreateEnumImageComboBox<EmployeeTaskPriority>(edit, collection);
            ret.SmallImages = CreateTaskPriorityImageCollection();
            if(edit == null)
                ret.GlyphAlignment = HorzAlignment.Center;
            return ret;
        }
    }
}
