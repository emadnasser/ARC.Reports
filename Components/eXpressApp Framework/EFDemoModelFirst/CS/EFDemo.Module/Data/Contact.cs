using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace EFDemo.Module.Data {
	[DefaultClassOptions]
	[MetadataType(typeof(ContactMetadata))]
	public partial class Contact : IObjectSpaceLink {
        IObjectSpace objectSpace;
		public Contact() {
		}
		public TitleOfCourtesy TitleOfCourtesy {
			get { return (TitleOfCourtesy)TitleOfCourtesy_Int; }
			set { TitleOfCourtesy_Int = (Int32)value; }
		}
        [NotMapped]
        [ImmediatePostData]
        public virtual Department DisplayDepartment {
            get { return Department; }
            set {
                Department = value;
                Position = null;
                if(Manager != null && Manager.Department != value) {
                    Manager = null;
                }
                objectSpace.SetModified(this);
            }
        }
        //IObjectSpaceLink
        IObjectSpace IObjectSpaceLink.ObjectSpace {
            get { return objectSpace; }
            set { objectSpace = value; }
        }
	}

	public class ContactMetadata {
		[DataSourceProperty("Department.Contacts", DataSourcePropertyIsNullMode.SelectAll)]
		[DataSourceCriteria("Position.Title = 'Manager'")]
		public Contact Manager { get; set; }
		
		[FieldSize(4096)]
		public String Notes { get; set; }

        [Browsable(false)]
        public virtual Department Department { get; set; }
	}
}
