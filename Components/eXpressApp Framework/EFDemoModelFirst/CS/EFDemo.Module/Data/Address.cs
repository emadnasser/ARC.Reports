using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects.DataClasses;

using DevExpress.Persistent.Base;
using DevExpress.Persistent.Base.General;

namespace EFDemo.Module.Data {
	[DefaultProperty("FullAddress")]
	[MetadataType(typeof(AddressMetadata))]
	public partial class Address : IAddress {
		private const string defaultFullAddressFormat = "{Country.Name}; {StateProvince}; {City}; {Street}; {ZipPostal}";
		public String FullAddress {
			get { return ObjectFormatter.Format(AddressImpl.FullAddressFormat, this, EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty); }
		}
		ICountry IAddress.Country {
			get { return Country; }
			set { Country = value as Country; }
		}

		static Address() {
			AddressImpl.FullAddressFormat = defaultFullAddressFormat;
		}
		public static void SetFullAddressFormat(String format) {
			AddressImpl.FullAddressFormat = format;
		}
	}

	public class AddressMetadata {
		[Browsable(false)]
		public Int32 ID { get; set; }
		[Browsable(false)]
		public EntityCollection<Party> Parties1 { get; set; }
		[Browsable(false)]
		public EntityCollection<Party> Parties2 { get; set; }
	}
}
