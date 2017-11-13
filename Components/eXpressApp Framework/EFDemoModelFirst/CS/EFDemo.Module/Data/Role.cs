using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data.Entity.Core.Objects.DataClasses;
using System.ComponentModel.DataAnnotations;

using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;

namespace EFDemo.Module.Data {
    [DisplayName("Role"), ImageName("BO_Role")]
    [MetadataType(typeof(RoleMetadata))]
    public partial class PermissionPolicyRole : IPermissionPolicyRole, ISecurityRole, ISecuritySystemRole, INavigationPermissions, IPermissionPolicyRoleWithUsers, ICanInitializeRole {
        //IPermissionPolicyRole
        public SecurityPermissionPolicy PermissionPolicy {
            get { return (SecurityPermissionPolicy)PermissionPolicy_Int; }
            set { PermissionPolicy_Int = (Int32)value; }
        }

        // ISecurityRole
        String ISecurityRole.Name {
            get { return Name; }
        }

        IEnumerable<IPermissionPolicyNavigationPermissionObject> INavigationPermissions.NavigationPermissions {
            get {
                return NavigationPermissions.OfType<IPermissionPolicyNavigationPermissionObject>();
            }
        }

        IEnumerable<IPermissionPolicyTypePermissionObject> IPermissionPolicyRole.TypePermissions {
            get {
                return TypePermissions.OfType<IPermissionPolicyTypePermissionObject>();
            }
        }

        IEnumerable<IPermissionPolicyUser> IPermissionPolicyRoleWithUsers.Users {
            get {
                return Users.OfType<IPermissionPolicyUser>();
            }
        }

        public bool AddUser(object user) {
            bool result = false;
            PermissionPolicyUser permissionPolicyUser = user as PermissionPolicyUser;
            if(permissionPolicyUser != null) {
                Users.Add(permissionPolicyUser);
                result = true;
            }
            return result;
        }

        public IPermissionPolicyNavigationPermissionObject CreateNavigationPermissionObject(string itemPath) {
            PermissionPolicyNavigationPermissionObject navigationPermissionObject = new PermissionPolicyNavigationPermissionObject();
            navigationPermissionObject.ItemPath = itemPath;
            navigationPermissionObject.Role = this;
            return navigationPermissionObject;
        }

        public IPermissionPolicyTypePermissionObject CreateTypePermissionObject(Type targetType) {
            PermissionPolicyTypePermissionObject permissionPolicyTypePermissionObject = new PermissionPolicyTypePermissionObject();
            permissionPolicyTypePermissionObject.TargetType = targetType;
            permissionPolicyTypePermissionObject.Role = this;
            TypePermissions.Add(permissionPolicyTypePermissionObject);
            return permissionPolicyTypePermissionObject;
        }
    }

    public class RoleMetadata {
        [VisibleInDetailView(false), VisibleInListView(false), VisibleInLookupListView(false)]
        public Int32 ID { get; set; }
        [Aggregated]
        public EntityCollection<PermissionPolicyTypePermissionObject> TypePermissions { get; set; }
        [Browsable(false)]
        public Int32 PermissionPolicy_Int { get; set; }
    }
}
