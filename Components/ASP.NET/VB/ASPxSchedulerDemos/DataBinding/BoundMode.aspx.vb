Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Data
Imports System.Drawing
Imports System.Web.UI
Imports System.Linq
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.XtraScheduler

Partial Public Class DataBinding_BoundMode
	Inherits System.Web.UI.Page
	Protected Overrides Sub OnInitComplete(ByVal e As EventArgs)
		MyBase.OnInitComplete(e)

		DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource)
		DataHelper.SetupStatuses(ASPxScheduler1)
		DataHelper.SetupLabels(ASPxScheduler1)
		ASPxScheduler1.OptionsBehavior.ShowDetailedErrorInfo = False
		DataHelper.EnsureOnlineVersionModificationLock(ASPxScheduler1)
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SchedulerDemoUtils.ApplyDefaults(Me, ASPxScheduler1)
	End Sub
End Class
