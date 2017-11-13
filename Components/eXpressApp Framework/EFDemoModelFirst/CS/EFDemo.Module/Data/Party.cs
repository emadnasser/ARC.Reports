using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Drawing;
using System.Data.Entity.Core.Objects.DataClasses;
using System.ComponentModel.DataAnnotations;

using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.DC;

namespace EFDemo.Module.Data {
	[DefaultProperty("DisplayName")]
	[MetadataType(typeof(PartyMetadata))]
	public partial class Party {
		public override String ToString() {
			return DisplayName;
		}
		public abstract String DisplayName {
			get;
		}
	}

	public class PartyMetadata {
		[Browsable(false)]
		public Int32 ID { get; set; }
		[Aggregated, ExpandObjectMembers(ExpandObjectMembers.Never)]
		public Address Address1 { get; set; }
		[Aggregated, ExpandObjectMembers(ExpandObjectMembers.Never)]
		public Address Address2 { get; set; }
		[Aggregated]
		public EntityCollection<PhoneNumber> PhoneNumbers { get; set; }
        [ImageEditor]
        public Byte[] Photo { get; set; }
	}
}
