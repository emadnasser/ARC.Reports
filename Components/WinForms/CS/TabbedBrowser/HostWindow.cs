using System;
using System.Collections.Generic;
using System.Drawing;

namespace TabbedBrowser {
    public partial class HostWindow : RootMainForm {
        RootMainForm rootForm;
        public HostWindow(Dictionary<string, DateTime> allHistory, RootMainForm Form) :
            base(allHistory, Form.WindowState) {
            InitializeComponent();
            IsInitialized = false;
            rootForm = Form;
        }
    }
}
