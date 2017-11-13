using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Office.Utils;

namespace DevExpress.XtraRichEdit.Demos.Forms {
    public partial class SelectManagerForm : SelectProductForm {
        readonly List<string> infos;
        readonly List<string> managers;
        public SelectManagerForm(List<string> managers, List<string> infos)
            : base(managers) {
            Guard.ArgumentNotNull(infos, "infos");
            if (managers.Count != infos.Count)
                Exceptions.ThrowArgumentException("infos", infos);
            this.infos = infos;
            this.managers = managers;
            InitializeComponent();
        }

        protected override void SetEditValueCore(object value) {
            string item = (string)value;
            int index = managers.IndexOf(item);
            if (index < 0)
                return;
            base.SetEditValueCore(String.Format("{0}, {1}", item, infos[index]));
        }
    }
}
