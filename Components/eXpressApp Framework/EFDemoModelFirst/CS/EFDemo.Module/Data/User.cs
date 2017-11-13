using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

using DevExpress.ExpressApp.Security;
using DevExpress.Persistent.Base.Security;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Utils;

namespace EFDemo.Module.Data {
    [DisplayName("User"), ImageName("BO_User")]
    [MetadataType(typeof(UserMetadata))]
    public partial class PermissionPolicyUser : IPermissionPolicyUser, ISecurityUser, IAuthenticationActiveDirectoryUser, IAuthenticationStandardUser, ISecurityUserWithRoles {
        // ISecurityUser
        Boolean ISecurityUser.IsActive {
            get { return IsActive; }
        }
        String ISecurityUser.UserName {
            get { return UserName; }
        }

        // IAuthenticationActiveDirectoryUser
        String IAuthenticationActiveDirectoryUser.UserName {
            get { return UserName; }
            set { UserName = value; }
        }

        // IAuthenticationStandardUser
        Boolean IAuthenticationStandardUser.ComparePassword(String password) {
            PasswordCryptographer passwordCryptographer = new PasswordCryptographer();
            return passwordCryptographer.AreEqual(StoredPassword, password);
        }
        public void SetPassword(String password) {
            PasswordCryptographer passwordCryptographer = new PasswordCryptographer();
            StoredPassword = passwordCryptographer.GenerateSaltedPassword(password);
        }
        Boolean IAuthenticationStandardUser.ChangePasswordOnFirstLogon {
            get { return ChangePasswordOnFirstLogon; }
            set { ChangePasswordOnFirstLogon = value; }
        }
        String IAuthenticationStandardUser.UserName {
            get { return UserName; }
        }

        // IPermissionPolicyUser
        IEnumerable<IPermissionPolicyRole> IPermissionPolicyUser.Roles {
            get {
                IList<IPermissionPolicyRole> result = new List<IPermissionPolicyRole>();
                if(!Roles.IsLoaded) {
                    Roles.Load();
                }
                foreach(IPermissionPolicyRole role in Roles) {
                    result.Add(role);
                }
                return new ReadOnlyCollection<IPermissionPolicyRole>(result);
            }
        }
        // ISecurityUserWithRoles
        IList<ISecurityRole> ISecurityUserWithRoles.Roles {
            get {
                IList<ISecurityRole> result = new List<ISecurityRole>();
                if(!Roles.IsLoaded) {
                    Roles.Load();
                }
                foreach(ISecurityRole role in Roles) {
                    result.Add(role);
                }
                return new ReadOnlyCollection<ISecurityRole>(result);
            }
        }
    }

    public class UserMetadata {
        [VisibleInDetailView(false), VisibleInListView(false), VisibleInLookupListView(false)]
        public Int32 ID { get; set; }
        [Browsable(false), SecurityBrowsable]
        public String StoredPassword { get; set; }
    }
}
