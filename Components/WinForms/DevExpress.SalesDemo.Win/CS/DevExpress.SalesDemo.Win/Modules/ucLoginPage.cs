namespace DevExpress.SalesDemo.Win.Modules {
    public partial class ucLoginPage : BaseModule {
        public ucLoginPage() {
            InitializeComponent();
        }
        public override void OnNavigatedTo(XtraBars.Docking2010.Views.WindowsUI.INavigationArgs args) {
            textBox1.Text = args.Parameter as string;
            textBox2.Text = null;
        }
        public override void OnNavigatedFrom(XtraBars.Docking2010.Views.WindowsUI.INavigationArgs args) {
            args.Parameter = textBox1.Text;
        }
    }
}
