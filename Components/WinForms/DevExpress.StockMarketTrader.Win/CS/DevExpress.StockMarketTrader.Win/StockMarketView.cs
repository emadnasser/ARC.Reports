using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.StockMarketTrader.Tiles;
using DevExpress.StockMarketTrader.ViewModel;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraSplashScreen;

namespace DevExpress.StockMarketTrader {
    public partial class StockMarketView : XtraForm {
        public static RealTimeDataViewModel defaultViewModel = null;
        public StockMarketView() {
            SplashScreenManager.ShowForm(this, typeof(SplashScreen1), true, true);

            InitializeComponent();

            defaultViewModel = new RealTimeDataViewModel(new System.Windows.Forms.Timer());
            logoPanel.Appearance.Image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(@"DevExpress.StockMarketTrader.Images.LogoStockMarket.png"));
            poweredByPanel.Appearance.Image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(@"DevExpress.StockMarketTrader.Images.WhiteLogo.png"));
            Load += StockMarketView_Load;
        }
        void StockMarketView_Load(object sender, EventArgs e) {
            SplashScreenManager.CloseForm();
            ShowIcon = true;
            Icon = new Icon(Assembly.GetExecutingAssembly().GetManifestResourceStream(@"DevExpress.StockMarketTrader.Images.DX.ico"));
            stockWorkspacesUC2.panelContainer1.Size = new Size((int)(Width * 0.33), stockWorkspacesUC2.panelContainer1.Height);
        }
      
        protected Image DrawControlToImage(Control control) {
            Bitmap bmp = new Bitmap(control.Width, control.Height);
            control.Invalidate();
            control.DrawToBitmap(bmp, new Rectangle(Point.Empty, control.Size));
            return bmp;
        }
    }
}
