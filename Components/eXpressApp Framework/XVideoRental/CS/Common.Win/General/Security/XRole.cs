using System;
using System.Collections.Generic;
using System.Linq;
using Common.Win;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.Strategy;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;

[assembly: OnlineRepoLocation("http://goo.gl/Bhi9b")]

namespace Common.Win.General.Security {
    [ImageName("BO_Role"), System.ComponentModel.DisplayName("Role")]
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class XRole : SecuritySystemRole {
        public XRole(Session session)
            : base(session) {
        }

        protected override IEnumerable<IOperationPermission> GetPermissionsCore() {
            var operationPermissions = OperationPermissions();
            return OperationPermissionCollectionMembers().Aggregate(operationPermissions, (current, xpMemberInfo) => current.Union(this.ObjectOperationPermissions(xpMemberInfo)));
        }

        IEnumerable<XPMemberInfo> OperationPermissionCollectionMembers() {
            return ClassInfo.OwnMembers.Where(info => info.IsAssociationList && info.CollectionElementType.HasAttribute(typeof(SecurityOperationsAttribute)));
        }

        IEnumerable<IOperationPermission> OperationPermissions() {
            var operationPermissions = base.GetPermissionsCore().Union(Permissions.SelectMany(data => data.GetPermissions()));
            var overallCustomizationAllowedPermissions = new OverallCustomizationAllowedPermission[0];
            if (ModifyLayout) {
                overallCustomizationAllowedPermissions = new[] { new OverallCustomizationAllowedPermission() };
            }
            return operationPermissions.Union(overallCustomizationAllowedPermissions);
        }

        private bool _modifyLayout;

        public bool ModifyLayout {
            get { return _modifyLayout; }
            set { SetPropertyValue("ModifyLayout", ref _modifyLayout, value); }
        }
        public override string ToString() {
            return Name;
        }

        [Association("XpandRole-XpandPermissionDatas")]
        public XPCollection<PermissionDataBase> Permissions {
            get {
                return GetCollection<PermissionDataBase>("Permissions");
            }
        }
    }

    public enum SecurityOperationsEnum {
        Read,
        Write,
        Create,
        Delete,
        Navigate,
        FullObjectAccess,
        FullAccess,
        ReadOnlyAccess,
        CRUDAccess,
        ReadWriteAccess,
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class SecurityOperationsAttribute : Attribute {
        readonly string _collectionName;
        readonly string _operationProviderProperty;

        public SecurityOperationsAttribute(string collectionName, string operationProviderProperty) {
            _collectionName = collectionName;
            _operationProviderProperty = operationProviderProperty;
        }

        public string CollectionName {
            get { return _collectionName; }
        }

        public string OperationProviderProperty {
            get { return _operationProviderProperty; }
        }
    }
}
