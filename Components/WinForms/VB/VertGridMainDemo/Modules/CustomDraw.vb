Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraVerticalGrid.ViewInfo
Imports DevExpress.XtraBars
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class CustomDraw
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
		End Sub

		Private dv As DataView
		Private app1, app2, app3, app4, app5 As AppearanceDefault
		Private bW As Integer = 9
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
			Me.BarInfos.Add(New BarInfo("CustomDraw RowValue Cell", New ItemClickEventHandler(AddressOf MenuItemClick), imageList3.Images(1), True, True, False))
			Me.BarInfos.Add(New BarInfo("CustomDraw RowHeader Cell", New ItemClickEventHandler(AddressOf MenuItemClick), imageList3.Images(2), True, True, False))
			Me.BarInfos.Add(New BarInfo("CustomDraw RowHeader Indent", New ItemClickEventHandler(AddressOf MenuItemClick), imageList3.Images(3), True, True, False))
			Me.BarInfos.Add(New BarInfo("CustomDraw Separator", New ItemClickEventHandler(AddressOf MenuItemClick), imageList3.Images(4), True, True, False))
			Me.BarInfos.Add(New BarInfo("CustomDraw TreeButton", New ItemClickEventHandler(AddressOf MenuItemClick), imageList3.Images(5), True, True, False))
			Me.BarInfos.Add(New BarInfo("TreeButton Style", Nothing, imageList3.Images(7), False, False, True, New BarInfo() { New BarInfo("ExplorerBar Button", New ItemClickEventHandler(AddressOf ExplorerBarClick), imageList3.Images(6), True, vGridControl1.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.ExplorerBar, False), New BarInfo("TreeView Button", New ItemClickEventHandler(AddressOf TreeViewClick), imageList3.Images(7), True, vGridControl1.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView, False)}, 1))
		End Sub

		Private Sub MenuItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			vGridControl1.LayoutChanged()
		End Sub

		Private Sub ExplorerBarClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			GetBarItem(5).Glyph = imageList3.Images(6)
			vGridControl1.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.ExplorerBar
		End Sub

		Private Sub TreeViewClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			GetBarItem(5).Glyph = imageList3.Images(7)
			vGridControl1.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
		End Sub

		#Region "Init"
		Private Sub CustomDraw_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
			vGridControl1.FocusedRecord = 4
			vGridControl1.FocusedRow = rowTrademark
			vGridControl1.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
			CreateAppearances()
		End Sub

		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\Cars.xml")
			If DBFileName <> "" Then
				Dim dataSet As New DataSet()
				dataSet.ReadXml(DBFileName)
				dv = dataSet.Tables(0).DefaultView
				vGridControl1.DataSource = dv
			End If
		End Sub
		#End Region
		#Region "Custom Draw"

		Private Sub CreateAppearances()
			app1 = New AppearanceDefault(Color.Yellow, Color.Lavender, Color.Lavender, Color.Navy)
			app1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
			app1.Font = New Font(AppearanceObject.DefaultFont, FontStyle.Bold)
			app2 = New AppearanceDefault(SystemColors.WindowText, Color.FromArgb(234, 230, 221), Color.FromArgb(234, 230, 221), Color.FromArgb(247, 245, 242))
			app2.Font = New Font(AppearanceObject.DefaultFont, FontStyle.Bold)
			app3 = New AppearanceDefault(SystemColors.ControlDark, Color.FromArgb(234, 230, 221), Color.FromArgb(234, 230, 221), Color.FromArgb(247, 245, 242))
			app3.Font = New Font(AppearanceObject.DefaultFont, FontStyle.Strikeout)
			app4 = New AppearanceDefault(SystemColors.WindowText, Color.FromArgb(128, 255, 128))
			app5 = New AppearanceDefault(SystemColors.WindowText, Color.FromArgb(192, 192, 255))
		End Sub

		Private Sub vGridControl1_CustomDrawRowValueCell(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CustomDrawRowValueCellEventArgs) Handles vGridControl1.CustomDrawRowValueCell
			If Not GetBarItemPushed(0) Then
				Return
			End If
			Dim brush As Brush = Nothing
			Dim r As Rectangle = e.Bounds
			Dim ellipse As Boolean = False
            Dim isFocusedCell As Boolean = (e.Row Is vGridControl1.FocusedRow)
			Dim isInStock As Boolean = CBool(dv(vGridControl1.LeftVisibleRecord).Row("Is In Stock"))

			If (Not isInStock) AndAlso (e.Row.Properties.FieldName = "Price" OrElse e.Row.Properties.FieldName = "Delivery Date") Then
				AppearanceHelper.Apply(e.Appearance, app3)
			End If
			If e.Row.Properties.FieldName = "Trademark" OrElse e.Row.Properties.FieldName = "Model" Then
				AppearanceHelper.Apply(e.Appearance, app2)
			End If

			If TypeOf e.Row Is MultiEditorRow AndAlso e.CellIndex = 0 Then
				AppearanceHelper.Apply(e.Appearance, app4)
			End If
			If TypeOf e.Row Is MultiEditorRow AndAlso e.CellIndex = 1 Then
				AppearanceHelper.Apply(e.Appearance, app5)
			End If

			If e.Row.Properties.FieldName = "Liter" AndAlso e.CellValue IsNot Nothing Then
				brush = e.Appearance.GetBackBrush(e.Cache)
				If isFocusedCell Then
					brush = SystemBrushes.Highlight
				End If
				ellipse = True
			End If
			If brush IsNot Nothing Then
				e.Graphics.FillRectangle(brush, r)
				r.Inflate(-2, 0)
				If ellipse Then
					Dim ellipseBrush As Brush = Brushes.LightSkyBlue
					If isFocusedCell Then
						ellipseBrush = Brushes.Yellow
					End If
					e.Graphics.FillEllipse(ellipseBrush, r)
				End If
				Dim sf As New StringFormat()
				sf.Alignment = StringAlignment.Center
				sf.LineAlignment = StringAlignment.Center
				e.Appearance.DrawString(e.Cache, e.CellText, r, sf)
				If isFocusedCell Then
					DevExpress.Utils.Paint.XPaint.Graphics.DrawFocusRectangle(e.Graphics, e.Bounds, SystemColors.WindowText, e.Appearance.BackColor)
				End If
				e.Handled = True
			End If
		End Sub

		Private Function HasFocusedRow(ByVal row As BaseRow, ByVal child As BaseRow) As Boolean
			If Not(TypeOf row Is CategoryRow) Then
				Return False
			End If
			If row Is child OrElse row Is child.ParentRow Then
				Return True
			End If
			Return False
		End Function

		Private Sub vGridControl1_CustomDrawRowHeaderCell(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventArgs) Handles vGridControl1.CustomDrawRowHeaderCell
			If Not GetBarItemPushed(1) Then
				Return
			End If
			If HasFocusedRow(e.Row, vGridControl1.FocusedRow) Then
				AppearanceHelper.Apply(e.Appearance, app1)
			End If
			If TypeOf e.Row Is CategoryRow Then
				e.Appearance.FillRectangle(e.Cache, e.Bounds)
				If e.ImageIndex <> -1 Then
					e.Graphics.DrawImageUnscaled(imageList1.Images(e.ImageIndex), e.ImageRect)
				End If
				e.Appearance.DrawString(e.Cache, e.Caption, e.CaptionRect)
				ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner)
				e.Handled = True
			End If
		End Sub

		Private Sub vGridControl1_CustomDrawRowHeaderIndent(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderIndentEventArgs) Handles vGridControl1.CustomDrawRowHeaderIndent
			If Not GetBarItemPushed(2) Then
				Return
			End If
			Dim appObject As AppearanceObject = vGridControl1.Appearance.RowHeaderPanel
			Dim r As Rectangle
			For i As Integer = 0 To e.RowIndents.Count - 1
				r = CType(e.RowIndents(i), IndentInfo).Bounds
				appObject.FillRectangle(e.Cache, r)
			Next i
			If HasFocusedRow(e.Row.ParentRow, vGridControl1.FocusedRow) OrElse HasFocusedRow(e.Row, vGridControl1.FocusedRow) Then
				AppearanceHelper.Apply(e.Appearance, app1)
			Else
				AppearanceHelper.Apply(e.Appearance, vGridControl1.Appearance.Category)
			End If
            If e.Row Is vGridControl1.FocusedRow AndAlso e.Row.ParentRow IsNot Nothing AndAlso e.RowIndents.Count > 0 Then
                e.Graphics.DrawImageUnscaled(imageList1.Images(5), CType(e.RowIndents(0), IndentInfo).Bounds)
            End If
			If e.CategoryIndents.Count > 0 Then
				r = CType(e.CategoryIndents(0), IndentInfo).Bounds
				e.Appearance.FillRectangle(e.Cache, r)
				ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.RaisedInner)
			End If
			e.Handled = True
		End Sub

		Private Sub vGridControl1_CustomDrawSeparator(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CustomDrawSeparatorEventArgs) Handles vGridControl1.CustomDrawSeparator
			If Not GetBarItemPushed(3) Then
				Return
			End If
			If TypeOf vGridControl1.FocusedRow Is MultiEditorRow Then
				e.SeparatorString = "&"
			End If
			e.Appearance.FillRectangle(e.Cache, e.Bounds)
			Dim r As Rectangle = e.Bounds
			r.X += 1
			r.Width -=1
			e.Appearance.DrawString(e.Cache, e.SeparatorString, r)
			ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner)
			e.Handled = True
		End Sub


		Private Sub vGridControl1_CustomDrawTreeButton(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CustomDrawTreeButtonEventArgs) Handles vGridControl1.CustomDrawTreeButton
			If Not GetBarItemPushed(4) Then
				Return
			End If
			Dim r As Rectangle = e.Bounds
			If e.TreeButtonType = DevExpress.XtraVerticalGrid.TreeButtonType.ExplorerBarButton Then
				r.Y = r.Y + (r.Height - bW) \ 2
				r.X = r.X + (r.Width - bW)
			End If
			e.Graphics.DrawImageUnscaled(imageList1.Images((If(e.Expanded, 6, 7))), r)
			e.Handled = True
		End Sub

		Private Sub vGridControl1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.FocusedRowChangedEventArgs) Handles vGridControl1.FocusedRowChanged
			Dim oldParent As BaseRow = If(e.OldRow Is Nothing, Nothing, e.OldRow.ParentRow)
			Dim newParent As BaseRow = If(e.Row Is Nothing, Nothing, e.Row.ParentRow)
			If oldParent IsNot newParent OrElse newParent Is Nothing Then
				vGridControl1.LayoutChanged()
			End If

		End Sub
		#End Region
	End Class
End Namespace
