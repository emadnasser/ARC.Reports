Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Columns

Namespace DevExpress.XtraGrid.Demos.Tutorials
   Public Class GridViewColumnButtonMenu
	   Inherits GridViewMenu
		Public Sub New(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView)
			MyBase.New(view)
		End Sub
		Protected Overrides Sub CreateItems()
			Items.Clear()
			Dim columnsItem As DXSubMenuItem = New DXSubMenuItem("Columns")
			Items.Add(columnsItem)
			Items.Add(CreateMenuItem("Runtime Column Customization", GridMenuImages.Column.Images(3), "Customization", True))
			For Each column As GridColumn In View.Columns
				If column.OptionsColumn.ShowInCustomizationForm Then
                    columnsItem.Items.Add(CreateMenuCheckItem(column.GetTextCaption(), column.VisibleIndex >= 0, Nothing, column, True))
				End If
			Next column
		End Sub
		Protected Overrides Sub OnMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
			If RaiseClickEvent(sender, Nothing) Then
			Return
			End If
			Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
			If item.Tag Is Nothing Then
			Return
			End If
			If TypeOf item.Tag Is GridColumn Then
				Dim column As GridColumn = TryCast(item.Tag, GridColumn)
				If column.VisibleIndex >= 0 Then
					column.VisibleIndex = -1
				Else
					column.VisibleIndex = View.VisibleColumns.Count
				End If
			ElseIf item.Tag.ToString() = "Customization" Then
			View.ColumnsCustomization()
			End If
		End Sub
   End Class
End Namespace
