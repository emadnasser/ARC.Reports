Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraVerticalGrid.Design
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraVerticalGrid.Events
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class FixedRows
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\VertGridMainDemo\Modules\FixedRows.vb"
			TutorialInfo.WhatsThisXMLFile = "FixedRows.xml"
			Me.propertyGridControl1.SelectedObject = Me.pictureEdit1
			Me.numFixedLineWidth1.Value = Me.propertyGridControl1.OptionsView.FixedLineWidth

			Dim pictureEdit As New RepositoryItemPictureEdit()
			pictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom

			'<propertyGridControl1>
			Me.propertyGridControl1.BeginUpdate()
			MoveRow("Image", FixedStyle.Top)
			MoveRow("Properties.PictureAlignment", FixedStyle.Top)
			MoveRow("Properties.SizeMode", FixedStyle.Top)
			Me.propertyGridControl1.RepositoryItems.Add(pictureEdit)
			Me.propertyGridControl1.GetRowByFieldName("Image").Properties.RowEdit = pictureEdit
			Me.propertyGridControl1.EndUpdate()
			'</propertyGridControl1>
		End Sub

		Private ReadOnly Property AllowFixingNestedRows() As Boolean
			Get
				Return cheAllowFixingNestedRows.Checked
			End Get
		End Property

		'<propertyGridControl1>
		Private Sub MoveRow(ByVal fieldName As String, ByVal fixedStyle As FixedStyle)
			Me.propertyGridControl1.BeginUpdate()
			Dim row As BaseRow = Me.propertyGridControl1.GetRowByFieldName(fieldName)
			row.ParentRow.ChildRows.Remove(row)
			propertyGridControl1.Rows.Add(row)
			row.Fixed = fixedStyle
			Me.propertyGridControl1.EndUpdate()
		End Sub
		'</propertyGridControl1>

		Public Overrides ReadOnly Property ExportControl() As VGridControlBase
			Get
				Return Me.propertyGridControl1
			End Get
		End Property

		'<numFixedLineWidth1>
		Private Sub numFixedLineWidth1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numFixedLineWidth1.EditValueChanged
			Me.propertyGridControl1.OptionsView.FixedLineWidth = Convert.ToInt32(Me.numFixedLineWidth1.Value)
		End Sub
		'</numFixedLineWidth1>

		Private Sub FixedRows_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.propertyGridControl1.RowsCustomization()
		End Sub
		Private Function EnableFixedStyleMenuItem(ByVal row As BaseRow, ByVal fixedStyle As FixedStyle) As Boolean
			If AllowFixingNestedRows Then
				Return True
			Else
                Return row.ParentRow Is Nothing OrElse row.Fixed = fixedStyle
			End If
		End Function
		'<propertyGridControl1>
		Private Sub propertyGridControl1_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs) Handles propertyGridControl1.PopupMenuShowing
			e.Menu.Items.Add(AddEnabled(New DXMenuItem("Show Row Customization", AddressOf Click_ShowRowCustomization, Me.menuItemImageList.Images(0)), Me.propertyGridControl1.CustomizationForm Is Nothing))
			If e.Row Is Nothing Then
				Return
			End If
			e.Menu.Items.Add(AddTag(AddEnabled(New DXMenuCheckItem("Not Fixed", e.Row.Fixed = FixedStyle.None, Me.menuItemImageList.Images(1), AddressOf Click_NotFixed), EnableFixedStyleMenuItem(e.Row, FixedStyle.None)), e.Row))
			e.Menu.Items.Add(AddTag(AddEnabled(New DXMenuCheckItem("Fixed Top", e.Row.Fixed = FixedStyle.Top, Me.menuItemImageList.Images(2), AddressOf Click_FixedTop), EnableFixedStyleMenuItem(e.Row, FixedStyle.Top)), e.Row))
			e.Menu.Items.Add(AddTag(AddEnabled(New DXMenuCheckItem("Fixed Bottom", e.Row.Fixed = FixedStyle.Bottom, Me.menuItemImageList.Images(3), AddressOf Click_FixedBottom), EnableFixedStyleMenuItem(e.Row, FixedStyle.Bottom)), e.Row))
		End Sub
		Private Function AddTag(ByVal item As DXMenuItem, ByVal tag As Object) As DXMenuItem
			item.Tag = tag
			Return item
		End Function
		Private Function AddEnabled(ByVal item As DXMenuItem, ByVal enabled As Boolean) As DXMenuItem
			item.Enabled = enabled
			Return item
		End Function
		Private Function AddSeparator(ByVal item As DXMenuItem) As DXMenuItem
			item.BeginGroup = True
			Return item
		End Function
		Private Sub Click_ShowRowCustomization(ByVal sender As Object, ByVal e As EventArgs)
			Me.propertyGridControl1.RowsCustomization()
		End Sub
		Private Sub Click_NotFixed(ByVal sender As Object, ByVal e As EventArgs)
			ChangeFixedStyle(GetRow(sender), FixedStyle.None)
		End Sub
		Private Sub ChangeFixedStyle(ByVal row As BaseRow, ByVal fixedStyle As FixedStyle)
            If row.Fixed = fixedStyle Then
                Return
            End If
			row.Fixed = fixedStyle
			If AllowFixingNestedRows Then
				propertyGridControl1.BeginUpdate()
				Dim parentRow As BaseRow = TryCast(row.Tag, BaseRow)
                If parentRow IsNot Nothing AndAlso parentRow.Fixed = fixedStyle Then
                    row.Tag = Nothing
                    RemoveParent(row)
                    parentRow.ChildRows.Add(row)
                Else
                    If row.ParentRow IsNot Nothing Then
                        row.Tag = row.ParentRow
                    End If
                    RemoveParent(row)
                    propertyGridControl1.Rows.Add(row)
                End If
				propertyGridControl1.EndUpdate()
			End If
		End Sub
		Private Sub RemoveParent(ByVal row As BaseRow)
			propertyGridControl1.BeginUpdate()
			If row.ParentRow IsNot Nothing Then
				row.ParentRow.ChildRows.Remove(row)
			Else
				propertyGridControl1.Rows.Remove(row)
			End If
			propertyGridControl1.EndUpdate()
		End Sub
        Private Sub Click_FixedTop(ByVal sender As Object, ByVal e As EventArgs)
            ChangeFixedStyle(GetRow(sender), FixedStyle.Top)
        End Sub
		Private Sub Click_FixedBottom(ByVal sender As Object, ByVal e As EventArgs)
			ChangeFixedStyle(GetRow(sender), FixedStyle.Bottom)
		End Sub
		Private Function GetRow(ByVal dxMenuItem As Object) As BaseRow
			Return (CType(CType(dxMenuItem, DXMenuItem).Tag, BaseRow))
		End Function
		'</propertyGridControl1>
	End Class
End Namespace
