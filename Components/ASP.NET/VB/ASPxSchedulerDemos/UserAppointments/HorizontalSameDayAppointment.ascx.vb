Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Drawing
Imports System.Web

Partial Public Class HorizontalSameDayAppointment
	Inherits System.Web.UI.UserControl
	Private ReadOnly Property Container() As HorizontalAppointmentTemplateContainer
		Get
			Return CType(Parent, HorizontalAppointmentTemplateContainer)
		End Get
	End Property
	Private ReadOnly Property Items() As HorizontalAppointmentTemplateItems
		Get
			Return Container.Items
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Me.lblSubject.Text = HttpUtility.HtmlEncode(Container.AppointmentViewInfo.Appointment.Subject)
		Me.lblLocation.Text = GetLocationText()
		LayoutAppointmentImages()
	End Sub
	Private Function GetLocationText() As String
		Dim location As String = HttpUtility.HtmlEncode(Container.AppointmentViewInfo.Appointment.Location)
		If String.IsNullOrEmpty(location) Then
			Return String.Empty
		Else
			Return String.Format("({0})", location)
		End If
	End Function

	Private Sub LayoutAppointmentImages()
		Dim count As Integer = Items.Images.Count
		Dim row As New HtmlTableRow()
		row.Cells.Add(New HtmlTableCell())
		For i As Integer = 0 To count - 1
			Dim cell As New HtmlTableCell()
			AddImage(cell, Items.Images(i))
			row.Cells.Add(cell)
		Next i
		imageContainer.Rows.Add(row)
	End Sub
	Private Sub AddImage(ByVal targetCell As HtmlTableCell, ByVal imageItem As AppointmentImageItem)
		Dim image As New Image()
		imageItem.ImageProperties.AssignToControl(image, False)
		targetCell.Controls.Add(image)
	End Sub
End Class
