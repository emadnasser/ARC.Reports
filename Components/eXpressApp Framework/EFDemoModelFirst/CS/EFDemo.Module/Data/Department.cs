using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using DevExpress.Persistent.Base;

namespace EFDemo.Module.Data {
    [DefaultClassOptions]
    [DefaultProperty("Title")]
    [MetadataType(typeof(DepartmentMetadata))]
    public partial class Department {
    }

    public class DepartmentMetadata {
        [Browsable(false)]
        public Int32 ID { get; set; }
    }
}
