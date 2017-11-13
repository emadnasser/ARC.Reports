using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace EFDemo.Module.Data {
    [DisplayName("Member Operation Permissions")]
    [ImageName("BO_Security_Permission_Member")]
    [DefaultListViewOptions(true, NewItemRowPosition.Top)]
    [MetadataType(typeof(MemberPermissionsObjectMetadata))]
    public partial class PermissionPolicyMemberPermissionsObject : ICheckedListBoxItemsProvider, IOwnerInitializer, IPermissionPolicyMemberPermissionsObject {
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
        [Browsable(false)]
        IPermissionPolicyTypePermissionObject IPermissionPolicyMemberPermissionsObject.TypePermissionObject {
            get {
                return TypePermissionObject;
            }
        }

        #region ICheckedListBoxItemsProvider Members
        Dictionary<Object, String> ICheckedListBoxItemsProvider.GetCheckedListBoxItems(string targetMemberName) {
            if(TypePermissionObject == null || !(TypePermissionObject is ICheckedListBoxItemsProvider)) {
                return new Dictionary<Object, String>();
            }
            return ((ICheckedListBoxItemsProvider)TypePermissionObject).GetCheckedListBoxItems(targetMemberName);
        }
        protected virtual void OnItemsChanged() {
            if(ItemsChanged != null) {
                ItemsChanged(this, new EventArgs());
            }
        }
        public event EventHandler ItemsChanged;
        #endregion
        #region IOwnerInitializer Members
        void IOwnerInitializer.SetMasterObject(object masterObject) {
            PermissionPolicyTypePermissionObject typePermission = masterObject as PermissionPolicyTypePermissionObject;
            if(typePermission != null) {
                TypePermissionObject = typePermission;
            }
        }
        #endregion
    }
    public class MemberPermissionsObjectMetadata {
        [VisibleInDetailView(false), VisibleInListView(false), VisibleInLookupListView(false)]
        public Int32 ID { get; set; }
        [FieldSize(FieldSizeAttribute.Unlimited)]
        [VisibleInListView(true)]
        [EditorAlias(EditorAliases.CheckedListBoxEditor)]
        public string Members { get; set; }
        [CriteriaOptions("TypePermissionObject.TargetType")]
        [EditorAlias(EditorAliases.PopupCriteriaPropertyEditor)]
        [FieldSize(FieldSizeAttribute.Unlimited)]
        [DevExpress.ExpressApp.Model.ModelDefault("RowCount", "0")]
        [VisibleInListView(true), VisibleInDetailView(true)]
        public string Criteria { get; set; }
        [Browsable(false)]
        public int ReadState_Int { get; set; }
        [Browsable(false)]
        public int WriteState_Int { get; set; }
        [Browsable(false)]
        public PermissionPolicyTypePermissionObject TypePermissionObject { get; set; }
    }
}
