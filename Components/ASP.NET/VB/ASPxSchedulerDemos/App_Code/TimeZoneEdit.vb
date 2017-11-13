Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI.WebControls
Imports DevExpress.Web.Internal
Imports DevExpress.Web
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Internal
Imports DevExpress.XtraScheduler

Namespace DevExpress.Web.Demos.ASPxScheduler
	#Region "ASPxTimeZoneEditEx"
	Public Class ASPxTimeZoneEditEx
		Inherits ASPxTimeZoneEdit
		Private Const ScriptFileName As String = "ASPxTimeZoneEditEx.js"
		Private timeRuler_Renamed As TimeRuler = Nothing
		Public Property TimeRuler() As DevExpress.XtraScheduler.TimeRuler
			Get
				Return timeRuler_Renamed
			End Get
			Set(ByVal value As DevExpress.XtraScheduler.TimeRuler)
				timeRuler_Renamed = value
			End Set
		End Property

		Protected Overrides Sub InitializeComboBox(ByVal combo As ASPxComboBox)
			MyBase.InitializeComboBox(combo)
			combo.DropDownButton.Visible = False
			combo.Font.Size = FontUnit.Point(8)
			combo.Cursor = "pointer"
		End Sub
		Public Overrides Function GetActualTimeZone() As String
			If TimeRuler Is Nothing Then
				Return "Hawaiian Standard Time"
			End If
			Return TimeRuler.TimeZoneId
		End Function

		#Region "Client scripts support"
		Protected Overrides Sub RegisterIncludeScripts()
			MyBase.RegisterIncludeScripts()
			RegisterIncludeScript(GetType(ASPxTimeZoneEditEx), ASPxTimeZoneEditEx.ScriptFileName)
		End Sub
		Protected Shadows Sub RegisterIncludeScript(ByVal type As Type, ByVal resourceName As String)
			Dim key As String = type.FullName & "_" & resourceName
			If ResourceManager.ScriptBlocksRegistrator.RegisteredScriptBlocks.ContainsKey(key) Then
				Return
			End If
			Dim url As String = resourceName

			RegisterScriptBlock(key, RenderUtils.GetIncludeScriptHtml(url))
		End Sub

		Protected Overrides Function GetClientObjectClassName() As String
			Return "ASPxClientTimeZoneEditEx"
		End Function
		Protected Overrides Function GetComboOnChange() As String
			If TimeRuler IsNot Nothing Then
				Dim control As DevExpress.Web.ASPxScheduler.ASPxScheduler = CType(Me.MasterControl, DevExpress.Web.ASPxScheduler.ASPxScheduler)
				Dim rulers As TimeRulerCollection = control.DayView.TimeRulers
				Dim indx As Integer = rulers.IndexOf(TimeRuler)
				Return String.Format("function(s, e) {{ aspxTimeZoneEditComboSelectedIndexChangedEx('{0}', s.GetValue(), {1}); }}", ClientID, indx)
			End If
			Return String.Empty
		End Function
		#End Region
	End Class
	#End Region
	#Region "ChangeTimeZoneCallbackCommand"
	Public Class ChangeTimeZoneCallbackCommand
		Inherits SchedulerCallbackCommand
		Public Const CommandId As String = "UTZCH"
		#Region "Fields"
		Private timeZoneId_Renamed As String
		Private index_Renamed As Integer
		#End Region

		Public Sub New(ByVal control As DevExpress.Web.ASPxScheduler.ASPxScheduler)
			MyBase.New(control)
		End Sub

		#Region "Properties"
		Public ReadOnly Property TimeZoneId() As String
			Get
				Return timeZoneId_Renamed
			End Get
		End Property
		Public ReadOnly Property Index() As Integer
			Get
				Return index_Renamed
			End Get
		End Property
		Public Overrides ReadOnly Property Id() As String
			Get
				Return CommandId
			End Get
		End Property
		#End Region

		Protected Overrides Sub ParseParameters(ByVal parameters As String)
			Dim args() As String = parameters.Split(New Char() { ","c })
			Me.timeZoneId_Renamed = args(0)
			Me.index_Renamed = Int32.Parse(args(1))
		End Sub

		Protected Overrides Sub ExecuteCore()
			Control.DayView.TimeRulers(Index).TimeZoneId = TimeZoneId
		End Sub
	End Class
	#End Region
End Namespace
