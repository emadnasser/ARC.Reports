Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Reflection
Imports DevExpress.DashboardCommon
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.DashboardWin
Imports DevExpress.DashboardCommon.Native
Imports DevExpress.DataAccess

Namespace DashboardMainDemo.Modules
	Partial Public Class DashboardTutorialControl
		Inherits TutorialControlBase
		Private Shared Function CreateCopy(ByVal dashboard As Dashboard) As Dashboard
			Using stream As Stream = New MemoryStream()
				dashboard.SaveToXml(stream)
				stream.Seek(0L, SeekOrigin.Begin)
				Dim copy As New Dashboard()
				copy.LoadFromXml(stream)
				For i As Integer = 0 To dashboard.DataSources.Count - 1
					Dim dataSource As IDashboardDataSource = dashboard.DataSources(i)
					If TypeOf dataSource Is DashboardObjectDataSource Then
						copy.DataSources(i).Data = dataSource.Data
					End If
					Dim extractDataSource As DashboardExtractDataSource = TryCast(dataSource, DashboardExtractDataSource)
					If TypeOf extractDataSource Is DashboardExtractDataSource Then
						CType(copy.DataSources(i), DashboardExtractDataSource).FileName = extractDataSource.FileName
					End If
				Next i
				Return copy
			End Using
		End Function

		Private dashboardModified_Renamed As Boolean = False
		Private dashboard_Renamed As Dashboard

		Protected Property Dashboard() As Dashboard
			Get
				Return dashboard_Renamed
			End Get
			Set(ByVal value As Dashboard)
				If value IsNot dashboard_Renamed Then
					DisposeDashboard()
					dashboard_Renamed = value
					OnDashboardChanged()
				End If
			End Set
		End Property
		Protected Overridable ReadOnly Property ShowFooterPanel() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overridable ReadOnly Property CalculateHiddenTotals() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected ReadOnly Property DashboardViewer() As DashboardViewer
			Get
				Return dashboardViewer_Renamed
			End Get
		End Property
		Protected ReadOnly Property DashboardModified() As Boolean
			Get
				Return dashboardModified_Renamed
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			Initialize()
		End Sub
		Protected Overridable Sub EditDashboard()
			Using dashboard As Dashboard = CreateCopy(Me.Dashboard)
				Using designerForm As New DashboardDesignerForm(dashboard)
					designerForm.AllowFormGlass = If(DevExpress.Skins.SkinManager.AllowFormSkins, DefaultBoolean.False, DefaultBoolean.True)
					designerForm.ShowDialog()
					If designerForm.SaveDashboard Then
						Me.Dashboard = CreateCopy(designerForm.Dashboard)
						dashboardModified_Renamed = True
					End If
				End Using
			End Using
		End Sub
		Protected Overridable Sub SubscribeDashboardEvents()
		End Sub
		Private Sub OnDashboardChanged()
			dashboardViewer_Renamed.Dashboard = dashboard_Renamed
		End Sub
		Private Sub Initialize()
			panelFooter.Visible = ShowFooterPanel
			dashboardViewer_Renamed.CalculateHiddenTotals = CalculateHiddenTotals
			dashboardViewer_Renamed.DataSourceOptions.ObjectDataSourceLoadingBehavior = DocumentLoadingBehavior.LoadAsIs
			SubscribeDashboardEvents()
			LoadDashboard()
		End Sub
		Private Sub LoadDashboard()
			Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
			Dim dashboardType As Type = asm.GetType(String.Format("DashboardMainDemo.Dashboards.{0}", Me.GetType().Name))
			If dashboardType IsNot Nothing Then
				Dashboard = CType(Activator.CreateInstance(dashboardType), Dashboard)
			Else
				Dashboard = Nothing
			End If
		End Sub
		Private Sub DisposeDashboard()
			If dashboard_Renamed IsNot Nothing Then
				dashboard_Renamed.Dispose()
			End If
		End Sub
		Private Sub btnEditDashboard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditDashboard.Click
			EditDashboard()
		End Sub
	End Class
End Namespace
