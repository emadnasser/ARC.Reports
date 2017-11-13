using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using DevExpress.Persistent.Base;
using DevExpress.Persistent.Base.General;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Filtering;

namespace EFDemo.Module.Data {
	[DefaultProperty("FullName")]
	[ImageName("BO_Person")]
	[MetadataType(typeof(PersonMetadata))]
	public partial class Person : IPerson {
		public void SetFullName(String fullName) {
			FirstName = fullName;
		}
		[SearchMemberOptions(SearchMemberMode.Exclude)]
		public String FullName {
			get { return ObjectFormatter.Format(FullNameFormat, this, EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty); }
		}
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override String DisplayName {
			get { return FullName; }
		}
		public static String FullNameFormat = "{FirstName} {MiddleName} {LastName}";

		DateTime IPerson.Birthday {
			get {
				if(Birthday.HasValue) {
					return Birthday.Value;
				}
				else {
					return DateTime.MinValue;
				}
			}
			set { Birthday = value; }
		}
	}

	public class PersonMetadata {
		[FieldSize(255)]
		public String Email { get; set; }
	}
}
