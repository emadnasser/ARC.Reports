using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using DevExpress.Persistent.Base;

namespace EFDemo.Module.Data {
    [DefaultClassOptions]
    [MetadataType(typeof(PaymentMetadata))]
    public partial class Payment {
        public Decimal Amount {
            get { return Rate * Hours; }
        }
    }

    public class PaymentMetadata {
        [Browsable(false)]
        public Int32 ID { get; set; }
    }
}
