using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;

namespace DevExpress.VoteApp {
    public partial class VotesPanel : UserControl {
        public VotesPanel() {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
        }

        public float VotesTextSize {
            get {
                return lbVotesLeft.Font.Size;

            }
            set {
                if(VotesTextSize == value) return;
                Font fo = new Font(lbVotesLeft.Font.FontFamily, value, lbVotesLeft.Font.Style);
                lbVotesLeft.Font = fo;
                lbVotesRight.Font = fo;
            }
        }
        [Browsable(true)]
        public string VotesTextLeft {
            get { return lbVotesLeft.Text; }
            set { lbVotesLeft.Text = value ?? ""; }
        }
        public string VotesTextRight {
            get { return lbVotesRight.Text; }
            set { lbVotesRight.Text = value ?? ""; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int VotesCountLeft { get;  set;}
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int VotesCountRight { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int VotesCountTotal { get; set; }

        public Color ColorLeft { get; set; }
        public Color ColorRight { get; set; }

        void VotesPanel_Paint(object sender, PaintEventArgs e) {
            var perLeft = Helpers.GetPercent(VotesCountLeft, VotesCountTotal);
            var perRight = Helpers.GetPercent(VotesCountRight, VotesCountTotal);

            if(perLeft == 0 && perRight == 0) return;

            Rectangle bounds = ((Control)sender).ClientRectangle;
            GraphicsCache cache = new GraphicsCache(e);

            if(perLeft > 0) {
                Rectangle dem = bounds;
                dem.Width = (int)(Math.Round(dem.Width * perLeft));
                cache.FillRectangle(cache.GetSolidBrush(ColorLeft), dem);
            }
            if(perRight > 0) {
                Rectangle rep = bounds;
                rep.Width = (int)(Math.Round(rep.Width * perRight));
                rep.X = bounds.Right - rep.Width;
                cache.FillRectangle(cache.GetSolidBrush(ColorRight), rep);
            }
            Rectangle divider = bounds;
            divider.X += (int)(bounds.Width * 0.5m) - 1;
            divider.Width = 3;
            cache.FillRectangle(cache.GetSolidBrush(Color.FromArgb(200, Color.White)), divider);

        }
    }
}
