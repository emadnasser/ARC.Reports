Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class ResourceHeadersModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitializeComponent call
		End Sub
		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property

		Protected ReadOnly Property ResourceHeaderOptions() As SchedulerResourceHeaderOptions
			Get
				Return schedulerControl.OptionsView.ResourceHeaders
			End Get
		End Property

		Private Sub GroupByResourceModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitControlValues()
			CarsDataHelper.FillData(schedulerControl, schedulerStorage)
			UpdateResources()
			UpdateControls()
		End Sub
		Private Sub InitControlValues()
			cbHeaderHeight.EditValue = ResourceHeaderOptions.Height
			cbImageSize.EditValue = ResourceHeaderOptions.ImageSize
			cbImageAlign.EditValue = ResourceHeaderOptions.ImageAlign
			cbImageSizeMode.EditValue = ResourceHeaderOptions.ImageSizeMode
			chkRotateCaption.Checked = ResourceHeaderOptions.RotateCaption
			chkWordWrap.Checked = schedulerControl.Appearance.HeaderCaption.TextOptions.WordWrap = WordWrap.Wrap
		End Sub
		Private Sub UpdateResources()
			For Each res As Resource In schedulerStorage.Resources.Items
				Dim imageName As String = String.Format("CarsData.Images.{0}.png", res.Id)
				Dim image As Image = ResourceImageHelper.CreateImageFromResources(DemoUtils.FindResourceName(imageName), System.Reflection.Assembly.GetExecutingAssembly())
				res.SetImage(image)
			Next res
		End Sub
		Private Sub chkWordWrap_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkWordWrap.CheckedChanged
			Dim wrap As WordWrap = If(chkWordWrap.Checked, WordWrap.Wrap, WordWrap.Default)
			schedulerControl.Appearance.HeaderCaption.TextOptions.WordWrap = wrap
		End Sub
		Private Sub cbImageSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbImageSize.SelectedIndexChanged
			ResourceHeaderOptions.ImageSize = CType(cbImageSize.EditValue, Size)
		End Sub

		Private Sub cbHeaderHeight_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbHeaderHeight.EditValueChanged
			Dim stringValue As String = TryCast(cbHeaderHeight.EditValue, String)
			If stringValue IsNot Nothing Then
				Return
			End If
			ResourceHeaderOptions.Height = Convert.ToInt32(cbHeaderHeight.EditValue)
		End Sub

		Private Sub schedulerControl_ActiveViewChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles schedulerControl.ActiveViewChanged
			UpdateControls()
		End Sub
		Private Sub chkRotateCaption_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkRotateCaption.CheckedChanged
			ResourceHeaderOptions.RotateCaption = chkRotateCaption.Checked
		End Sub
		Private Sub cbImageAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbImageAlign.SelectedIndexChanged
			ResourceHeaderOptions.ImageAlign = CType(cbImageAlign.EditValue, HeaderImageAlign)
		End Sub
		Private Sub UpdateControls()
			Dim view As SchedulerViewBase = schedulerControl.ActiveView
			Dim groupType As SchedulerGroupType = schedulerControl.GroupType
			chkRotateCaption.Enabled = (TypeOf view Is WeekView AndAlso groupType.Equals(SchedulerGroupType.Date)) OrElse (TypeOf view Is TimelineView AndAlso (Not groupType.Equals(SchedulerGroupType.None)))
		End Sub
		Private Sub cbImageSizeMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbImageSizeMode.SelectedIndexChanged
			ResourceHeaderOptions.ImageSizeMode = CType(cbImageSizeMode.EditValue, HeaderImageSizeMode)
		End Sub
		Private Sub schedulerControl_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles schedulerControl.DoubleClick
			Dim pt As Point = schedulerControl.PointToClient(Control.MousePosition)
			Dim hitInfo As SchedulerHitInfo = schedulerControl.ActiveView.ViewInfo.CalcHitInfo(pt, True)
			If hitInfo.HitTest = SchedulerHitTest.ResourceHeader Then
				Dim customImage As Image = LoadCustomResourceImage()
				If customImage IsNot Nothing Then
					Dim header As ResourceHeader = CType(hitInfo.ViewInfo, ResourceHeader)
					header.Resource.SetImage(customImage)
					schedulerControl.ActiveView.LayoutChanged()
				End If
			End If
		End Sub

		Private Function LoadCustomResourceImage() As Image
			Dim image As Image = Nothing
			Dim dlg As New OpenFileDialog()
			dlg.Title = "Select image file"
			dlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.PNG;*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"

			If dlg.ShowDialog() = DialogResult.OK Then
				image = LoadImageFromFile(dlg.FileName)
			End If
			Return image
		End Function

		Private Function LoadImageFromFile(ByVal fileName As String) As Image
			Dim image As Image = Nothing
			Try
				image = Image.FromFile(fileName)
			Catch e As Exception
				XtraMessageBox.Show("Can't load image from file - " & e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
			Return image
		End Function

		Private Sub schedulerControl_GroupTypeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles schedulerControl.GroupTypeChanged
			UpdateControls()
		End Sub
	End Class
End Namespace

