using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using DevExpress.Persistent.Base.General;

namespace EFDemo.Module.Data {
    [DefaultProperty("Name")]
    [MetadataType(typeof(CountryMetadata))]
    public partial class Country : ICountry {
        public override String ToString() {
            return Name;
        }
    }

    public class CountryMetadata {
        [Browsable(false)]
        public Int32 ID { get; set; }
    }
}
