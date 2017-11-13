using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace EFDemo.Module.Data {
    [DefaultClassOptions]
    [DefaultProperty("Title")]
    [MetadataType(typeof(PositionMetadata))]
    public partial class Position {
    }

    public class PositionMetadata {
        [Browsable(false)]
        public Int32 ID { get; set; }
        [RuleRequiredField("RuleRequiredField for Position.Title", DefaultContexts.Save)]
        public String Title { get; set; }
    }
}
