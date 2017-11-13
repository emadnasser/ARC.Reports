Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.XtraScheduler

Partial Public Class Miscellaneous_EndUserRestrictions
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
'        
'            The following code utilizes the DataHelper class, which is implemented
'            solely for the ASPxScheduler Demo project.
'            It is intended to hide unnecessary details and clarify the main idea.
'            For the recommended data binding techniques, please refer to the
'            Data Binding section modules:
'              ~/DataBinding/BoundMode.aspx for MS Access database
'              ~/DataBinding/ListBoundMode.aspx for the object with IBindingList interface.
'              ~/DataBinding/XPOBoundMode.aspx for XPO data framework.
'        
		SchedulerDemoUtils.ApplyDefaults(Me, ASPxScheduler1)
		SchedulerDemoUtils.ApplyWorkTime(Me, ASPxScheduler1)
		DataHelper.SetupDefaultMappings(ASPxScheduler1)
		DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource)
		DataHelper.SetupStatuses(ASPxScheduler1)
		DataHelper.SetupLabels(ASPxScheduler1)
		ASPxScheduler1.DataBind()

		ApplyUserRestrictions()
	End Sub

	Private Sub ApplyUserRestrictions()
		ASPxScheduler1.BeginUpdate()
		Try
			Dim options As SchedulerOptionsCustomization = ASPxScheduler1.OptionsCustomization
			options.AllowAppointmentConflicts = If(chkAllowConflicts.Checked, AppointmentConflictsMode.Allowed, AppointmentConflictsMode.Forbidden)
			options.AllowAppointmentCopy = ToUsedAppointmentType(chkAllowCopy)
			options.AllowAppointmentCreate = ToUsedAppointmentType(chkAllowCreate)
			options.AllowAppointmentDelete = ToUsedAppointmentType(chkAllowDelete)
			options.AllowAppointmentDrag = ToUsedAppointmentType(chkAllowDrag)
			options.AllowAppointmentDragBetweenResources = ToUsedAppointmentType(chkAllowDragBetweenResources)
			options.AllowAppointmentEdit = ToUsedAppointmentType(chkAllowEdit)
			options.AllowInplaceEditor = ToUsedAppointmentType(chkAllowInplaceEditor)
			options.AllowAppointmentMultiSelect = chkAllowMultiSelect.Checked
			options.AllowAppointmentResize = ToUsedAppointmentType(chkAllowResize)
		Finally
			ASPxScheduler1.EndUpdate()
		End Try
		ASPxScheduler1.ApplyChanges(ASPxSchedulerChangeAction.RenderViewMenu)
	End Sub

	Private Function ToUsedAppointmentType(ByVal chk As ASPxCheckBox) As UsedAppointmentType
		Return If(chk.Checked, UsedAppointmentType.All, UsedAppointmentType.None)
	End Function
End Class
