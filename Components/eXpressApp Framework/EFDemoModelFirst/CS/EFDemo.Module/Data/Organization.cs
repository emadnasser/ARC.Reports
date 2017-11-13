using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.DC;

namespace EFDemo.Module.Data {
    [MetadataType(typeof(OrganizationMetadata))]
    public partial class Organization {
        public override String DisplayName {
            get { return Name; }
        }
    }

    public class OrganizationMetadata {
		[FieldSize(4096)]
        public String Description { get; set; }
    }
}
