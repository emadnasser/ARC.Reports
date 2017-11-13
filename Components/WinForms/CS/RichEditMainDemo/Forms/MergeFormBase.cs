using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;

namespace DevExpress.XtraRichEdit.Demos.Forms {
    public enum MergeDestination { NewTab, File }
    public enum MergeRecords { All, Current, Selected, FromInterval }

    public class MergeFieldsFormBase : DevExpress.XtraEditors.XtraForm {
        MergeRecords mergeRecords;
        MergeDestination mergeDestination;

        protected MergeFieldsFormBase() {
        }

        public MergeDestination MergeDestination { get { return mergeDestination; } set { mergeDestination = value; } }
        public MergeRecords MergeRecords { get { return mergeRecords; } set { mergeRecords = value; } }
    }
}
