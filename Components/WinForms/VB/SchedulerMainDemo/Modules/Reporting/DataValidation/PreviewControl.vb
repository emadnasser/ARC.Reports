Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Reporting
Imports System.Collections.Generic

Namespace DevExpress.XtraScheduler.Demos.Reporting.DataValidation

	Public Class PreviewControl
		Inherits SingleReportPreviewControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents cmbResources As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cmbDays As DevExpress.XtraEditors.ImageComboBoxEdit
		Private layoutControlItem2 As XtraLayout.LayoutControlItem
		Private layoutControlItem3 As XtraLayout.LayoutControlItem
		Private layoutControlItem4 As XtraLayout.LayoutControlItem
		Private WithEvents cmbAppointments As DevExpress.XtraEditors.ImageComboBoxEdit
		Private navigationPaneSettings As XtraBars.Navigation.NavigationPane
		Private navigationPageSettings As XtraBars.Navigation.NavigationPage
		Private layoutControlSettings As XtraLayout.LayoutControl
		Private layoutControlGroupSettings As XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
		Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
		Private WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton

		Public Shadows ReadOnly Property Report() As Report
			Get
				Return CType(MyBase.Report, Report)
			End Get
		End Property

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			UpdateActiveReport()
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub
		Protected Overrides Function CreateReportInstance() As XtraSchedulerReport
			Return New Report()
		End Function
		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
			Me.cmbResources = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cmbAppointments = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.cmbDays = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControlSettings = New DevExpress.XtraLayout.LayoutControl()
			Me.layoutControlGroupSettings = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.navigationPaneSettings = New DevExpress.XtraBars.Navigation.NavigationPane()
			Me.navigationPageSettings = New DevExpress.XtraBars.Navigation.NavigationPage()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.fSchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.navigationPaneSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.navigationPaneSettings.SuspendLayout()
			Me.navigationPageSettings.SuspendLayout()
			CType(Me.layoutControlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControlSettings.SuspendLayout()
			CType(Me.layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbResources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbAppointments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbDays.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnEdit
			' 
			Me.btnEdit.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnEdit.Location = New System.Drawing.Point(7, 7)
			Me.btnEdit.Name = "btnEdit"
			Me.btnEdit.Size = New System.Drawing.Size(201, 22)
			Me.btnEdit.StyleController = Me.layoutControlSettings
			Me.btnEdit.TabIndex = 2
			Me.btnEdit.Text = "Edit"
'			Me.btnEdit.Click += New System.EventHandler(Me.btnEdit_Click);
			' 
			' navigationPaneSettings
			' 
			Me.navigationPaneSettings.Controls.Add(Me.navigationPageSettings)
			Me.navigationPaneSettings.Dock = System.Windows.Forms.DockStyle.Right
			Me.navigationPaneSettings.ItemOrientation = System.Windows.Forms.Orientation.Vertical
			Me.navigationPaneSettings.Location = New System.Drawing.Point(455, 0)
			Me.navigationPaneSettings.Name = "navigationPaneSettings"
			Me.navigationPaneSettings.PageProperties.ShowExpandButton = False
			Me.navigationPaneSettings.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPageSettings})
			Me.navigationPaneSettings.SelectedPage = Me.navigationPageSettings
			Me.navigationPaneSettings.TabIndex = 11
			Me.navigationPaneSettings.Text = "navigationPane1"
			Me.navigationPaneSettings.RegularSize = New System.Drawing.Size(245, 396)
			Me.navigationPaneSettings.Size = New System.Drawing.Size(245, 396)
			' 
			' navigationPageSettings
			' 
			Me.navigationPageSettings.BackgroundPadding = New System.Windows.Forms.Padding(0)
			Me.navigationPageSettings.Caption = "Options"
			Me.navigationPageSettings.Controls.Add(Me.layoutControlSettings)
			Me.navigationPageSettings.Image = (CType(resources.GetObject("navigationPageSettings.Image"), System.Drawing.Image))
			Me.navigationPageSettings.Name = "navigationPageSettings"
			Me.navigationPageSettings.Size = New System.Drawing.Size(215, 352)
			' 
			' layoutControlSettings
			' 
			Me.layoutControlSettings.Controls.Add(Me.btnEdit)
			Me.layoutControlSettings.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControlSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlSettings.Name = "layoutControlSettings"
			Me.layoutControlSettings.Root = Me.layoutControlGroupSettings
			Me.layoutControlSettings.Size = New System.Drawing.Size(215, 352)
			Me.layoutControlSettings.TabIndex = 0
			Me.layoutControlSettings.Text = "layoutControl1"
			Me.layoutControlSettings.Controls.Add(Me.cmbDays)
			Me.layoutControlSettings.Controls.Add(Me.cmbAppointments)
			Me.layoutControlSettings.Controls.Add(Me.cmbResources)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.cmbResources, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.cmbAppointments, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.cmbDays, 0)
			' 
			' layoutControlGroupSettings
			' 
			Me.layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroupSettings.GroupBordersVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.emptySpaceItem1, Me.emptySpaceItem2})
			Me.layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlGroupSettings.Size = New System.Drawing.Size(215, 352)
			Me.layoutControlGroupSettings.TextVisible = False
			Me.layoutControlGroupSettings.Name = "layoutControlGroup1"
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4})
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.btnEdit
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(205, 26)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.AllowHotTrack = False
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 26)
			Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(205, 10)
			Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.AllowHotTrack = False
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 108)
			Me.emptySpaceItem2.Size = New System.Drawing.Size(205, 234)

			' 
			' fStoragePrintAdapter
			' 
'			Me.fStoragePrintAdapter.ValidateTimeIntervals += New DevExpress.XtraScheduler.Reporting.TimeIntervalsValidationEventHandler(Me.storagePrintAdapter_ValidateTimeIntervals);
'			Me.fStoragePrintAdapter.ValidateResources += New DevExpress.XtraScheduler.Reporting.ResourcesValidationEventHandler(Me.storagePrintAdapter_ValidateResources);
			' 
			' cmbResources
			' 
			Me.cmbResources.EditValue = "All"
			Me.cmbResources.Location = New System.Drawing.Point(81, 43)
			Me.cmbResources.Name = "cmbResources"
			Me.cmbResources.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbResources.Properties.Items.AddRange(New Object() { "All", "Top 3 ", "A-Z order", "Z-A order", ""})
			Me.cmbResources.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbResources.Size = New System.Drawing.Size(127, 20)
			Me.cmbResources.StyleController = Me.layoutControlSettings
			Me.cmbResources.TabIndex = 13
'			Me.cmbResources.SelectedIndexChanged += New System.EventHandler(Me.cmbResources_SelectedIndexChanged);
			' 
			' cmbAppointments
			' 
			Me.cmbAppointments.EditValue = DevExpress.XtraScheduler.UsedAppointmentType.All
			Me.cmbAppointments.Location = New System.Drawing.Point(81, 67)
			Me.cmbAppointments.Name = "cmbAppointments"
			Me.cmbAppointments.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbAppointments.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("All", DevExpress.XtraScheduler.UsedAppointmentType.All, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Recurring", DevExpress.XtraScheduler.UsedAppointmentType.Recurring, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("NonRecurring", DevExpress.XtraScheduler.UsedAppointmentType.NonRecurring, -1)})
			Me.cmbAppointments.Size = New System.Drawing.Size(127, 20)
			Me.cmbAppointments.StyleController = Me.layoutControlSettings
			Me.cmbAppointments.TabIndex = 38
'			Me.cmbAppointments.SelectedIndexChanged += New System.EventHandler(Me.cmbAppointments_SelectedIndexChanged);
			' 
			' cmbDays
			' 
			Me.cmbDays.EditValue = (CType(((((((DevExpress.XtraScheduler.WeekDays.Sunday Or DevExpress.XtraScheduler.WeekDays.Monday) Or DevExpress.XtraScheduler.WeekDays.Tuesday) Or DevExpress.XtraScheduler.WeekDays.Wednesday) Or DevExpress.XtraScheduler.WeekDays.Thursday) Or DevExpress.XtraScheduler.WeekDays.Friday) Or DevExpress.XtraScheduler.WeekDays.Saturday), DevExpress.XtraScheduler.WeekDays))
			Me.cmbDays.Location = New System.Drawing.Point(81, 91)
			Me.cmbDays.Name = "cmbDays"
			Me.cmbDays.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbDays.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Every Day", (CType(((((((DevExpress.XtraScheduler.WeekDays.Sunday Or DevExpress.XtraScheduler.WeekDays.Monday) Or DevExpress.XtraScheduler.WeekDays.Tuesday) Or DevExpress.XtraScheduler.WeekDays.Wednesday) Or DevExpress.XtraScheduler.WeekDays.Thursday) Or DevExpress.XtraScheduler.WeekDays.Friday) Or DevExpress.XtraScheduler.WeekDays.Saturday), DevExpress.XtraScheduler.WeekDays)), -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Work Days", (CType(((((DevExpress.XtraScheduler.WeekDays.Monday Or DevExpress.XtraScheduler.WeekDays.Tuesday) Or DevExpress.XtraScheduler.WeekDays.Wednesday) Or DevExpress.XtraScheduler.WeekDays.Thursday) Or DevExpress.XtraScheduler.WeekDays.Friday), DevExpress.XtraScheduler.WeekDays)), -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Weekend Days", (CType((DevExpress.XtraScheduler.WeekDays.Sunday Or DevExpress.XtraScheduler.WeekDays.Saturday), DevExpress.XtraScheduler.WeekDays)), -1)})
			Me.cmbDays.Size = New System.Drawing.Size(127, 20)
			Me.cmbDays.StyleController = Me.layoutControlSettings
			Me.cmbDays.TabIndex = 40
'			Me.cmbDays.SelectedIndexChanged += New System.EventHandler(Me.cmbDays_SelectedIndexChanged);
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.cmbResources
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 36)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(205, 24)
			Me.layoutControlItem2.Text = "Resources:"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(70, 13)
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.cmbAppointments
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 60)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(205, 24)
			Me.layoutControlItem3.Text = "Appointments:"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(70, 13)
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.cmbDays
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 84)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(205, 24)
			Me.layoutControlItem4.Text = "Days:"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(70, 13)
			' 
			' PreviewControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "PreviewControl"
			Me.Controls.Add(Me.navigationPaneSettings)
			CType(Me.fSchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.navigationPaneSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.navigationPaneSettings.ResumeLayout(False)
			Me.navigationPageSettings.ResumeLayout(False)
			CType(Me.layoutControlSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControlSettings.ResumeLayout(False)
			CType(Me.layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbResources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbAppointments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbDays.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region
		Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
			Dim designForm As New CustomDesignForm()
			Dim report As XtraSchedulerReport = GetActiveReport()
			If report Is Nothing Then
				Return
			End If

			designForm.OpenReport(report)
			PreventUpdate = True
			Try
				ShowDesignerForm(designForm, Me.FindForm())
			Finally
				PreventUpdate = False
			End Try
			designForm.Dispose()

			CreateReports()
			UpdateActiveReport()
		End Sub
		Protected Overrides Sub InitAdapterTimeInterval()
			StoragePrintAdapter.TimeInterval = New TimeInterval(BaseDate, TimeSpan.FromDays(10))
		End Sub

		Protected Overrides Sub DoValidateAppointments(ByVal e As AppointmentsValidationEventArgs)
			MyBase.DoValidateAppointments(e)
			Dim aptType As UsedAppointmentType = CType(cmbAppointments.EditValue, UsedAppointmentType)
			If aptType.Equals(UsedAppointmentType.All) Then
				Return
			End If

			If aptType.Equals(UsedAppointmentType.None) Then
				e.Appointments.Clear()
				Return
			End If
			Dim count As Integer = e.Appointments.Count
			Dim result As New AppointmentBaseCollection()
			For i As Integer = 0 To count - 1
				Dim apt As Appointment = e.Appointments(i)
				If aptType.Equals(UsedAppointmentType.Recurring) AndAlso apt.IsRecurring Then
					result.Add(apt)
				End If
				If aptType.Equals(UsedAppointmentType.NonRecurring) AndAlso (Not apt.IsRecurring) Then
					result.Add(apt)
				End If
			Next i
			e.Appointments.Clear()
			e.Appointments.AddRange(result)
		End Sub

		Private Sub storagePrintAdapter_ValidateResources(ByVal sender As Object, ByVal e As ResourcesValidationEventArgs) Handles fStoragePrintAdapter.ValidateResources
			Dim resourceMode As Integer = cmbResources.SelectedIndex
			If resourceMode = 1 Then
				Dim count As Integer = e.Resources.Count
				For i As Integer = count - 1 To 3 Step -1
					e.Resources.RemoveAt(i)
				Next i
			End If
			If resourceMode = 2 Then
				e.Resources.Sort(New ResourceCaptionComparer())
			End If
			If resourceMode = 3 Then
				e.Resources.Sort(New ResourceCaptionReverseComparer())
			End If
		End Sub

		Private Sub storagePrintAdapter_ValidateTimeIntervals(ByVal sender As Object, ByVal e As TimeIntervalsValidationEventArgs) Handles fStoragePrintAdapter.ValidateTimeIntervals
			Dim weekDays As WeekDays = CType(cmbDays.EditValue, WeekDays)
			If weekDays.Equals(WeekDays.EveryDay) Then
				Return
			End If

			Dim count As Integer = e.Intervals.Count

			Dim result As New DayIntervalCollection()
			For i As Integer = count - 1 To 0 Step -1
				Dim sourceDays As New DayIntervalCollection()
				sourceDays.Add(e.Intervals(i))
				FilterDays(sourceDays, weekDays)
				result.AddRange(sourceDays)
			Next i

			e.Intervals.Clear()
			For i As Integer = 0 To result.Count - 1
				e.Intervals.Add(result(i))
			Next i

		End Sub
		Private Sub FilterDays(ByVal dayIntervals As DayIntervalCollection, ByVal validDays As WeekDays)
			Dim count As Integer = dayIntervals.Count
			For i As Integer = count - 1 To 0 Step -1
				Dim day As DayOfWeek = dayIntervals(i).Start.DayOfWeek
				Dim weekDay As WeekDays = DevExpress.XtraScheduler.Native.DateTimeHelper.ToWeekDays(day)
				If Not(weekDay And validDays).Equals(weekDay) Then
					dayIntervals.RemoveAt(i)
				End If
			Next i
		End Sub
		Private Sub cmbResources_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbResources.SelectedIndexChanged
			UpdateActiveReport()
		End Sub

		Private Sub cmbAppointments_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbAppointments.SelectedIndexChanged
			UpdateActiveReport()
		End Sub

		Private Sub cmbDays_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbDays.SelectedIndexChanged
			CreateReports()
			UpdateActiveReport()
		End Sub

	End Class
	Public Class ResourceCaptionComparer
		Implements IComparer(Of Resource), IComparer

		#Region "IComparer Members"
		Private Function IComparer_Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
			Return CompareCore(x, y)
		End Function
		Public Function Compare(ByVal x As Resource, ByVal y As Resource) As Integer Implements IComparer(Of Resource).Compare
			Return CompareCore(x, y)
		End Function
		#End Region

		Protected Overridable Function CompareCore(ByVal x As Object, ByVal y As Object) As Integer
			Dim xRes As Resource = CType(x, Resource)
			Dim yRes As Resource = CType(y, Resource)
			If xRes Is Nothing OrElse yRes Is Nothing Then
				Return 0
			End If
			If EmptyResourceId.Id.Equals(xRes.Id) OrElse EmptyResourceId.Id.Equals(yRes.Id) Then
				Return 0
			End If
			Return CompareCaptions(xRes, yRes)
		End Function
		Protected Overridable Function CompareCaptions(ByVal xRes As Resource, ByVal yRes As Resource) As Integer
			Return String.Compare(xRes.Caption, yRes.Caption)
		End Function

	End Class
	Public Class ResourceCaptionReverseComparer
		Inherits ResourceCaptionComparer
		Protected Overrides Function CompareCaptions(ByVal xRes As Resource, ByVal yRes As Resource) As Integer
			Return String.Compare(yRes.Caption, xRes.Caption)
		End Function
	End Class
End Namespace

