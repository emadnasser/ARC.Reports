using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp;

namespace EFDemo.Module.Data {
    [System.ComponentModel.DisplayName("Navigation Item Permissions")]
    [ImageName("BO_Security_Permission_Navigate")]
    [DefaultListViewOptions(true, NewItemRowPosition.Top)]
    [MetadataType(typeof(NavigationPermissionObjectMetadata))]
    public partial class PermissionPolicyNavigationPermissionObject : IPermissionPolicyNavigationPermissionObject {


        [DisplayName("Navigate")]
        public SecurityPermissionState? NavigateState {
            get {
                return (SecurityPermissionState?)NavigateState_Int;
            }
            set {
                NavigateState_Int = (Int32?)value;
            }
        }
        [Browsable(false)]
        IPermissionPolicyRole IPermissionPolicyNavigationPermissionObject.Role {
            get {
                return Role;
            }
        }
    }
    public class NavigationPermissionObjectMetadata {
        [Browsable(false)]
        public Int32 Id { get; set; }
        [Browsable(false)]
        public int NavigateState_Int { get; set; }
        [Browsable(false)]
        public PermissionPolicyRole Role { get; set; }
    }
}
