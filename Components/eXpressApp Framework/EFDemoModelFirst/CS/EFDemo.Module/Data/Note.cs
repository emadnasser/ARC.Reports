using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using DevExpress.Persistent.Base.General;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.DC;

namespace EFDemo.Module.Data {
    [DefaultProperty("Text")]
    [MetadataType(typeof(NoteMetadata))]
    public partial class Note : INote {
        DateTime INote.DateTime {
            get {
                if(DateTime.HasValue) {
                    return DateTime.Value;
                }
                else {
                    return System.DateTime.MinValue;
                }
            }
            set { DateTime = value; }
        }
    }

    public class NoteMetadata {
        [Browsable(false)]
        public Int32 ID { get; set; }
		[FieldSize(FieldSizeAttribute.Unlimited)]
        public String Text { get; set; }
    }
}
