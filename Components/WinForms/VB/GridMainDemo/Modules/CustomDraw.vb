Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Data.OleDb
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.Data
Imports DevExpress.Utils.Frames

Namespace DevExpress.XtraGrid.Demos
	Partial Public Class CustomDraw
		Inherits TutorialControl

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			CreateWaitDialog()
			InitializeComponent()
			InitAppearances()
			InitMenu()
			InitNWindData()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub
		Private groupPanelImage As Bitmap
		Private appCustomFocusedColumn, appCustomFilterPanel, appCustomPrice As AppearanceDefault

		#Region "Init"
		Private ReadOnly Property CurrentGrid() As GridControl
			Get
				Return gridControl1
			End Get
		End Property
		Private ReadOnly Property CurrentView() As GridView
			Get
				Return advBandedGridView1
			End Get
		End Property
		Private ReadOnly Property ProductGrid() As GridControl
			Get
				Return gridControl2
			End Get
		End Property
		Private ReadOnly Property ProductView() As GridView
			Get
				Return gridView1
			End Get
		End Property

		Private Sub InitMenu()
			gridView1.PaintStyleName = "MixedXP"
		End Sub
		Protected Overrides Sub InitMDBData(ByVal connectionString As String)
			Dim ds As New DataSet()
			Dim oleDBAdapter As New OleDbDataAdapter("SELECT * FROM Products", connectionString)
			SetWaitDialogCaption(My.Resources.LoadingProducts)
			oleDBAdapter.Fill(dsNWindProducts1.Products)

			oleDBAdapter = New OleDbDataAdapter("SELECT * FROM [Order Details]", connectionString)
			SetWaitDialogCaption(My.Resources.LoadingOrderDetails)
			oleDBAdapter.Fill(dsNWindProducts1.Order_Details)

			oleDBAdapter = New OleDbDataAdapter("SELECT * FROM Suppliers", connectionString)
			SetWaitDialogCaption(My.Resources.LoadingSuppliers)
			oleDBAdapter.Fill(dsNWindProducts1.Suppliers)
		End Sub
		Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
			Dim ds As New DataSet()
			SetWaitDialogCaption(My.Resources.LoadingTables)
			ds.ReadXml(dataFileName)
			Me.gridControl1.LevelTree.Nodes(0).RelationName = "ProductsOrderDetails"
			Me.gridControl1.DataSource = ds.Tables("Products")
			Me.repositoryItemLookUpEdit1.DataSource = ds.Tables("Suppliers")
			Me.colSubTotal.Visible = False
		End Sub
		Protected Overrides Sub InitNWindData()
			MyBase.InitNWindData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\DXProducts.xml")
			If DBFileName <> "" Then
				Dim ds As New DataSet()
				SetWaitDialogCaption(My.Resources.LoadingDXProducts)
				ds.ReadXml(DBFileName)
				gridControl2.DataSource = ds.Tables(0).DefaultView
			End If
		End Sub
		Private Sub InitMasterDetailAppearance()
			gridControl2.ForceInitialize()
			CurrentView.BeginUpdate()
			colUnitsOnOrder.FilterInfo = New ColumnFilterInfo(ColumnFilterType.Custom, Nothing, "[UnitsOnOrder] < 50")
			colPlatform.FilterInfo = New ColumnFilterInfo(ColumnFilterType.Custom, Nothing, "[Platform] <> 1")
			ProductView.SetRowExpanded(-2, True)
			CurrentView.ExpandAllGroups()
			CurrentView.FocusedRowHandle = 0
			CurrentView.SetMasterRowExpanded(CurrentView.FocusedRowHandle, True)
			CurrentView.EndUpdate()
		End Sub

		Private Sub CustomDraw_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitMasterDetailAppearance()
			SetBackGround(toolBarButton16.Pushed)
            groupPanelImage = CType(DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.Utils.XtraFrames.dx-logo.png", GetType(ApplicationCaption).Assembly), Bitmap)
			groupPanelImage.MakeTransparent()
			panel1.Height = toolBar1.Height
		End Sub
		#End Region
		#Region "Custom draw stuff"
		Private Sub UpdateInnerElements(ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs, ByVal restore As Boolean, ByRef sortBounds As Rectangle, ByRef filterBounds As Rectangle, ByRef filterInfo As ObjectInfoArgs)
			For Each item As DevExpress.Utils.Drawing.DrawElementInfo In e.Info.InnerElements
				If TypeOf item.ElementPainter Is DevExpress.Utils.Drawing.SortedShapeObjectPainter Then
					If restore Then
						item.ElementInfo.Bounds = sortBounds
					Else
						sortBounds = item.ElementInfo.Bounds
						item.ElementInfo.Bounds = Rectangle.Empty
					End If
				End If
				If TypeOf item.ElementInfo Is DevExpress.XtraEditors.Drawing.GridFilterButtonInfoArgs Then
					If restore Then
						item.ElementInfo.Bounds = filterBounds
					Else
						filterInfo = item.ElementInfo
						filterBounds = item.ElementInfo.Bounds
						item.ElementInfo.Bounds = Rectangle.Empty
					End If
				End If
			Next item
		End Sub
		Private Shared Sub DrawCustomSortedShape(ByVal g As Graphics, ByVal r As Rectangle, ByVal so As ColumnSortOrder, ByVal iml As ImageList)
            If so = ColumnSortOrder.None OrElse iml Is Nothing Then
                Return
            End If
			Dim i As Integer = 0
            If so = ColumnSortOrder.Descending Then
                i = 1
            End If
			g.DrawImageUnscaled(iml.Images(i), r.X + (r.Width - iml.ImageSize.Width) \ 2, r.Y + (r.Height - iml.ImageSize.Height) \ 2)
		End Sub

		Private Shared Sub DrawCustomFilterButton(ByVal g As Graphics, ByVal column As GridColumn, ByVal filterInfo As DevExpress.Utils.Drawing.ObjectInfoArgs, ByVal iml As ImageList)
			If iml Is Nothing Then
				Return
			End If
			Dim i As Integer = 0
			If (filterInfo.State And DevExpress.Utils.Drawing.ObjectState.Hot) <> 0 Then
				i = 1
			End If
			If (filterInfo.State And DevExpress.Utils.Drawing.ObjectState.Pressed) <> 0 Then
				i = 2
			End If
			If column.FilterInfo.Type <> ColumnFilterType.None Then
				i += 3
			End If
			g.DrawImageUnscaled(iml.Images(i), filterInfo.Bounds.X + (filterInfo.Bounds.Width - iml.ImageSize.Width) \ 2, filterInfo.Bounds.Y + (filterInfo.Bounds.Height - iml.ImageSize.Height) \ 2)
		End Sub
		Private ReadOnly Property FilterButtonImageList() As ImageList
			Get
				Return If(toolBarButton4.Pushed, imlFilterShapes, Nothing)
			End Get
		End Property

		Private ReadOnly Property SortingGlyphsImageList() As ImageList
			Get
				Return If(toolBarButton4.Pushed, imlSortShapes, Nothing)
			End Get
		End Property
		Private Sub advBandedGridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles advBandedGridView1.FocusedColumnChanged
			CurrentView.InvalidateColumnHeader(Nothing)
			CurrentView.InvalidateGroupPanel()
		End Sub
		Private Sub toolBar1_ButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles toolBar1.ButtonClick
			If e.Button.ToolTipText = "Draw BackGround" Then
				SetBackGround(e.Button.Pushed)
			End If
			CurrentView.LayoutChanged()
		End Sub
		Private Sub SetBackGround(ByVal check As Boolean)
			CurrentView.Appearance.Empty.BackColor = If(check, Color.Transparent, SystemColors.Window)
		End Sub
		#End Region
		#Region "GridView custom draw events"
		Private Sub advBandedGridView1_CustomDrawGroupPanel(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs) Handles advBandedGridView1.CustomDrawGroupPanel
			If Not toolBarButton1.Pushed Then
				Return
			End If
            Dim brush As Brush = New LinearGradientBrush(e.Bounds, Color.Sienna, Color.BurlyWood, 0)
			e.Graphics.FillRectangle(brush, e.Bounds)
			Dim img As Image = groupPanelImage
			Dim r As New Rectangle(e.Bounds.X + e.Bounds.Width - img.Size.Width - 5, e.Bounds.Y + (e.Bounds.Height - img.Size.Height) \ 2, img.Width, img.Height)
			e.Graphics.DrawImageUnscaled(img, r)
			e.Handled = True
		End Sub
		Private Sub advBandedGridView1_CustomDrawBandHeader(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.BandedGrid.BandHeaderCustomDrawEventArgs) Handles advBandedGridView1.CustomDrawBandHeader
            If Not toolBarButton2.Pushed Or e.Band Is Nothing Then
                Return
            End If
			Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Wheat, Color.Chocolate, 70)
			Dim brushPressed As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.WhiteSmoke, Color.Gray, 70)
			Dim r As Rectangle = e.Bounds

			ControlPaint.DrawBorder3D(e.Graphics, r, (If(e.Info.State = DevExpress.Utils.Drawing.ObjectState.Pressed, Border3DStyle.SunkenOuter, Border3DStyle.RaisedInner)))
			r.Inflate(-1, -1)
			e.Graphics.FillRectangle((If(e.Info.State = DevExpress.Utils.Drawing.ObjectState.Pressed, brushPressed, brush)), r)

			r.Inflate(-2, 0)
			e.Graphics.DrawString(e.Band.Caption, e.Appearance.Font, Brushes.White, New RectangleF(r.X + 1, r.Y + 1, r.Width, r.Height), e.Appearance.GetStringFormat())
			e.Graphics.DrawString(e.Band.Caption, e.Appearance.Font, Brushes.Black, r, e.Appearance.GetStringFormat())
			e.Handled = True
		End Sub

		Private Sub InitAppearances()
			appCustomFocusedColumn = New AppearanceDefault(Color.SaddleBrown, Color.Empty, New Font("Arial", 8.25F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline))
			appCustomFilterPanel = New AppearanceDefault(Color.White, Color.SteelBlue, Color.Empty, Color.SkyBlue, LinearGradientMode.ForwardDiagonal, HorzAlignment.Default, VertAlignment.Default, New Font("Arial", 8.25F, FontStyle.Bold))
			appCustomPrice = New AppearanceDefault(Color.Black, Color.Aquamarine, Color.Empty, Color.PaleGreen, LinearGradientMode.Vertical, HorzAlignment.Default, VertAlignment.Default, New Font("Arial", 8.25F, FontStyle.Italic))
		End Sub
		Private Sub advBandedGridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs) Handles advBandedGridView1.CustomDrawColumnHeader
			Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(Rectangle.Inflate(e.Bounds, 1, 1), Color.Cornsilk, Color.DarkKhaki, 90)
			Dim brushPressed As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(Rectangle.Inflate(e.Bounds, 1, 1), Color.WhiteSmoke, Color.Gray, 90)
			Dim r As Rectangle = e.Bounds

			Dim filterInfo As DevExpress.Utils.Drawing.ObjectInfoArgs = Nothing
			Dim filterBounds, sortBounds As Rectangle
			sortBounds = Rectangle.Empty
			filterBounds = sortBounds
			Try
				UpdateInnerElements(e, False, sortBounds, filterBounds, filterInfo)
				e.Painter.DrawObject(e.Info)
			Finally
				UpdateInnerElements(e, True, sortBounds, filterBounds, filterInfo)
			End Try

			If toolBarButton3.Pushed Then
				'paint Border & Rect
				Dim border As New BorderObjectInfoArgs(Nothing, r, Nothing)
				Dim borderPainter As BorderPainter = (If(e.Info.State = DevExpress.Utils.Drawing.ObjectState.Pressed, CType(New Border3DSunkenPainter(), BorderPainter), CType(New Border3DRaisedPainter(), BorderPainter)))
				ObjectPainter.DrawObject(e.Cache, borderPainter, border)
				r.Inflate(-1, -1)
				e.Graphics.FillRectangle((If(e.Info.State = DevExpress.Utils.Drawing.ObjectState.Pressed, brushPressed, brush)), r)
				r.Inflate(-2, 0)
				'paint Caption
				e.Appearance.ForeColor = Color.Black
				If e.Column IsNot Nothing Then
					If e.Column.AbsoluteIndex = CurrentView.FocusedColumn.AbsoluteIndex Then
						Dim app As New AppearanceObject(appCustomFocusedColumn)
						app.DrawString(e.Cache, e.Column.GetTextCaption(), r)
					Else
						e.Appearance.DrawString(e.Cache, e.Column.GetTextCaption(), r)
					End If
				End If
			End If
			'paint Custom objects
			If Not sortBounds.IsEmpty Then
				DrawCustomSortedShape(e.Graphics, sortBounds, e.Column.SortOrder, SortingGlyphsImageList)
			End If
			If (Not filterBounds.IsEmpty) AndAlso filterInfo IsNot Nothing Then
				DrawCustomFilterButton(e.Graphics, e.Column, filterInfo, FilterButtonImageList)
			End If
			If SortingGlyphsImageList Is Nothing Then
				e.Info.InnerElements.DrawObjects(e.Info, e.Info.Cache, Point.Empty)
			End If
			e.Handled = True
		End Sub
		Private Sub advBandedGridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles advBandedGridView1.CustomDrawRowIndicator
			If Not toolBarButton5.Pushed Then
				Return
			End If
			Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Cornsilk, Color.DarkKhaki, 90)
			Dim r As Rectangle = e.Bounds
			r.Inflate(-1, -1)
			e.Graphics.FillRectangle(brush, r)
			If e.Info.ImageIndex > -1 Then
				Dim x As Integer = r.X + (r.Width - Me.imlIndicator.ImageSize.Width) \ 2
				Dim y As Integer = r.Y + (r.Height - Me.imlIndicator.ImageSize.Height) \ 2
				e.Graphics.DrawImageUnscaled(Me.imlIndicator.Images(e.Info.ImageIndex), x, y)
			End If
			r = e.Bounds
			ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.RaisedInner)
			e.Handled = True
		End Sub
		Private Sub advBandedGridView1_CustomDrawGroupRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles advBandedGridView1.CustomDrawGroupRow
			If Not toolBarButton6.Pushed Then
				Return
			End If
			Dim group As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo = TryCast(e.Info, DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo)
			Dim button As Rectangle = group.ButtonBounds, textBounds As Rectangle = group.Bounds

            Dim brush As Brush = New LinearGradientBrush(textBounds, Color.LemonChiffon, Color.Tan, 0)
			Dim brushImage As Brush = Brushes.LemonChiffon
			Dim brushText As Brush = Brushes.Black, brushTextShadow As Brush = Brushes.White
			If e.RowHandle = CurrentView.FocusedRowHandle Then
				brushImage = Brushes.DarkBlue
				brushTextShadow = brushImage
				brush = brushTextShadow
				brushText = Brushes.White
			End If
			e.Graphics.FillRectangle(brush, textBounds)
			e.Appearance.Font = New Font("Arial", 8.25F, FontStyle.Bold)
			If Not button.IsEmpty Then
				textBounds.Width = textBounds.Right - (button.Right + 4)
				textBounds.X = button.Right + 4
				Dim x As Integer = button.X
				Dim y As Integer = textBounds.Y + (textBounds.Height - Me.imlCustomDrawImages.ImageSize.Height) \ 2
				e.Graphics.DrawImageUnscaled(Me.imlCustomDrawImages.Images((If(CurrentView.GetRowExpanded(e.RowHandle), 1, 0))), x, y)
			End If
			Dim s As String = CurrentView.GetGroupRowDisplayText(e.RowHandle)
			e.Appearance.DrawString(e.Cache, s, New Rectangle(textBounds.X + 1, textBounds.Y + 1, textBounds.Width, textBounds.Height), brushTextShadow)
			e.Appearance.DrawString(e.Cache, s, textBounds, brushText)

			e.Handled = True
		End Sub
		Private Sub advBandedGridView1_GroupLevelStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GroupLevelStyleEventArgs) Handles advBandedGridView1.GroupLevelStyle
			If Not toolBarButton6.Pushed Then
				Return
			End If
			e.LevelAppearance.BackColor = System.Drawing.Color.LemonChiffon
		End Sub
		Private Sub advBandedGridView1_CustomDrawFooter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles advBandedGridView1.CustomDrawFooter
			If Not toolBarButton7.Pushed Then
				Return
			End If
			Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Cornsilk, Color.DarkKhaki, 90)
			e.Graphics.FillRectangle(brush, e.Bounds)
			ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner)
			e.Handled = True
		End Sub
		Private Sub advBandedGridView1_CustomDrawFooterCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs) Handles advBandedGridView1.CustomDrawFooterCell
			If Not toolBarButton8.Pushed Then
				Return
			End If
			If e.Bounds.Width = 0 Then
				Return
			End If
			Dim dx As Integer = e.Bounds.Height
			Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Wheat, Color.FloralWhite, 90)

			Dim r As Rectangle = e.Bounds
			ControlPaint.DrawBorder3D(e.Graphics, r,If(CType(e.Column, BandedGridColumn).OwnerBand.Index = 0, Border3DStyle.RaisedInner, Border3DStyle.SunkenOuter))

			r.Inflate(-1, -1)
			e.Graphics.FillRectangle(brush, r)

			r.Inflate(-2, 0)
			e.Appearance.ForeColor = Color.Black
			e.Appearance.DrawString(e.Cache, e.Info.DisplayText, r)

			Dim x As Integer = r.X + 2
			Dim y As Integer = r.Y + (r.Height - Me.imlCustomDrawImages.ImageSize.Height) \ 2
			If e.Column.SummaryItem.SummaryType = SummaryItemType.Count Then
				e.Graphics.DrawImageUnscaled(Me.imlCustomDrawImages.Images(2), x, y)
			End If
			If e.Column.SummaryItem.SummaryType = SummaryItemType.Average Then
				e.Graphics.DrawImageUnscaled(Me.imlCustomDrawImages.Images(3), x, y)
			End If
			e.Handled = True
		End Sub
		Private Sub advBandedGridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles advBandedGridView1.CustomDrawCell
			If Not toolBarButton9.Pushed Then
				Return
			End If
            If (e.RowHandle = CurrentView.FocusedRowHandle AndAlso e.Column IsNot CurrentView.FocusedColumn) AndAlso CurrentView Is CurrentGrid.FocusedView Then
                Return
            End If
			Dim r As Rectangle = e.Bounds
			If e.Column.FieldName = "UnitsInStock" Then
				Dim check As Boolean = CBool(CurrentView.GetRowCellValue(e.RowHandle, colDiscontinued))
				Dim ellipseBrush As Brush = If(check, Brushes.Silver, Brushes.LightSkyBlue)
				If (Not check) AndAlso Convert.ToInt16(e.CellValue) > 50 Then
					ellipseBrush = Brushes.LightGreen
				End If
				e.Graphics.FillEllipse(ellipseBrush, r)
				r.Width -= 12
				e.Appearance.DrawString(e.Cache, e.DisplayText, r)
				e.Handled = True
			End If
		End Sub
		Private Sub advBandedGridView1_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles advBandedGridView1.RowCellStyle
			If Not toolBarButton9.Pushed Then
				Return
			End If
			If e.Column Is Nothing Then
				Return
			End If
            If e.RowHandle <> CurrentView.FocusedRowHandle OrElse CurrentView IsNot CurrentGrid.FocusedView OrElse e.Column Is CurrentView.FocusedColumn Then
                If e.Column.FieldName = "UnitPrice" AndAlso CDec(CurrentView.GetRowCellValue(e.RowHandle, e.Column)) < 20 Then
                    e.CombineAppearance(New AppearanceObject(appCustomPrice))
                End If
            End If
		End Sub
		Private Sub advBandedGridView1_CustomDrawFilterPanel(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomDrawObjectEventArgs) Handles advBandedGridView1.CustomDrawFilterPanel
			If Not toolBarButton10.Pushed Then
				Return
			End If
			e.Appearance.Assign(appCustomFilterPanel)
			e.Appearance.DrawBackground(e.Cache, e.Bounds)
			ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner)
			Dim info As DevExpress.XtraGrid.Drawing.GridFilterPanelInfoArgs = TryCast(e.Info, DevExpress.XtraGrid.Drawing.GridFilterPanelInfoArgs)
			Dim painter As DevExpress.XtraGrid.Drawing.GridFilterPanelPainter = TryCast(e.Painter, DevExpress.XtraGrid.Drawing.GridFilterPanelPainter)
			info.Cache = e.Cache
			painter.DrawForeground(info)
			info.Cache = Nothing
			e.Handled = True
		End Sub
		#End Region
		#Region "CardView custom draw events"
		Private Sub cardView1_CustomDrawCardCaption(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Card.CardCaptionCustomDrawEventArgs) Handles cardView1.CustomDrawCardCaption
			If Not toolBarButton12.Pushed Then
				Return
			End If
			Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Cornsilk, Color.DarkKhaki, 90)
			Dim brushFocused As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.LavenderBlush, Color.Navy, 90)
			Dim cv As CardView = TryCast(sender, CardView)
			Dim isFocused As Boolean = e.RowHandle = cv.FocusedRowHandle

			Dim r As Rectangle = e.Bounds
			ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.RaisedInner)
			r.Inflate(-1, -1)
			e.Graphics.FillRectangle((If(isFocused, brushFocused, brush)), r)
			r.Inflate(-2, 0)

			e.Appearance.DrawString(e.Cache, cv.GetCardCaption(e.RowHandle), r)
			'Draw Caption Border
			e.Graphics.FillRectangle(e.Appearance.GetBorderBrush(e.Cache), e.Bounds.X - 1, e.Bounds.Y - 1, 1, e.Bounds.Height)
			e.Graphics.FillRectangle(e.Appearance.GetBorderBrush(e.Cache), e.Bounds.X - 1, e.Bounds.Y - 1, e.Bounds.Width + 1, 1)
			e.Graphics.FillRectangle(e.Appearance.GetBorderBrush(e.Cache), e.Bounds.X + e.Bounds.Width, e.Bounds.Y - 1, 1, e.Bounds.Height)
			e.Handled = True
		End Sub
		Private Sub cardView1_CustomDrawCardFieldCaption(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles cardView1.CustomDrawCardFieldCaption
			If Not toolBarButton13.Pushed Then
				Return
			End If
			Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Aquamarine, Color.DarkSeaGreen, 90)
			Dim brushFocused As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.LavenderBlush, Color.Navy, 90)
			Dim cv As CardView = TryCast(sender, CardView)
			Dim isFocused As Boolean = False
			If cv.FocusedColumn IsNot Nothing Then
				isFocused = e.Column.AbsoluteIndex = cv.FocusedColumn.AbsoluteIndex AndAlso e.RowHandle = cv.FocusedRowHandle
			End If

			Dim r As Rectangle = e.Bounds
			ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.RaisedInner)
			r.Inflate(-1, -1)
			e.Graphics.FillRectangle((If(isFocused, brushFocused, brush)), r)
			r.Y -= 1

			If isFocused Then
				e.Appearance.Assign(cardView1.PaintAppearance.FocusedCardCaption)
			End If
			e.Graphics.DrawString(e.Column.GetTextCaption(), New Font(e.Appearance.Font,If(isFocused, FontStyle.Bold, FontStyle.Regular)), e.Appearance.GetForeBrush(e.Cache), r, e.Appearance.GetStringFormat())
			e.Handled = True
		End Sub
		Private Sub cardView1_CustomDrawCardFieldValue(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles cardView1.CustomDrawCardFieldValue
			If Not toolBarButton14.Pushed Then
				Return
			End If
            Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Aquamarine, Color.DarkSeaGreen, 0)
			If e.Column.FieldName = "SubTotal" Then
                brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.White, Color.SkyBlue, 0)
				e.Appearance.Font = New Font(AppearanceObject.DefaultFont, FontStyle.Bold)
				e.Appearance.ForeColor = Color.Indigo
			End If

			e.Graphics.FillRectangle(brush, e.Bounds)
			e.Appearance.DrawString(e.Cache, e.DisplayText, e.Bounds)
			e.Handled = True
		End Sub
		#End Region
		#Region "Product Grid custom draw"
		Private Sub FillRectangle(ByVal r As Rectangle, ByVal g As Graphics)
			Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(r, Color.FromArgb(209, 227, 241), Color.FromArgb(68, 121, 191), 90)
			g.FillRectangle(brush, r)
		End Sub
		Private Sub gridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs) Handles gridView1.CustomDrawColumnHeader
			If e.Info.State <> DevExpress.Utils.Drawing.ObjectState.Pressed Then
				FillRectangle(e.Bounds, e.Graphics)
			End If
		End Sub

		Private Sub gridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gridView1.CustomDrawRowIndicator
			FillRectangle(e.Bounds, e.Graphics)
		End Sub

		Private Sub gridView1_CustomDrawRowPreview(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles gridView1.CustomDrawRowPreview
			Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.FromArgb(90, Color.White), Color.FromArgb(70, 68, 121, 191), 90)
			e.Graphics.FillRectangle(brush, e.Bounds)
			ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner)
		End Sub
		Private Sub gridView1_CustomDrawRowFooter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles gridView1.CustomDrawRowFooter
			FillRectangle(e.Bounds, e.Graphics)
			ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner)
		End Sub

		Private Sub gridView1_CustomDrawRowFooterCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs) Handles gridView1.CustomDrawRowFooterCell
			e.Graphics.FillRectangle(Brushes.Lavender, e.Bounds)
		End Sub

		Private Sub gridView1_CustomDrawFilterPanel(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomDrawObjectEventArgs) Handles gridView1.CustomDrawFilterPanel
			FillRectangle(e.Bounds, e.Graphics)
		End Sub
		#End Region
		#Region "Selected grid"
		Private Sub xtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtraTabControl1.SelectedPageChanged
			InitBlendingMenu()
		End Sub
		Private Sub InitBlendingMenu()
			If xtraTabControl1.SelectedTabPageIndex > 0 Then
				GridRibbonMenuManager.InitBlendingMenu(xtraGridBlending1)
			Else
				GridRibbonMenuManager.InitBlendingMenu(Nothing)
			End If
		End Sub
		Protected Overrides Sub OnSetCaption(ByVal caption As String)
			MyBase.OnSetCaption(caption)
			InitBlendingMenu()
		End Sub
		#End Region
	End Class
End Namespace
