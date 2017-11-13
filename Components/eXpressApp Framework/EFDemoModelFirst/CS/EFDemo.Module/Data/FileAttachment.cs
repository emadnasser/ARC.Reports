using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace EFDemo.Module.Data {
    [DefaultProperty("File")]
    [FileAttachmentAttribute("File")]
    [MetadataType(typeof(FileAttachmentMetadata))]
    public partial class FileAttachment {
    }

    public class FileAttachmentMetadata {
        [Browsable(false)]
        public Int32 ID { get; set; }
        [RuleRequiredField("FileAttachmentBaseRule", "Save", "File should be assigned")]
        [ExpandObjectMembers(ExpandObjectMembers.Never)]
        public FileData File { get; set; }
    }
}
