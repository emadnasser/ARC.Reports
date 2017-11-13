using System;
using DevExpress.Utils.Menu;
using DevExpress.XtraCharts.Demos.PointLineViews;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.ChartElements {
	public partial class LegendDemo : ChartDemoBase2D {
		ChartControl chart;
        DXSubMenuItem menuLegendVertItem;
        DXSubMenuItem menuLegendHorItem;

		public override ChartControl ChartControl { get { return chart; } }

		public LegendDemo() {
			InitializeComponent();
		}

		void AddDirectionClickHandlers(DXMenuItem directionItem) {
            DXSubMenuItem item = (DXSubMenuItem)directionItem;
            item.Items[0].Click += LegendDirectionItem0Click;
            item.Items[1].Click += LegendDirectionItem1Click;
            item.Items[2].Click += LegendDirectionItem2Click;
            item.Items[3].Click += LegendDirectionItem3Click;
		}
        void LegendDirectionItem0Click(object sender, EventArgs e) {
            cbEquallySpacedItems.Enabled = false;
            cbDirection.SelectedIndex = 0;
        }
        void LegendDirectionItem1Click(object sender, EventArgs e) {
            cbEquallySpacedItems.Enabled = false;
            cbDirection.SelectedIndex = 1;
        }
        void LegendDirectionItem2Click(object sender, EventArgs e) {
            cbEquallySpacedItems.Enabled = true;
            cbDirection.SelectedIndex = 2;
        }
        void LegendDirectionItem3Click(object sender, EventArgs e) {
            cbEquallySpacedItems.Enabled = true;
            cbDirection.SelectedIndex = 3;
        }
        void AddVertAlignmentClickHandlers(DXMenuItem vertItem) {
            menuLegendVertItem = (DXSubMenuItem)vertItem;
            for (int i = 0; i < menuLegendVertItem.Items.Count; i++)
                menuLegendVertItem.Items[i].Click += LegendVertAlignmentClick;
		}
		void AddHorAlignmentClickHandlers(DXMenuItem horItem) {
            menuLegendHorItem = (DXSubMenuItem)horItem;
            for (int i = 0; i < menuLegendHorItem.Items.Count; i++)
                menuLegendHorItem.Items[i].Click += LegendHorAlignmentClick;
		}
        void LegendVertAlignmentClick(object sender, EventArgs e) {
            cbVertAlign.SelectedIndex = GetCheckedAlign((DXMenuItem)sender, menuLegendVertItem);
        }
        void LegendHorAlignmentClick(object sender, EventArgs e) {
            cbHorAlign.SelectedIndex = GetCheckedAlign((DXMenuItem)sender, menuLegendHorItem);
        }
        string GetValueWithoutPercent(string val) {
			return val.Trim(new char[] { '%' });
		}
		string AddPercentToString(string val) {
			return val + "%";
		}
		void UpdateEquallySpacedItemsEnable() {
			cbEquallySpacedItems.Enabled = ChartControl.Legend.Direction == LegendDirection.LeftToRight ||
				ChartControl.Legend.Direction == LegendDirection.RightToLeft;
		}
		int GetCheckedAlign(DXMenuItem sender, DXSubMenuItem item) {
            if (item != null) {
                for (int index = 0; index < item.Items.Count; index++)
                    if (object.ReferenceEquals(item.Items[index], sender))
                        return index;
            }
			return -1;
		}
		void InitSeries() {
			Random random = new Random();
			for (int i = 0; i < chart.Series.Count; i++) {
				chart.Series[i].Points.Clear();
				chart.Series[i].Points.AddRange(RandomPointCalculator.Calculate(random, 5, 1, 10, 1, 10));
			}
		}
		void chart_VisibleChanged(object sender, EventArgs e) {
			InitSeries();
		}
		void itemVertAlignment_Click(object sender, EventArgs e) {
			cbVertAlign.SelectedIndex = (int)ChartControl.Legend.AlignmentVertical;
		}
        void UpdateLegendMargins() {
            LegendAlignmentHorizontal hAlignment = chart.Legend.AlignmentHorizontal;
            LegendAlignmentVertical vAlignment = chart.Legend.AlignmentVertical;
            if ((object.Equals(hAlignment, LegendAlignmentHorizontal.Left) || object.Equals(hAlignment, LegendAlignmentHorizontal.Center) || object.Equals(hAlignment, LegendAlignmentHorizontal.Right))
                && (object.Equals(vAlignment, LegendAlignmentVertical.Bottom) || object.Equals(vAlignment, LegendAlignmentVertical.Center) || object.Equals(vAlignment, LegendAlignmentVertical.Top)))
                chart.Legend.Margins.All = 10;
            else
                chart.Legend.Margins.All = 5;
        }
		void itemHorAlignment_Click(object sender, EventArgs e) {
			cbHorAlign.SelectedIndex = (int)ChartControl.Legend.AlignmentHorizontal;
		}
		void cbEquallySpacedItems_CheckedChanged(object sender, EventArgs e) {
			if (chart.Legend.Direction == LegendDirection.LeftToRight || 
				chart.Legend.Direction == LegendDirection.RightToLeft)
					ChartControl.Legend.EquallySpacedItems = cbEquallySpacedItems.Checked;
		}
		void cmbMaxHorPercentage_SelectedIndexChanged(object sender, EventArgs e) {
			string value = GetValueWithoutPercent(cmbMaxHorPercentage.Text);
			ChartControl.Legend.MaxHorizontalPercentage = Convert.ToDouble(value);
		}
		void cmbMaxVertPercentage_SelectedIndexChanged(object sender, EventArgs e) {
			string value = GetValueWithoutPercent(cmbMaxVertPercentage.Text);
			ChartControl.Legend.MaxVerticalPercentage = Convert.ToDouble(value);
		}
		void cbDirection_SelectedIndexChanged(object sender, EventArgs e) {
			ComboBoxEdit edit = sender as ComboBoxEdit;
			if (edit != null) {
    			ChartControl.Legend.Direction = (LegendDirection)edit.SelectedIndex;
	    		if (edit.SelectedIndex == 0 || edit.SelectedIndex == 1)
		    		cbEquallySpacedItems.Enabled = false;
			    else
				    cbEquallySpacedItems.Enabled = true;
            }
		}
		void cbHorAlign_SelectedIndexChanged(object sender, EventArgs e) {
			ComboBoxEdit edit = sender as ComboBoxEdit;
            if (edit != null) {
                ChartControl.Legend.AlignmentHorizontal = (LegendAlignmentHorizontal)edit.SelectedIndex;
                UpdateLegendMargins();
            }
		}
		void cbVertAlign_SelectedIndexChanged(object sender, EventArgs e) {
			ComboBoxEdit edit = (sender) as ComboBoxEdit;
            if (edit != null) {
                ChartControl.Legend.AlignmentVertical = (LegendAlignmentVertical)edit.SelectedIndex;
                UpdateLegendMargins();
            }
		}
		
        protected override DXPopupMenu ConstructPopupMenu(object obj, ChartControl chartControl) {
			DXPopupMenu menu = base.ConstructPopupMenu(obj, chartControl);
			if (obj is Legend) {
				AddHorAlignmentClickHandlers(menu.Items[4]);
				AddVertAlignmentClickHandlers(menu.Items[5]);
				AddDirectionClickHandlers(menu.Items[6]);
			}
			return menu;
		}
		protected override void InitControls() {
			base.InitControls();
            CheckEditShowLabelsVisible = false;
			UpdateEquallySpacedItemsEnable();
			cbEquallySpacedItems.Checked = chart.Legend.EquallySpacedItems;
			cmbMaxHorPercentage.Text = AddPercentToString(ChartControl.Legend.MaxHorizontalPercentage.ToString());
			cmbMaxVertPercentage.Text = AddPercentToString(ChartControl.Legend.MaxVerticalPercentage.ToString());
			cbDirection.SelectedIndex = (int)ChartControl.Legend.Direction;
			cbHorAlign.SelectedIndex = (int)ChartControl.Legend.AlignmentHorizontal;
			cbVertAlign.SelectedIndex = (int)ChartControl.Legend.AlignmentVertical;
		}
        
        public override void UpdateControls() {
            base.UpdateControls();
            cbVertAlign.SelectedIndex = (int)chart.Legend.AlignmentVertical;
            cbHorAlign.SelectedIndex = (int)chart.Legend.AlignmentHorizontal;
            cbDirection.SelectedIndex = (int)chart.Legend.Direction;
            cbEquallySpacedItems.Checked = chart.Legend.EquallySpacedItems;
        }
	}
}
