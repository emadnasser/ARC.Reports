using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using DevExpress.Persistent.Base.General;

namespace EFDemo.Module.Data {
    [DefaultProperty("Number")]
    [MetadataType(typeof(PhoneNumberMetadata))]
    public partial class PhoneNumber : IPhoneNumber {
        public override String ToString() {
            return Number;
        }
    }

    public class PhoneNumberMetadata {
        [Browsable(false)]
        public Int32 ID { get; set; }
    }
}
