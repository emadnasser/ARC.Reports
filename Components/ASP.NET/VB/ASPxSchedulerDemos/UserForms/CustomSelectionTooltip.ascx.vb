Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Internal
Imports DevExpress.Web

Partial Public Class UserForms_CustomSelectionTooltip
	Inherits ASPxSchedulerToolTipBase
	Public Overrides ReadOnly Property ClassName() As String
		Get
			Return "ASPxClientSelectionToolTip"
		End Get
	End Property
	Public Overrides ReadOnly Property ToolTipShowStem() As Boolean
		Get
			Return False
		End Get
	End Property
	Public Overrides ReadOnly Property ToolTipResetPositionByTimer() As Boolean
		Get
			Return False
		End Get
	End Property
	'public override bool ToolTipCloseOnClick { get { return true; } }

	Protected Overrides Sub OnLoad(ByVal e As EventArgs)
		MyBase.OnLoad(e)
	End Sub
	Protected Overrides Function GetChildControls() As Control()
		Dim controls() As Control = { lblInterval, tbSubject, btnCreate, lblShowMenu, imgCloseButton}
		Return controls
	End Function
End Class
