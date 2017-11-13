Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Drawing
Imports System.Web

Partial Public Class VerticalAppointment
	Inherits System.Web.UI.UserControl
	Private ReadOnly Property Container() As VerticalAppointmentTemplateContainer
		Get
			Return CType(Parent, VerticalAppointmentTemplateContainer)
		End Get
	End Property
	Private ReadOnly Property Items() As VerticalAppointmentTemplateItems
		Get
			Return Container.Items
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Me.lblHeader.Text = GetHeaderText()
		Me.lblSubject.Text = HttpUtility.HtmlEncode(Container.AppointmentViewInfo.Appointment.Subject)
		Me.lblLocation.Text = HttpUtility.HtmlEncode(Container.AppointmentViewInfo.Appointment.Location)
		Me.lblDescription.Text = HttpUtility.HtmlEncode(Container.AppointmentViewInfo.Appointment.Description)

		LayoutAppointmentImages()
	End Sub
	Private Function GetHeaderText() As String
		Dim start As String = Container.AppointmentViewInfo.AppointmentInterval.Start.ToShortTimeString()
		Dim [end] As String = Container.AppointmentViewInfo.Appointment.End.ToShortTimeString()
		Return String.Format("{0} - {1}", start, [end])
	End Function
	Private Sub LayoutAppointmentImages()
		Dim count As Integer = Items.Images.Count
		For i As Integer = 0 To count - 1
			Dim row As New HtmlTableRow()
			Dim cell As New HtmlTableCell()
			AddImage(cell, Items.Images(i))
			row.Cells.Add(cell)
			imageContainer.Rows.Add(row)
		Next i
	End Sub
	Private Sub AddImage(ByVal targetCell As HtmlTableCell, ByVal imageItem As AppointmentImageItem)
		Dim image As New Image()
		imageItem.ImageProperties.AssignToControl(image, False)
		targetCell.Controls.Add(image)
	End Sub
End Class
