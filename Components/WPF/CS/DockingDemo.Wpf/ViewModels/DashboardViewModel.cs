using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using DevExpress.DemoData.Models;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Native;
using DevExpress.Mvvm.POCO;

namespace DockingDemo.ViewModels {
    public class DashboardViewModel {
        public DashboardViewModel() {
            Teams = DashboardViewModelData.GetTeams();
            CurrentTeam = Teams[0];
        }

        [BindableProperty(OnPropertyChangedMethodName = "OnCurrentTeamChanged")]
        public virtual Team CurrentTeam { get; set; }
        public List<Team> Teams { get; set; }

        protected void OnCurrentTeamChanged() {
            if(CurrentTeam.CurrentProject == null)
                CurrentTeam.CurrentProject = CurrentTeam.Projects[0];
        }
    }
    public class Team {
        protected Team(string name) {
            Name = name;
            Projects = new List<Project>();
            Members = new List<Person>();
        }
        public virtual Project CurrentProject { get; set; }
        public Person Lead { get { return Members[0]; } }
        public List<Person> Members { get; private set; }
        public string Name { get; private set; }
        public List<Project> Projects { get; private set; }

        public static Team Create(string teamName) {
            return ViewModelSource.Create(() => new Team(teamName));
        }
        public void AddMembers(params Person[] members) {
            Members.AddRange(members);
        }
        public void AddProjects(params Project[] projects) {
            Projects.AddRange(projects);
            if(CurrentProject == null) CurrentProject = Projects[0];
        }
    }
    public class Person {
        readonly DevExpress.DemoData.Models.Employee employee;

        protected Person(DevExpress.DemoData.Models.Employee employee) {
            this.employee = employee;
        }

        public string Address { get { return employee.Address; } }
        public string Email { get { return employee.Email; } }
        public string FullName { get { return employee.FullName; } }
        public string JobTitle { get; private set; }
        public string Phone { get { return employee.HomePhone; } }
        public byte[] Photo { get { return employee.Photo; } }

        public static Person Create(DevExpress.DemoData.Models.Employee employee) {
            var person = ViewModelSource.Create(() => new Person(employee));
            person.JobTitle = titles[titleRandom.Next(titles.Length)];
            return person;
        }
        static string[] titles = new string[] { "Developer", "Designer", "Support Developer", "Technical Writer" };
        static Random titleRandom = new Random();

    }
    public class Project {
        public Project(string title) {
            Title = title;
        }

        public int BugsTotal { get; set; }
        public ImageSource History { get; set; }
        public int IssuesTotal { get; set; }
        public string Title { get; set; }
    }
    #region SampleData
    public static class DashboardViewModelData {
        public static List<Team> GetTeams() {
            return CreateSampleData();
        }
        static List<Team> CreateSampleData() {

            Project project1 = new Project("Billing System") {
                BugsTotal = 15,
                IssuesTotal = 27,
                History = new BitmapImage(new Uri("/DockingDemo;component/Images/Dashboard/history1.png", UriKind.Relative))
            };
            Project project2 = new Project("Contract Management System") {
                BugsTotal = 15,
                IssuesTotal = 24,
                History = new BitmapImage(new Uri("/DockingDemo;component/Images/Dashboard/history2.png", UriKind.Relative))
            };
            Project project3 = new Project("Internal Software") {
                BugsTotal = 40,
                IssuesTotal = 50,
                History = new BitmapImage(new Uri("/DockingDemo;component/Images/Dashboard/history3.png", UriKind.Relative))
            };
            Project project4 = new Project("Company WebSite") {
                BugsTotal = 20,
                IssuesTotal = 22,
                History = new BitmapImage(new Uri("/DockingDemo;component/Images/Dashboard/history4.png", UriKind.Relative))
            };

            var employees = NWindContext.Create().Employees
                .AsEnumerable()
                .Reverse()
                .Select(x => Person.Create(x));

            Team badBoysTeam = Team.Create("Bad Boys");
            badBoysTeam.AddProjects(project1, project2);
            badBoysTeam.AddMembers(employees.Take(5).OrderBy(x => x.JobTitle).ToArray());

            Team dreamGirlsTeam = Team.Create("Dream Girls");
            dreamGirlsTeam.AddProjects(project3, project4);
            dreamGirlsTeam.AddMembers(employees.Skip(5).OrderBy(x => x.JobTitle).ToArray());

            return new List<Team>() { badBoysTeam, dreamGirlsTeam };
        }
    }
    #endregion SampleData
}
