using ARC.Reports.Classes;
using ARC.Reports.Classes.Enums;
using ARC.Reportss.Classes;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;

namespace ARC.Reports.DataModel
{
    public class DataAccess
    {
        public static User GetUser(string userName)
        {
            using (var context = new Context())
            {
                //context.Database.Log = message => Debug.WriteLine(message);
                var ret = context.Users.AsNoTracking().Include(x => x.Roles).FirstOrDefault(x => x.UserName == userName);
                return ret;
            }
        }

        public static List<Role> GetRoles(string userName)
        {
            using (var context = new Context())
            {
                //return context.Users.AsNoTracking().Include(c => c.Roles).FirstOrDefault().Roles;
                //return context.Roles.AsNoTracking().Where(x=> x.;
                return context.Users.AsNoTracking().FirstOrDefault().Roles.ToList();
            }
        }

        public static void CreateUser(User user)
        {
            using (var context = new Context())
            {
                var IsExistUser = context.Users.FirstOrDefault(x => x.UserName == user.UserName);

                if (IsExistUser == null)
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
        }

        public static void RemoveUser(string userName)
        {
            using (var context = new Context())
            {
                var IsExistUser = context.Users.FirstOrDefault(x => x.UserName == userName);

                if (IsExistUser.Roles.Count() == 0)
                {
                    context.Users.Remove(IsExistUser);
                    context.SaveChanges();
                }
            }
        }

        public static void AddRole(string userName, RoleType roleType)
        {
            using (var context = new Context())
            {
                var IsExistUser = context.Users.FirstOrDefault(x => x.UserName == userName);
                var Role = context.Roles.First(x => x.RoleId == (int)roleType);

                if (IsExistUser != null)
                {
                    if (!IsExistUser.Roles.Contains(Role))
                    {
                        IsExistUser.Roles.Add(Role);
                        context.SaveChanges();
                    }
                }
            }
        }

        public static void RemoveRole(string userName, RoleType roleType)
        {
            using (var context = new Context())
            {
                var IsExistUser = context.Users.FirstOrDefault(x => x.UserName == userName);
                var Role = context.Roles.First(x => x.RoleId == (int)roleType);

                if (IsExistUser != null)
                {
                    if (IsExistUser.Roles.Any(x => x.RoleName == roleType.ToString()))
                    {
                        IsExistUser.Roles.Remove(Role);
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}