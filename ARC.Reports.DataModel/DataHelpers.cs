using ARC.Reports.Classes;
using ARC.Reports.Classes.Enums;
using ARC.Reportss.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARC.Reports.DataModel
{
    public class DataHelpers
    {
        public static void NewDbWithSeed()
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
            using (var context = new Context())
            {
                if (context.Applications.Any())
                {
                    return;
                }

                var applicationPrice = context.Applications.Add(new Application { ApplicationId = (int)ApplicationType.Price, ApplicationName = ApplicationType.Price.ToString() });
                var applicationReport = context.Applications.Add(new Application { ApplicationId = (int)ApplicationType.Reports, ApplicationName = ApplicationType.Reports.ToString() });

                var SystemAdmin = new User
                {
                    UserName = "EM_ARC\\emadnasser",
                    FirstName = "Emad",
                    LastName = "Nasser",
                    CreateDate = DateTime.Now,
                    Roles = new List<Role>()
                    {
                        new Role()
                        {
                            RoleId = (int)RoleType.SettingsAdmins,
                            RoleName = RoleType.SettingsAdmins.ToString(),
                            Application = new Application
                            {
                                ApplicationId = (int)ApplicationType.Settings,
                                ApplicationName = ApplicationType.Settings.ToString(),
                            },
                        },
                        new Role()
                        {
                            RoleId = (int)RoleType.PriceAdmins,
                            RoleName = RoleType.PriceAdmins.ToString(),
                            Application = applicationPrice
                        },
                        new Role()
                        {
                            RoleId = (int)RoleType.Dashboard,
                            RoleName = RoleType.Dashboard.ToString(),
                            Application = applicationPrice
                        },
                        new Role()
                        {
                            RoleId = (int)RoleType.ListAll,
                            RoleName = RoleType.ListAll.ToString(),
                            Application = applicationPrice
                        },
                        new Role()
                        {
                            RoleId = (int)RoleType.ListSearch,
                            RoleName = RoleType.ListSearch.ToString(),
                            Application = applicationPrice
                        },
                        new Role()
                        {
                            RoleId = (int)RoleType.ListIndices,
                            RoleName = RoleType.ListIndices.ToString(),
                            Application = applicationPrice
                        },
                        new Role()
                        {
                            RoleId = (int)RoleType.News,
                            RoleName = RoleType.News.ToString(),
                            Application = applicationPrice
                        },
                        new Role()
                        {
                            RoleId = (int)RoleType.ReportsAdmins,
                            RoleName = RoleType.ReportsAdmins.ToString(),
                            Application = applicationReport
                        },
                        new Role()
                        {
                            RoleId = (int)RoleType.R_001,
                            RoleName = RoleType.R_001.ToString(),
                            Application = applicationReport
                        },
                        new Role()
                        {
                            RoleId = (int)RoleType.R_002,
                            RoleName = RoleType.R_002.ToString(),
                            Application = applicationReport
                        },
                        new Role()
                        {
                            RoleId = (int)RoleType.BrokerageMetrics,
                            RoleName = RoleType.BrokerageMetrics.ToString(),
                            Application = applicationReport
                        },
                        new Role()
                        {
                            RoleId = (int)RoleType.Graphs,
                            RoleName = RoleType.Graphs.ToString(),
                            Application = applicationReport
                        },
                        new Role()
                        {
                            RoleId = (int)RoleType.SummaryCommission,
                            RoleName = RoleType.SummaryCommission.ToString(),
                            Application = applicationReport
                        },
                    }
                };

                context.Users.Add(SystemAdmin);

                context.SaveChanges();
            }
        }
    }
}

