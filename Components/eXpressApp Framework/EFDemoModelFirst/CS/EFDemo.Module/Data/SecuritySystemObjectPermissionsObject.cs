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

namespace EFDemo.Module.Data {
    [System.ComponentModel.DisplayName("Object Operation Permissions")]
    [ImageName("BO_Security_Permission_Object")]
    [DefaultListViewOptions(true, NewItemRowPosition.Top)]
    [MetadataType(typeof(ObjectPermissionsObjectMetadata))]
    public partial class PermissionPolicyObjectPermissionsObject : IOwnerInitializer, IPermissionPolicyObjectPermissionsObject {
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
        IPermissionPolicyTypePermissionObject IPermissionPolicyObjectPermissionsObject.TypePermissionObject {
            get {
                return TypePermissionObject;
            }
        }

        #region IOwnerInitializer Members
        void IOwnerInitializer.SetMasterObject(object masterObject) {
            PermissionPolicyTypePermissionObject typePermission = masterObject as PermissionPolicyTypePermissionObject;
            if(typePermission != null) {
                TypePermissionObject = typePermission;
            }
        }
        #endregion
    }
    public class ObjectPermissionsObjectMetadata {
        [VisibleInDetailView(false), VisibleInListView(false), VisibleInLookupListView(false)]
        public Int32 ID { get; set; }
        [FieldSize(FieldSizeAttribute.Unlimited)]
        [CriteriaOptions("TypePermissionObject.TargetType")]
        [VisibleInListView(true)]
        [EditorAlias(EditorAliases.PopupCriteriaPropertyEditor)]
        public string Criteria { get; set; }
        [Browsable(false)]
        public int DeleteState_Int { get; set; }
        [Browsable(false)]
        public int NavigateState_Int { get; set; }
        [Browsable(false)]
        public int ReadState_Int { get; set; }
        [Browsable(false)]
        public int WriteState_Int { get; set; }
        [Browsable(false)]
        public PermissionPolicyTypePermissionObject TypePermissionObject { get; set; }
    }
}
