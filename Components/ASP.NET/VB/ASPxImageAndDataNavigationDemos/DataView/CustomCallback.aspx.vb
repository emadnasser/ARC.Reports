Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.Demos

Partial Public Class DataView_EnableCallback
	Inherits Page
	Protected sortField As String = ""
	Protected sortDescending As Boolean = False

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCssLink(Me, "~/DataView/CSS/CustomCallback.css")
		If IsPostBack Then
			PrepareQuery()
		End If
	End Sub


	Public ReadOnly Property ImagePath() As String
		Get
			Return "~\DataView\Images\Cameras\"
		End Get
	End Property

	Public Function SortColor(ByVal parameter As String) As String
		Return If(Me.sortField.Equals(parameter), "dvcSortColor", "")
	End Function

	Protected Sub PrepareQuery()
		Me.sortField = If((cbSortField.Value IsNot Nothing), cbSortField.Value.ToString(), "")
		Me.sortDescending = cbSortOrder.SelectedIndex = 1
		Dim sortOrder As String = If(sortDescending, "DESC", String.Empty)
		If (Not String.IsNullOrEmpty(Me.sortField)) Then
			CamerasDataSource.OrderBy += String.Format("it.{0} {1}", sortField, sortOrder)
		End If
		dvCameras.DataBind()
	End Sub
End Class
