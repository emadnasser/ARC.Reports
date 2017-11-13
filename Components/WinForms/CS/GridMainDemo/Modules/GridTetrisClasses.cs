using System;
using System.Drawing; 
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;

namespace DevExpress.XtraGrid.Demos {
	public class Row {
		private int n = 0;
		public static int RowDetermination { get { return 1024; } }
		public static bool IsValue(int val, int pos) { return (val & 1 << pos) != 0; }
		private int IsUnit(int val, int pos) { return IsValue(val, pos) ? 1 : 0; }
		public Row(int val) { n = val; }
		public void SetValue(int val) { n = val; }
		internal int Val { get { return n; }}

		public bool R00 { get { return IsValue(n, 0); } }
		public bool R01 { get { return IsValue(n, 1); } }
		public bool R02 { get { return IsValue(n, 2); } }
		public bool R03 { get { return IsValue(n, 3); } }
		public bool R04 { get { return IsValue(n, 4); } }
		public bool R05 { get { return IsValue(n, 5); } }
		public bool R06 { get { return IsValue(n, 6); } }
		public bool R07 { get { return IsValue(n, 7); } }
		public bool R08 { get { return IsValue(n, 8); } }
		public bool R09 { get { return IsValue(n, 9); } }
		public bool R10 { get { return IsValue(n, 10); } }
	}

	public class MyCollection : CollectionBase, IBindingList {
		internal static int rows = 22;
		#region IBindingList
		public void Add(Row record) {
			base.List.Add(record);
		}
		public Row this[int idx] {
			get { return (Row) base.List[idx]; }
		}
		
		public int IndexOf(Row record) {
			return List.IndexOf(record);
		}

		public object AddNew() {
			Row record = new Row(0);
			List.Add(record);
			return record;
		}
		public bool AllowEdit { get { return true; }}
		public bool AllowNew { get { return true; }}
		public bool AllowRemove { get { return true; }}
				
		private ListChangedEventHandler listChangedHandler;
		public event ListChangedEventHandler ListChanged {
			add { listChangedHandler += value; }
			remove { listChangedHandler -= value; }
		}
		internal void OnListChanged(ListChangedEventArgs args) {
			if (listChangedHandler != null) listChangedHandler(this, args);
		}
		protected override void OnRemoveComplete(int index, object value) {
			OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, index) );
		}
		protected override void OnInsertComplete(int index,	object value) {
			OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, index) );
		}

		public void AddIndex(PropertyDescriptor pd) { throw new NotSupportedException(); }
		public void ApplySort(PropertyDescriptor pd, ListSortDirection dir) { throw new NotSupportedException(); }
		public int Find(PropertyDescriptor property, object key) { throw new NotSupportedException(); }
		public bool IsSorted { get { return false; }}
		public void RemoveIndex(PropertyDescriptor pd) { throw new NotSupportedException(); }
		public void RemoveSort() { throw new NotSupportedException(); }
		public ListSortDirection SortDirection { get { throw new NotSupportedException(); }}
		public PropertyDescriptor SortProperty { get { throw new NotSupportedException(); }}
		public bool SupportsChangeNotification {get { return true; }}
		public bool SupportsSearching {	get { return false; }}
		public bool SupportsSorting { get { return false; }}
		#endregion
		#region Collection methods
		public void Assign(MyCollection fCollection) {
			this.Init();
			for(int i = 0; i < fCollection.Count; i++)
				this[i].SetValue(fCollection[i].Val);
		}
		public void Invalidate() {
			this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, 0));
		}
		public void Init() {
			this.Clear();
			for(int i = 0; i < rows; i++) {
				this.Add(new Row(0));
			}
		}
		public void RemoveAndShiftAt(int i) {
			for(int j = i; j > 0; j--)
				this[j].SetValue(this[j - 1].Val);
			OnRemoveRow(new EventArgs());
		}
		private EventHandler removeRowHandler;
		public event EventHandler RemoveRow {
			add { removeRowHandler += value; }
			remove { removeRowHandler -= value; }
		}
		internal void OnRemoveRow(EventArgs args) {
			if (removeRowHandler != null) removeRowHandler(this, args);
		}
		#endregion
	}
	public class Figures {
		#region Static fFigures
		static int[] fFigures = new int[] {
											 1, 7, 0, 0, 4, 7, 0, 0, 2, 7, 0, 0, 3, 6, 0, 0, 6, 3, 0, 0, 6, 6, 0, 0, 15, 0, 0, 0, 5, 7, 0, 0, 2, 7, 2, 0, 2, 2, 7, 0, 7, 4, 4, 0, 1, 7, 4, 0,
											 4, 4, 6, 0, 6, 4, 4, 0, 2, 3, 2, 0, 4, 6, 2, 0, 2, 6, 4, 0, 6, 6, 0, 0, 4, 4, 4, 4, 6, 4, 6, 0, 2, 7, 2, 0, 4, 7, 4, 0, 7, 1, 1, 0, 6, 2, 3, 0, 
											 7, 4, 0, 0, 7, 1, 0, 0, 7, 2, 0, 0, 3, 6, 0, 0, 6, 3, 0, 0, 6, 6, 0, 0, 15, 0, 0, 0, 7, 5, 0, 0, 2, 7, 2, 0, 7, 2, 2, 0, 1, 1, 7, 0, 4, 7, 1, 0, 
											 6, 2, 2, 0, 2, 2, 6, 0, 2, 6, 2, 0, 4, 6, 2, 0, 2, 6, 4, 0, 6, 6, 0, 0, 4, 4, 4, 4, 3, 1, 3, 0, 2, 7, 2, 0, 1, 7, 1, 0, 4, 4, 7, 0, 3, 2, 6, 0}; 
		public static int FiguresNum { get { return 12; } }
		private static int[] GetFigure(int num, int fRotate) {
			int i = num * 4 + fRotate * FiguresNum * 4;
			return new int[] { fFigures[i], fFigures[i + 1], fFigures[i + 2], fFigures[i + 3] }; 
		}
		public static int[] GetFigure(int num) {
			return GetFigure(num, 0);
		}
		public static int[] GetFigure(int num, int oldRotate, int fRotate, int first) {
			int dx = first / GetFigure(num, oldRotate)[0];
			if(dx == 0) dx = 1;
			int[] ret = GetFigure(num, fRotate);
			for(int i = 0; i < ret.Length; i++) ret[i] = ret[i] * dx;
			return ret;
		}
		#endregion
	}

	public class Figure {
		#region Private fields
		private int fRow;
		private int fRotate;
		private int num; 
		private bool fEnd = false;
		private int[] fFigure, oldFigure;
		private MyCollection fCollection;
		private MyCollection master = new MyCollection();
		#endregion
		public Figure(int num, MyCollection fCollection) {
			fRow = 0;
			fRotate = 0;
			oldFigure = new int[] {0};
			this.fCollection = fCollection;
			master.Assign(fCollection);
			this.num = num;
			fFigure = Figures.GetFigure(num);
			for(int i = 0; i < fFigure.Length; i++) fFigure[i] = fFigure[i] * 16;
			oldFigure = fFigure;
			if(WrongFigure(fFigure)) fEnd = true;
			SetToCollection(fFigure);
		}
		#region Checking
		public bool EndOf { get { return fEnd; } }
		private bool WrongFigure(int[] a) {
			for(int i = 0; i < a.Length; i++)
				if((fRow + (a[i] > 0 ? i : 0) > fCollection.Count - 1) ||
					(a[i] > 0 && (a[i] & master[fRow + i].Val) != 0) ||
					a[i] > 2 * Row.RowDetermination - 1) return true;  
			return false;
		}
		private bool FirstColumn(int[] a) {
			for(int i = 0; i < a.Length; i++) 
				if((a[i] > 0 && (a[i] & Row.RowDetermination) != 0) || 
					(a[i] > 0 && (a[i] << 1 & master[fRow + i].Val) != 0)) return true;  
			return false;
		}
		private bool LastColumn(int[] a) {
			for(int i = 0; i < a.Length; i++)
				if((a[i] > 0 && (a[i] & 1) != 0) ||
					(a[i] > 0 && (a[i] >> 1 & master[fRow + i].Val) != 0)) return true;  
			return false;
		}
		public bool LastRow() {
			return LastRow(fFigure);
		}
		private bool LastRow(int[] a) {
			for(int i = a.Length - 1; i >= 0; i--) 
				if((fRow + (a[i] > 0 ? i : 0) > fCollection.Count - 2) ||
					(a[i] > 0 && (master[fRow + i + 1].Val & a[i]) != 0)) return true;
			return false;
		}
		#endregion
		#region Actions
		private int RotateStep {
			get { return fRotate; }
			set {
				if(value > 3) value = 0;
				if(value < 0) value = 3;
				int[] a = Figures.GetFigure(num, fRotate, value, fFigure[0]);
				if(a != null && !WrongFigure(a)) {
					fFigure = a;
					UnSetFromCollection(oldFigure);
					oldFigure = fFigure;
					fRotate = value;
					SetToCollection(fFigure);
				}
			}
		}
		public void GoLeft() {
			if(FirstColumn(fFigure)) return;
			UnSetFromCollection(oldFigure);
			oldFigure = fFigure;
			for(int i = 0; i < fFigure.Length; i++) fFigure[i] = fFigure[i] * 2;
			SetToCollection(fFigure);
		}
		public void GoRight() {
			if(LastColumn(fFigure)) return;
			UnSetFromCollection(oldFigure);
			oldFigure = fFigure;
			for(int i = 0; i < fFigure.Length; i++) fFigure[i] = fFigure[i] / 2;
			SetToCollection(fFigure);
		}
		public void GoBottom(bool invalidate) {
			for(;;) {
				if(LastRow(fFigure)) break;;
				UnSetFromCollection(oldFigure);
				fRow++;
				SetToCollection(fFigure, invalidate);
			}
			fCollection.Invalidate();
		}
		public void GoBottom() {
			if(LastRow(fFigure)) return;
			UnSetFromCollection(oldFigure);
			fRow++;
			SetToCollection(fFigure);
		}
		public void GoTop() {
			if(fRow == 0) return;
			UnSetFromCollection(oldFigure);
			fRow--;
			SetToCollection(fFigure);
		}
		public void Rotate() {
			Rotate(true);
		}
		public void Rotate(bool toRight) {
			if(toRight) RotateStep++; else RotateStep--;
		}
        #endregion
		#region Collection modernization
		public void DeleteTotalRows() {
			for(int i = fCollection.Count - 1; i >= 0; i--) 
				if(fCollection[i].Val == 2 * Row.RowDetermination - 1) { 
					fCollection.RemoveAndShiftAt(i); i++;
				}
		}
		private void UnSetFromCollection(int[] a) {
			for(int i = 0; i < a.Length; i++)
				if(a[i] != 0) fCollection[fRow + i].SetValue(fCollection[fRow + i].Val - a[i]);
		}
		private void SetToCollection(int[] a) { SetToCollection(a, true); }
		private void SetToCollection(int[] a, bool invalidate) {
			for(int i = 0; i < a.Length; i++)
				if(a[i] != 0) fCollection[fRow + i].SetValue(fCollection[fRow + i].Val + a[i]);
			if(invalidate) fCollection.Invalidate();
		}
		#endregion
	}

	public class ColumnHelper {
		public static void AddColumns(GridBand band, int num) {
			BandedGridColumn c = null;
			band.View.BeginUpdate();
			try { 
				for(int i = num; i >= 0; i--) {
					c =  band.View.Columns.AddField(string.Format("R{0:00}", i)) as BandedGridColumn;
					c.MinWidth = 10;
					band.Columns.Add(c);
					c.VisibleIndex = num - i;
				}
				int width = band.View.GridControl.Width / num;
				foreach(BandedGridColumn col in band.View.Columns)
					col.Width = width;
			} finally {
				band.View.EndUpdate(); 
			}
		}
	}

	public class TetrisGame {
		#region Private fields 
		ArrayList fPrevCollection;
		MyCollection fCollection = null; 
		Figure fFigure = null;
		Random rnd = new Random(System.Environment.TickCount);
		int fFigures = 0;
		int fRow = 0; 
		int fScore = 0; 
		int fLevel = 0;
		int nextFigure = 0;
		const int oneFigure = 5;
		const int oneRow = 100;
		const int changeLevelCriterion = 33;
		Color[] levelColors = new Color[] {Color.SteelBlue, Color.Green, Color.Red, Color.DarkBlue, Color.DarkGoldenrod, Color.Chocolate, Color.Black};
		Pen[] levelPens = new Pen[] {Pens.SteelBlue, Pens.Green, Pens.Red, Pens.DarkBlue, Pens.DarkGoldenrod, Pens.Chocolate, Pens.Black};
		#endregion
		#region Init
		public TetrisGame() {
			fCollection = new MyCollection();
			fCollection.RemoveRow += new EventHandler(removeRow);
			fPrevCollection = new ArrayList();
			for(int i = 0; i < 4; i++)
				fPrevCollection.Add(new Row(0));
		}
		public void Init() {
			nextFigure = rnd.Next(FiguresCount);
			fFigures = 0;
			Level = 0;
			Score = 0;
			TRow = 0;
			Collection.Init();
		}
		#endregion
		#region Public properties
		public int TRow { get { return fRow;} set { fRow = value; }}
		public MyCollection Collection { get { return fCollection; }}
		public ArrayList PrevCollection { get { return fPrevCollection; }}
		public Figure Figure { get { return fFigure; }}
		public int FiguresNum { 
			get { return fFigures; }
			set { 
				fFigures = value;
				if(fFigures > changeLevelCriterion) Level++;
			}
		}
		public int Score { 
			get { return fScore; }
			set { 
				fScore = value;
				OnChangeScore(new EventArgs());
			}
		}
		public int Level { 
			get { return fLevel; }
			set { 
				if(value < 7 && value >= 0) {
					fLevel = value;
					fFigures = 0;
					OnChangeLevel(new EventArgs());
					OnCreateFigure(new EventArgs());
				}
			}
		}
		public Color LevelColor {
			get { return levelColors[Level]; }
		}

		public Pen LevelPen {
			get { return levelPens[Level]; }
		}
		#endregion
		#region Functions
		private void SetPrevCollection(int fFigure) {
			int[] f = Figures.GetFigure(fFigure);
			for(int i = 0; i < 4; i++)
				((Row)PrevCollection[i]).SetValue(f[i]);
			OnCreateFigure(new EventArgs());
		}
		private int FiguresCount {
			get { return Figures.FiguresNum - (Level < 3 ? 5 : (Level < 5 ? 2 : 0)); }
		} 
		public void CreateNewFigure() {
			fFigure = new Figure(nextFigure, Collection);
			nextFigure = rnd.Next(FiguresCount);
			SetPrevCollection(nextFigure);
			FiguresNum++;
			Score += oneFigure * (Level + 1);
		}
		public void FillRow() {
			Collection[TRow].SetValue(2 * Row.RowDetermination - 1);
			Collection.Invalidate();
			TRow++;
		}
		#endregion
		#region Events
		void removeRow(object sender, EventArgs e) {
			Score += oneRow * (Level + 1);			
		}

		private EventHandler changeScoreHandler;
		public event EventHandler ChangeScore {
			add { changeScoreHandler += value; }
			remove { changeScoreHandler -= value; }
		}
		internal void OnChangeScore(EventArgs args) {
			if (changeScoreHandler != null) changeScoreHandler(this, args);
		}

		private EventHandler changeLevelHandler;
		public event EventHandler ChangeLevel {
			add { changeLevelHandler += value; }
			remove { changeLevelHandler -= value; }
		}
		internal void OnChangeLevel(EventArgs args) {
			if (changeLevelHandler != null) changeLevelHandler(this, args);
		}

		private EventHandler createFigureHandler;
		public event EventHandler CreateFigure {
			add { createFigureHandler += value; }
			remove { createFigureHandler -= value; }
		}
		internal void OnCreateFigure(EventArgs args) {
			if (createFigureHandler != null) createFigureHandler(this, args);
		}
		#endregion
	}
}

