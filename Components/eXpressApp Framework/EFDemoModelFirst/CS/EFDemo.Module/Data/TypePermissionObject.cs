using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data.Entity.Core.Objects.DataClasses;
using System.ComponentModel.DataAnnotations;

using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.Strategy;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Utils;

namespace EFDemo.Module.Data {
    [DisplayName("Type Permission Object")]
    [DefaultListViewOptions(true, NewItemRowPosition.Top)]
    [MetadataType(typeof(TypePermissionObjectMetadata))]
    public partial class PermissionPolicyTypePermissionObject : ICheckedListBoxItemsProvider, IPermissionPolicyTypePermissionObject {
        private Type targetType;
        #region ICheckedListBoxItemsProvider
        Dictionary<Object, String> ICheckedListBoxItemsProvider.GetCheckedListBoxItems(string targetMemberName) {
            Dictionary<Object, String> result = new Dictionary<Object, String>();
            if(targetMemberName == "Members" && TargetType != null) {
                ITypeInfo typeInfo = XafTypesInfo.Instance.FindTypeInfo(TargetType);
                foreach(IMemberInfo memberInfo in typeInfo.Members) {
                    if(memberInfo.IsVisible || (memberInfo.FindAttribute<SecurityBrowsableAttribute>() != null)) {
                        result.Add(memberInfo.Name, CaptionHelper.GetMemberCaption(memberInfo));
                    }
                }
            }
            return result;
        }
        protected virtual void OnItemsChanged() {
            if(ItemsChanged != null) {
                ItemsChanged(this, new EventArgs());
            }
        }
        public event EventHandler ItemsChanged;
        #endregion
        public Type TargetType {
            get {
                if((targetType == null) && !String.IsNullOrWhiteSpace(TargetTypeFullName)) {
                    targetType = ReflectionHelper.FindType(TargetTypeFullName);
                }
                return targetType;
            }
            set {
                targetType = value;
                if(targetType != null) {
                    TargetTypeFullName = targetType.FullName;
                }
                else {
                    TargetTypeFullName = "";
                }
            }
        }
        [DisplayName("Read")]
        public SecurityPermissionState? ReadState {
            get {
                return (SecurityPermissionState?)ReadState_Int;
            }
            set {
                ReadState_Int = (Int32?)value;
            }
        }

        [DisplayName("Write")]
        public SecurityPermissionState? WriteState {
            get {
                return (SecurityPermissionState?)WriteState_Int;
            }
            set {
                WriteState_Int = (Int32?)value;
            }
        }
        [DisplayName("Create")]
        public SecurityPermissionState? CreateState {
            get {
                return (SecurityPermissionState?)CreateState_Int;
            }
            set {
                CreateState_Int = (Int32?)value;
            }
        }
        [DisplayName("Delete")]
        public SecurityPermissionState? DeleteState {
            get {
                return (SecurityPermissionState?)DeleteState_Int;
            }
            set {
                DeleteState_Int = (Int32?)value;
            }
        }

        [DisplayName("Navigate")]
        public SecurityPermissionState? NavigateState {
            get {
                return (SecurityPermissionState?)NavigateState_Int;
            }
            set {
                NavigateState_Int = (Int32?)value;
            }
        }

        IPermissionPolicyRole IPermissionPolicyTypePermissionObject.Role {
            get {
                return Role;
            }
        }

        IEnumerable<IPermissionPolicyMemberPermissionsObject> IPermissionPolicyTypePermissionObject.MemberPermissions {
            get {
                return MemberPermissions.OfType<IPermissionPolicyMemberPermissionsObject>();
            }
        }
        IEnumerable<IPermissionPolicyObjectPermissionsObject> IPermissionPolicyTypePermissionObject.ObjectPermissions {
            get {
                return ObjectPermissions.OfType<IPermissionPolicyObjectPermissionsObject>();
            }
        }

        public IPermissionPolicyMemberPermissionsObject CreateMemberPermission() {
            PermissionPolicyMemberPermissionsObject permissionPolicyMemberPermissionsObject = new PermissionPolicyMemberPermissionsObject();
            permissionPolicyMemberPermissionsObject.TypePermissionObject = this;
            MemberPermissions.Add(permissionPolicyMemberPermissionsObject);
            return permissionPolicyMemberPermissionsObject;
        }

        public IPermissionPolicyObjectPermissionsObject CreateObjectPermission() {
            PermissionPolicyObjectPermissionsObject permissionPolicyObjectPermissionsObject = new PermissionPolicyObjectPermissionsObject();
            permissionPolicyObjectPermissionsObject.TypePermissionObject = this;
            ObjectPermissions.Add(permissionPolicyObjectPermissionsObject);
            return permissionPolicyObjectPermissionsObject;
        }
    }

    public class TypePermissionObjectMetadata {
        [VisibleInDetailView(false), VisibleInListView(false), VisibleInLookupListView(false)]
        public Int32 ID { get; set; }
        [Browsable(false)]
        public String TargetTypeFullName { get; set; }
        [Browsable(false)]
        public int CreateState_Int { get; set; }
        [Browsable(false)]
        public int DeleteState_Int { get; set; }
        [Browsable(false)]
        public int NavigateState_Int { get; set; }
        [Browsable(false)]
        public int ReadState_Int { get; set; }
        [Browsable(false)]
        public int WriteState_Int { get; set; }
        [Browsable(false)]
        public PermissionPolicyRole Role { get; set; }
    }
}
