Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraBars
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class TreeListCustomDraw
		Inherits TutorialControl

		Public Overrides ReadOnly Property ExportControl() As TreeList
			Get
				Return treeList1
			End Get
		End Property
		Public Overrides ReadOnly Property ViewOptionsControl() As TreeList
			Get
				Return treeList1
			End Get
		End Property
		Protected Overrides ReadOnly Property BarName() As String
			Get
				Return "CustomDraw"
			End Get
		End Property
		Protected Overrides ReadOnly Property Manager() As BarManager
			Get
				Return barManager1
			End Get
		End Property
		Protected Overrides Sub InitBarInfo()
			Me.BarInfos.Add(New BarInfo("CustomDraw Column Header", New ItemClickEventHandler(AddressOf MenuItemClick), imageList1.Images(0), True, True, False))
			Me.BarInfos.Add(New BarInfo("CustomDraw NodeIndicator", New ItemClickEventHandler(AddressOf MenuItemClick), imageList1.Images(1), True, True, False))
			Me.BarInfos.Add(New BarInfo("CustomDraw Cell", New ItemClickEventHandler(AddressOf MenuItemClick), imageList1.Images(2), True, True, False))
			Me.BarInfos.Add(New BarInfo("CustomDraw Footer", New ItemClickEventHandler(AddressOf MenuItemClick), imageList1.Images(3), True, True, False))
			Me.BarInfos.Add(New BarInfo("CustomDraw Footer Cell", New ItemClickEventHandler(AddressOf MenuItemClick), imageList1.Images(4), True, True, False))
			Me.BarInfos.Add(New BarInfo("CustomDraw NodeButtons", New ItemClickEventHandler(AddressOf MenuItemClick), imageList1.Images(6), True, True, False))
			Me.BarInfos.Add(New BarInfo("CustomDraw NodeImages", New ItemClickEventHandler(AddressOf MenuItemClick), imageList1.Images(7), True, True, False))
		End Sub

		Private dataView As DataView
		Private imgIndicator_Renamed As ImageList = Nothing

		Public Sub New()
			InitializeComponent()
			InitData()
			InitEditors()
		End Sub

		Private Sub MenuItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.Invalidate()
		End Sub


		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Departments.xml")
			If DBFileName <> "" Then
				Dim dataSet As New DataSet()
				dataSet.ReadXml(DBFileName)
				dataView = dataSet.Tables(0).DefaultView
				treeList1.DataSource = dataView
				treeList1.PopulateColumns()
				treeList1.ExpandAll()
			End If
		End Sub

		Private Sub InitEditors()
			Dim cb As New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			treeList1.RepositoryItems.Add(cb)
			Dim se As New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			treeList1.RepositoryItems.Add(se)

			Dim s As String, oldLocation As String = ""
			Dim dv As New DataView(dataView.Table)
			dv.Sort = "[Location] ASC"
			For i As Integer = 0 To dv.Count - 1
				s = TryCast(dv(i).Row.ItemArray.GetValue(5), String)
				If s <> oldLocation Then
					cb.Items.Add(s)
				End If
				oldLocation = s
			Next i
			cb.DropDownRows = 10

			Dim col As DevExpress.XtraTreeList.Columns.TreeListColumn

			treeList1.Columns("Location").ColumnEdit = cb
			col = treeList1.Columns("Department")
			col.SummaryFooter = SummaryItemType.Count
			col.AllNodesSummary = True
			col = treeList1.Columns("Budget")
			col.ColumnEdit = se
			col.Format.FormatString = "c"
			col.SummaryFooter = SummaryItemType.Sum
			col.RowFooterSummary = col.SummaryFooter
			col.SummaryFooterStrFormat = "Sum={0:c}"
			col.RowFooterSummaryStrFormat = col.SummaryFooterStrFormat
			col.AllNodesSummary = True
			treeList1.BestFitColumns()
			col.Width = 110
		End Sub

		Private Sub treeList1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawColumnHeaderEventArgs) Handles treeList1.CustomDrawColumnHeader
			If Not GetBarItemPushed(0) Then
				Return
			End If
			Try
				Dim dx As Integer = e.Bounds.Height
				Dim focused As Boolean = (e.Column IsNot Nothing AndAlso treeList1.FocusedColumn IsNot Nothing AndAlso e.Column.AbsoluteIndex = treeList1.FocusedColumn.AbsoluteIndex)
				Dim brush As Brush
				If focused Then
					brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.White, Color.LightGreen, 90)
				Else
					brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Cyan, Color.DeepSkyBlue, 90)
				End If
				Dim brushPressed As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.WhiteSmoke, Color.Gray,If(focused, 180, 90))

				Dim r As Rectangle = e.Bounds
				ControlPaint.DrawBorder3D(e.Graphics, r, (If(e.Pressed, Border3DStyle.SunkenOuter, Border3DStyle.RaisedInner)))
				r.Inflate(-1, -1)
				e.Graphics.FillRectangle((If(e.Pressed, brushPressed, brush)), r)
				r.Inflate(-2, 0)

				If e.Column IsNot Nothing Then
					Dim imageIndex As Integer = -1
					If e.Column.SortOrder = SortOrder.Ascending Then
						imageIndex = 2
					End If
					If e.Column.SortOrder = SortOrder.Descending Then
						imageIndex = 3
					End If
					If imageIndex <> -1 Then
						Dim x As Integer = r.X + r.Width - imglCustom.ImageSize.Width
						Dim y As Integer = r.Y + (r.Height - imglCustom.ImageSize.Height) \ 2
						e.Graphics.DrawImageUnscaled(imglCustom.Images(imageIndex), x, y)
						r.Width -= imglCustom.ImageSize.Width
					End If
					e.Appearance.DrawString(e.Cache, e.Column.Caption, r)
				End If
				e.Handled = True
			Catch
			End Try
		End Sub


		Private ReadOnly Property ImgIndicator() As ImageList
			Get
				If imgIndicator_Renamed Is Nothing Then
					imgIndicator_Renamed = DevExpress.Utils.ResourceImageHelper.CreateImageListFromResources("DevExpress.Utils.Indicator.bmp", GetType(DevExpress.Utils.ResourceImageHelper).Assembly, New Size(7, 9))
				End If
				Return imgIndicator_Renamed
			End Get
		End Property

		Private Sub treeList1_CustomDrawNodeIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventArgs) Handles treeList1.CustomDrawNodeIndicator
			If Not GetBarItemPushed(1) Then
				Return
			End If
			Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Cyan, Color.DeepSkyBlue, 90)
			Dim r As Rectangle = e.Bounds
			r.Inflate(-1, -1)
			e.Graphics.FillRectangle(brush, r)
			If e.ImageIndex > -1 Then
				Dim x As Integer = r.X + (r.Width - ImgIndicator.ImageSize.Width) \ 2
				Dim y As Integer = r.Y + (r.Height - ImgIndicator.ImageSize.Height) \ 2
				e.Graphics.DrawImageUnscaled(ImgIndicator.Images(e.ImageIndex), x, y)
			End If
			r = e.Bounds
			ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.RaisedInner)
			e.Handled = True
		End Sub

		Private Sub treeList1_CustomDrawNodeCell(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs) Handles treeList1.CustomDrawNodeCell
			If Not GetBarItemPushed(2) Then
				Return
			End If
            If (e.Node Is treeList1.FocusedNode AndAlso e.Column IsNot treeList1.FocusedColumn) OrElse e.Node Is Nothing OrElse e.Column Is Nothing Then
                Return
            End If
			If e.Node(5).Equals(False) Then
				e.Appearance.Font = New Font(AppearanceObject.DefaultFont, FontStyle.Strikeout)
				e.Appearance.ForeColor = SystemColors.ControlDark
			End If
            Dim isFocusedCell As Boolean = (e.Column Is treeList1.FocusedColumn AndAlso e.Node Is treeList1.FocusedNode)
			Dim brush As Brush = Nothing
			Dim r As Rectangle = e.Bounds
			Dim ellipse As Boolean = False
			If e.Column.FieldName = "Budget" AndAlso e.CellValue IsNot Nothing Then
				If CDec(e.CellValue) > 500000 Then
					brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Cyan, Color.DeepSkyBlue, 180)
				End If
				If CDec(e.CellValue) < 100000 Then
					brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.LightGreen, Color.White, 180)
				End If
			End If
			If e.Column.FieldName = "Phone" AndAlso e.CellValue IsNot Nothing Then
				brush = CType(e.Appearance.GetBackBrush(e.Cache), Brush)
				If isFocusedCell Then
					brush = SystemBrushes.Highlight
				End If
				ellipse = True
			End If
			If brush IsNot Nothing Then
				e.Graphics.FillRectangle(brush, r)
				r.Inflate(-2, 0)
				If ellipse Then
					Dim check As Boolean = e.Node(5).Equals(True)
					Dim ellipseBrush As Brush = If(check, Brushes.LightGreen, Brushes.LightSkyBlue)
					If isFocusedCell Then
						ellipseBrush = Brushes.Yellow
					End If
					e.Graphics.FillEllipse(ellipseBrush, r)
				End If
				e.Appearance.DrawString(e.Cache, e.CellText, r)
				If isFocusedCell Then
					DevExpress.Utils.Paint.XPaint.Graphics.DrawFocusRectangle(e.Graphics, e.Bounds, SystemColors.WindowText, e.Appearance.BackColor)
				End If
				e.Handled = True
			End If
		End Sub

		Private Sub treeList1_CustomDrawFooter(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawEventArgs) Handles treeList1.CustomDrawFooter
			If Not GetBarItemPushed(3) Then
				Return
			End If
			Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Cyan, Color.DeepSkyBlue, 90)
			e.Graphics.FillRectangle(brush, e.Bounds)
			e.Handled = True
		End Sub

		Private Sub DrawFooterCell(ByVal cache As DevExpress.Utils.Drawing.GraphicsCache, ByVal r As Rectangle, ByVal s As String, ByVal appObject As AppearanceObject)
			If s = "" Then
				Return
			End If
			Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(r, Color.LightSkyBlue, Color.Cyan, 90)
			ControlPaint.DrawBorder3D(cache.Graphics, r, Border3DStyle.SunkenOuter)

			r.Inflate(-1, -1)
			cache.Graphics.FillRectangle(brush, r)

			r.Inflate(-2, 0)
			appObject.DrawString(cache, s, r)
		End Sub

		Private Sub treeList1_CustomDrawFooterCell(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawFooterCellEventArgs) Handles treeList1.CustomDrawFooterCell
			If Not GetBarItemPushed(4) Then
				Return
			End If
			DrawFooterCell(e.Cache, e.Bounds, e.Text, e.Appearance)
			e.Handled = True
		End Sub

		Private Sub treeList1_CustomDrawRowFooter(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawRowFooterEventArgs) Handles treeList1.CustomDrawRowFooter
			If Not GetBarItemPushed(3) Then
				Return
			End If
			Dim brush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Cyan, Color.DeepSkyBlue, 90)
			e.Graphics.FillRectangle(brush, e.Bounds)
			e.Handled = True
		End Sub

		Private Sub treeList1_CustomDrawRowFooterCell(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawRowFooterCellEventArgs) Handles treeList1.CustomDrawRowFooterCell
			If Not GetBarItemPushed(4) Then
				Return
			End If
			DrawFooterCell(e.Cache, e.Bounds, e.Text, e.Appearance)
			e.Handled = True
		End Sub

		Private Sub treeList1_CustomDrawNodeButton(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeButtonEventArgs) Handles treeList1.CustomDrawNodeButton
			If Not GetBarItemPushed(5) Then
				Return
			End If
			e.Graphics.DrawImageUnscaled(imglCustom.Images(If(e.Expanded, 5, 4)), e.Bounds)
			e.Handled = True
		End Sub

		Private Sub treeList1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedColumnChangedEventArgs) Handles treeList1.FocusedColumnChanged
			treeList1.Invalidate()
		End Sub

		Private Sub treeList1_CustomDrawNodeImages(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeImagesEventArgs) Handles treeList1.CustomDrawNodeImages
			If Not GetBarItemPushed(6) Then
				Return
			End If
			If Not e.Node.Equals(treeList1.FocusedNode) Then
				Try
					Dim Y As Integer = e.SelectRect.Top + (e.SelectRect.Height - ImageCollection.GetImageListImage(treeList1.SelectImageList, e.SelectImageIndex).Height) \ 2
					ControlPaint.DrawImageDisabled(e.Graphics, ImageCollection.GetImageListImage(treeList1.SelectImageList, e.SelectImageIndex), e.SelectRect.X, Y, Color.Black)
					e.Handled = True
				Catch
				End Try
			End If
		End Sub

		Private Sub treeList1_TreeListMenuItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.TreeListMenuItemClickEventArgs) Handles treeList1.TreeListMenuItemClick
			If e.Column IsNot Nothing AndAlso e.Column.FieldName = "Budget" AndAlso e.MenuType = DevExpress.XtraTreeList.Menu.TreeListMenuType.Summary AndAlso e.SummaryType <> SummaryItemType.Count Then
				Dim s As String = e.SummaryFormat
				Dim i As Integer = s.IndexOf("0")
				If i > 0 Then
					s = s.Substring(0, i) & "0:c}"
				End If
				e.SummaryFormat = s
			End If
		End Sub
	End Class
End Namespace
