using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Validation;
using System.Data.Entity.Core.Objects.DataClasses;

namespace EFDemo.Module.Data {
    [DefaultClassOptions]
    [ImageName("BO_Resume")]
    [MetadataType(typeof(ResumeMetadata))]
    public partial class Resume {
    }

    public class ResumeMetadata {
        [Browsable(false)]
        public Int32 ID { get; set; }

        [Aggregated]
        public EntityCollection<PortfolioFileData> Portfolio {
            get;
            set;
        }
        

        [Aggregated, ExpandObjectMembers(ExpandObjectMembers.Never)]
        public FileData File { get; set; }
    }
}
