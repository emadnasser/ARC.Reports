using System;
using System.Collections;
using System.Reflection;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.XtraGrid.Views.BandedGrid;

namespace DevExpress.XtraGrid.Demos {
	public partial class GridTetris : TutorialControl {
		public GridTetris() {
			InitializeComponent();
			gridControl.ForceInitialize();
			gridControl2.ForceInitialize();
			bandedGridView2.Appearance.Row.BackColor = Color.Transparent;
			bandedGridView2.Appearance.Empty.BackColor = Color.Transparent;
			gridControl2.BackColor = Color.Transparent;
			InitRowHeight();
		}
        TetrisGame game;
        int iColunms = 10;
        int iPrevColumns = 3;
        int rowHeight = 0;
        bool gameEnd = false;
        int dx = 10;

        protected override bool AllowAppearanceGroup { get { return false; } }
		protected override void DoShow() {
            base.DoShow();
			gridControl.Focus();
			if(!timer1.Enabled) SetPause();
		}
		protected override void DoHide() {
			if(timer1.Enabled) SetPause();
		}

		Image GetImageFromRes(int level) {
			string name = string.Format("DevExpress.XtraGrid.Demos.BackGrounds.{0}.jpg", level += 1);
			System.IO.Stream str = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
			return Image.FromStream(str);
		}
		 
		private void GridTetris_Load(object sender, System.EventArgs e) {
			InitSize();
			game = new TetrisGame();
			gridControl2.GotFocus += new EventHandler(OnGotFocus);
			game.ChangeScore += new EventHandler(changeScore);
			game.ChangeLevel += new EventHandler(changeLevel);
			game.CreateFigure += new EventHandler(createFigure);
			ColumnHelper.AddColumns(gridBand1, iColunms);
			ColumnHelper.AddColumns(gridBand2, iPrevColumns);
			gridControl2.DataSource = game.PrevCollection;
			InitNew();	
		}

		void InitSize() {
			ResizeGrid();
			RecalculatePositions();
		}

		void OnGotFocus(object sender, EventArgs e) {
			gridControl.Focus();
		}

		
		void InitRowHeight() {
			BandedGridViewInfo vi = GetBandedGridViewInfo(bandedGridView);
			rowHeight = 19;
			bandedGridView.RowHeight = bandedGridView2.RowHeight = rowHeight;
		}

		private void ResizeGrid() {
			int w = 24;
			gridControl.Width = (iColunms + 1) * w + 2;
			gridControl2.Width = (iPrevColumns + 1) * w + 2;
			BandedGridViewInfo vi = GetBandedGridViewInfo(bandedGridView);
			if(vi.MinRowHeight > rowHeight) rowHeight = vi.MinRowHeight;
			gridControl.Height = rowHeight * MyCollection.rows + vi.BandRowHeight + 2;
			gridControl2.Height = rowHeight * 4;
			panel1.Left = gridControl.Left + gridControl.Width + 10; 
			panel1.Width = simpleButton1.Width;
		}

		private void InitNew() {
			gameEnd = false;
			gridControl.DataSource = null;
			game.Init();
			gridControl.DataSource = game.Collection;
			CreateNewFigure();
			timer2.Stop();
			timer1.Start();
			SetCaption();
		}

		private void changeScore(object sender, EventArgs e) {
			label1.Text = string.Format("{1}: {0}", game.Score, Properties.Resources.Score);
		}

		private void changeLevel(object sender, EventArgs e) {
			label2.Text = string.Format("{1}: {0}", game.Level, Properties.Resources.Level);
			timer1.Interval = 400 - game.Level * 40;
			gridControl.BackgroundImage = GetImageFromRes(game.Level);	
		}

		private void createFigure(object sender, EventArgs e) {
			bandedGridView2.LayoutChanged();
		}

		private void bandedGridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
			if(e.CellValue == null) return;
			bool IsUnit = (bool)e.CellValue;
			System.Drawing.Drawing2D.LinearGradientBrush b = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.White, game.LevelColor, 45);
			Rectangle r = e.Bounds;
			if(IsUnit) {
				e.Graphics.FillRectangle(b, r);
				r.Inflate(1, 1);
				r.Width--; r.Height--;
				e.Graphics.DrawRectangle(game.LevelPen, r);
			}
			e.Handled = true;
		}

		private void CreateNewFigure() {
			game.CreateNewFigure();
			ExitOf();
		}

		private void ExitOf() {
			if(game.Figure.EndOf) {
				timer1.Stop();
				timer2.Start();
			}
		}

		#region Timers
		private void timer1_Tick(object sender, System.EventArgs e) {
			if(game.Figure.LastRow()) {
				game.Figure.DeleteTotalRows();
				CreateNewFigure();
				GC.Collect();
				return;
			}
			game.Figure.GoBottom();
		}
		
		
		private void timer2_Tick(object sender, System.EventArgs e) {
			gameEnd = true;
			if(game.TRow < game.Collection.Count) {
				game.FillRow();
			} else {
				timer2.Stop();
				gridBand1.Caption = Properties.Resources.GameOver;
			}
		}
		#endregion

		private void SetCaption() {
			gridBand1.Caption = timer1.Enabled ? Properties.Resources.Playing : Properties.Resources.Pause;
		}

		private void SetPause() {
			if(timer2.Enabled) return;
			if(gameEnd) 
				InitNew();
			else {
				timer1.Enabled = !timer1.Enabled; 
				SetCaption();
			}
		}
		
		private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
			if(e.KeyCode == Keys.P || e.KeyCode == Keys.Pause) SetPause();
			if(!timer1.Enabled) return;
			Application.DoEvents();
			if(e.KeyCode == Keys.Left) game.Figure.GoLeft();
			if(e.KeyCode == Keys.Right) game.Figure.GoRight();
			if(e.KeyCode == Keys.Down) game.Figure.GoBottom();
			if(e.KeyCode == Keys.Space) {
				if(gameEnd) return;
				timer1.Stop();
				game.Figure.GoBottom(false);
				game.Figure.DeleteTotalRows();
				timer1.Start();
				CreateNewFigure();
				GC.Collect();
			}
			if(e.KeyCode == Keys.Up || e.KeyCode == Keys.X) game.Figure.Rotate();
			if(e.KeyCode == Keys.Z) game.Figure.Rotate(false);
			if(e.KeyCode == Keys.Insert) game.Level += (e.Shift ? -1 : 1);
		}

		private void simpleButton1_Click(object sender, System.EventArgs e) {
			InitNew();
			gridControl.Focus();
		}

		public static BandedGridViewInfo GetBandedGridViewInfo(BandedGridView gridView) {
			PropertyInfo propertyInfo = gridView.GetType().GetProperty("ViewInfo", BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.NonPublic, null, typeof(BandedGridViewInfo), new Type[0], null);
			if(propertyInfo != null)
				return propertyInfo.GetValue(gridView, null) as BandedGridViewInfo;
			else return null;
		}

		
		void RecalculatePositions() {
			gridControl.Top = (gridControl.Parent.Height - gridControl.Height) / 2;
			gridControl.Left = (gridControl.Parent.Width - gridControl.Width - panel1.Width - dx) / 2;
			panel1.Top = gridControl.Top;
			panel1.Left = gridControl.Left + gridControl.Width + dx; 
			panel1.Height = gridControl.Height;
		}
		private void GridTetris_Resize(object sender, System.EventArgs e) {
			RecalculatePositions();
		}

		private void panelClient_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
			ControlPaint.DrawBorder3D(e.Graphics, gridControl.Left - dx, gridControl.Top - dx, 
				gridControl.Width + panel1.Width + dx * 3, gridControl.Height + dx * 2, Border3DStyle.Bump);
		}
	}
}

