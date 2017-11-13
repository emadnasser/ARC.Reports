Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class TitleIndex_Filtering
	Inherits Page
	Private ReadOnly Property CurrentFilterBoxHorizontalPosition() As FilterBoxPosition
		Get
			Return CType(System.Enum.Parse(GetType(FilterBoxPosition), ddlHorizontalPosition.SelectedItem.Value.ToString()), FilterBoxPosition)
		End Get
	End Property
	Private ReadOnly Property CurrentFilterBoxVerticalPosition() As FilterBoxVerticalPosition
		Get
			Return CType(System.Enum.Parse(GetType(FilterBoxVerticalPosition), ddlVerticalPosition.SelectedItem.Value.ToString()), FilterBoxVerticalPosition)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Return
		End If
		titleIndex.SoftFiltering = cbSoftFiltering.Checked
		titleIndex.FilterBox.HorizontalPosition = CurrentFilterBoxHorizontalPosition
		titleIndex.FilterBox.VerticalPosition = CurrentFilterBoxVerticalPosition
	End Sub

	Protected Sub btnApply_Click(ByVal sender As Object, ByVal e As EventArgs)
		titleIndex.FilterBox.Delay = CInt(Fix(seDelay.Number))
	End Sub
End Class
