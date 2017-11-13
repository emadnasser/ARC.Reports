using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Filtering;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Security;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Base.Security;
using DevExpress.Xpo.Metadata;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security;
using System.Text;

namespace XCRM.Module.Data {
	[DisplayProperty("DisplayName")]
	[VisibleInReports(false)]
    [ImageName("BO_User")]
    public class DCUser : DevExpress.Persistent.BaseImpl.EF.User {
		public DCUser() : base() {
		}

        [SearchMemberOptions(SearchMemberMode.Exclude)]
		public String DisplayName { get; set; }
    }

    [VisibleInReports(false)]
    [ImageName("BO_Role")]
    public class PersistentRole : DevExpress.Persistent.BaseImpl.EF.Role {
        public PersistentRole() : base() {
        }
    }
}
