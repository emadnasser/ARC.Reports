using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils;

namespace DevExpress.ActiveDemos {

	[Bindable(false)]
	class ToolTipCollection : CollectionBase {
		public ToolTipCollection() {}

	}

	public class ActiveDemo : IDisposable {
		ActiveActions factions;
		ToolTipController toolTipCancelOnEscape;
		ToolTipControllerShowEventArgs toolTipCancelOnEscapeShowArgs;

		void InitProperties() {
			this.factions = new ActiveActions();
			this.toolTipCancelOnEscape = new ToolTipController();
			this.toolTipCancelOnEscapeShowArgs = this.toolTipCancelOnEscape.CreateShowArgs();
			this.toolTipCancelOnEscapeShowArgs.AutoHide = false;
            this.toolTipCancelOnEscapeShowArgs.AllowHtmlText = DefaultBoolean.False;
			this.toolTipCancelOnEscapeShowArgs.IconSize = ToolTipIconSize.Large;
			this.toolTipCancelOnEscapeShowArgs.ToolTip = DevExpress.XtraGrid.Demos.Properties.Resources.ActiveDemoStop;
			this.toolTipCancelOnEscapeShowArgs.IconType = ToolTipIconType.Information;
		}
		public ActiveDemo() {
			InitProperties();
			ShowCancelonEscape();
		}
		public void Dispose() {
			Actions.Dispose();
			this.factions = null;
			toolTipCancelOnEscape.HideHint();
			toolTipCancelOnEscape.Dispose();
			toolTipCancelOnEscape = null;
		}
		public ActiveActions Actions { get { return this.factions; } }
		public void MoveMouseFromPoint(int deltaX, int deltaY) {
			Point pt = Cursor.Position;
			pt.X += deltaX;
			pt.Y += deltaY;
			Actions.MoveMousePointTo(pt);
		}
		public void ShowMessage(string text) {
			ShowMessage(text, Cursor.Position);
		}
		public void ShowMessage(string text, Point pt) {
			if(text.Length == 0 || Actions.Canceled) return;
			int delay = 400 + text.Length * 30;
			//int delay = 100;
			text = "\n" + text + "\n ";
			ToolTipController toolTip = new ToolTipController();
			ToolTipControllerShowEventArgs toolTipShowArgs = this.toolTipCancelOnEscape.CreateShowArgs();
			toolTipShowArgs.AutoHide = false;
			toolTipShowArgs.ToolTip = text;
			toolTipShowArgs.IconSize = ToolTipIconSize.Large;
			toolTipShowArgs.IconType = ToolTipIconType.Information;
			toolTipShowArgs.ToolTipLocation = ToolTipLocation.BottomRight;
			toolTipShowArgs.ShowBeak = true;
			toolTipShowArgs.Rounded = true;
            toolTipShowArgs.AllowHtmlText = DefaultBoolean.False;
			toolTip.ShowHint(toolTipShowArgs, pt);
			ActiveActions.DoEvents();
			int i = 0;
			while (i < delay && ! Actions.Canceled) {
				ActiveActions.Delay(20);
				i += 20;
				ActiveActions.DoEvents();
			}
			toolTip.HideHint();
			toolTip.Dispose();
		}
		protected Point GetPointAtCenter(Rectangle r) {
			return new Point(r.Left + r.Width / 2, r.Top + r.Height / 2);
		}
		
		void IDisposable.Dispose() {
			this.Dispose();
		}
		void ShowCancelonEscape() {
			this.toolTipCancelOnEscape.ShowHint(this.toolTipCancelOnEscapeShowArgs, new Point(10, 10));
		}
	}

	public class ActiveDemoResults: IDisposable {
		Control fparent;
		ResultForm fform;
		public ActiveDemoResults(Control fparent) {
			this.fparent = fparent;
		}
		public void Dispose() {
			if(this.fform != null) {
				this.fform.Dispose();
				this.fform = null;
			}
		}
		void IDisposable.Dispose() {
			this.Dispose();
		}
		public void Show() {
			Form.Show();
		}
		public void Hide() {
			if(this.fform != null)
				this.fform.Hide();
		}
		public void Add(string text) {
            if (Form == null) return;
			if(! Form.Visible)
				Show();
			Form.Add(text);
		}
		public void Clear() {
			if(this.fform != null)
				this.fform.Clear();
		}
		ResultForm Form {
			get {
				if(this.fform == null)
					this.fform = CreateResultForm();
				return this.fform;
			}
		}
		ResultForm CreateResultForm() {
            if (fparent.IsDisposed) return null;
			ResultForm resultForm = new ResultForm();
			Rectangle r = fparent.RectangleToScreen(fparent.Bounds);
			//TODO ActiveForm -> MainForm
			resultForm.Left = r.Right - resultForm.Width;
			resultForm.Top = r.Bottom - resultForm.Height;

			resultForm.Disposed += new EventHandler(ResultFormDisposed);
			return resultForm;
		}
		void ResultFormDisposed(object sender, EventArgs e) {
			this.fform = null;
		}
		class ResultForm: Form {
			TextBox textBox;
			public ResultForm() {
				TopMost = true;
				Text = DevExpress.XtraGrid.Demos.Properties.Resources.ActiveDemoResult; 
				FormBorderStyle = FormBorderStyle.FixedToolWindow;
				MaximizeBox = false;
				MinimizeBox = false;
				ShowInTaskbar = false;
				Width = 200;
				Height = 200;
				StartPosition = FormStartPosition.Manual;
				this.textBox = new TextBox();
				this.textBox.Dock = DockStyle.Fill;
				this.textBox.Multiline = true;
				this.textBox.WordWrap = true;
				this.textBox.Parent = this;
			}
			public void Add(string text) {
				this.textBox.Text += text + System.Environment.NewLine;
				//TODO move cursor
			}
			public void Clear() {
				this.textBox.Clear();
			}
		}
	}
}
