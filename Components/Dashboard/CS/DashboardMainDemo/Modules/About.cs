using System;
using System.Drawing;
using System.Reflection;
using DevExpress.Utils.About;
using DevExpress.Tutorials;
using DevExpress.Utils;

namespace DashboardMainDemo.Modules {
    public partial class About : ucOverviewPage {
        public About() {
            InitializeComponent();
        }

        protected override Image Awards { get { return DevExpress.Tutorials.Properties.Resources.Awards_universal; } }
        protected override string Line1Text { get { return "DevExpress Dashboard"; } }
        protected override string Line2Text { get { return "Create elegant WinForms decision support systems with absolute ease."; } }
        protected override string Line3Text { get { return "DevExpress Dashboard ships as part of the Universal Subscription."; } }
        protected override string Line4Text { get { return "Voted best Component Set by readers of DevPro Magazine in 2013."; } }
        protected override ProductKind ProductKind { get { return ProductKind.Dashboard; } }
    }
}
