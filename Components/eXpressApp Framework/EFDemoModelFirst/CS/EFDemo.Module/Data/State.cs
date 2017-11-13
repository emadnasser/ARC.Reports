using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EFDemo.Module.Data {
    [DefaultProperty("LongName")]
    [MetadataType(typeof(StateMetadata))]
    public partial class State {
    }

    public class StateMetadata {
        [Browsable(false)]
        public Int32 ID { get; set; }
    }
}
