using System.Collections.Generic;
using System.Linq;
using Common.Win;
using DevExpress.ExpressApp.Security;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Xpo.Metadata.Helpers;

[assembly: OnlineRepoLocation("http://goo.gl/K8bCz")]

namespace Common.Win.General.Security {

    public interface IOperationPermissionProvider {
        IList<IOperationPermission> GetPermissions();
    }

    [ImageName("BO_Security_Permission_Type")]
    public abstract class PermissionDataBase : CustomObject, IOperationPermissionProvider {
        IEnumerable<XPMemberInfo> _propertyInfos;


        protected PermissionDataBase(Session session)
            : base(session) {
            EnumerateProperties();
        }

        public override string ToString() {
            return Permission;
        }

        [VisibleInDetailView(false)]
        public string Permission {
            get {
                return string.Format("{1}= {0}", GetPermissionInfoCaption(), string.Join(", ", GetPermissions().Select(item => item.Operation).ToArray()));
            }
        }

        protected virtual string GetPermissionInfoCaption() {
            return _propertyInfos.Aggregate<XPMemberInfo, string>(null, (current, propertyInfo) =>
                        current + (string.Format("{0}: {1}", propertyInfo.Name, propertyInfo.GetValue(this)) + ", ")).TrimEnd(", ".ToCharArray());
        }

        void EnumerateProperties() {
            _propertyInfos = ClassInfo.Members.Where(info => AttributesMatch(info) && info.IsPersistent && InfoTypeMatch(info));
        }

        bool InfoTypeMatch(XPMemberInfo info) {
            return typeof(PermissionDataBase).IsAssignableFrom(info.Owner.ClassType) && !(info is ServiceField);
        }

        bool AttributesMatch(XPMemberInfo info) {
            return info.FindAttributeInfo(typeof(NonPersistentAttribute)) == null && info.FindAttributeInfo(typeof(VisibleInListViewAttribute)) == null;
        }
        #region Implementation of IOperationPermissionProvider
        public abstract IList<IOperationPermission> GetPermissions();

        #endregion
        private XRole _role;
        [VisibleInListView(false)]
        [VisibleInDetailView(false)]
        [Association("XpandRole-XpandPermissionDatas")]
        public XRole Role {
            get {
                return _role;
            }
            set {
                SetPropertyValue("Role", ref _role, value);
            }
        }
    }
}
