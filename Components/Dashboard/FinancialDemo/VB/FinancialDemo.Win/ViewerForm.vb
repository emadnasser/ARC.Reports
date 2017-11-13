Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Windows.Forms
Imports DashboardDemos.Core
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraEditors
Imports DevExpress.DashboardCommon

Namespace FinanceDashboardDemo
	Partial Public Class ViewerForm
		Inherits XtraForm
		Private Const dashboardId As Integer = 1
		Private currentDashboardStream As MemoryStream
		Private dashboardStorageConnectionString, financialDemoConnectionString, corporateDemoConnectionString As String

		Public Sub New()
			InitializeComponent()
			barItemRefresh.Enabled = False
			barItemExport.Enabled = False
			barItemParameters.Enabled = False
			gallerySkins.Manager = barManager
			SkinHelper.InitSkinGalleryDropDown(gallerySkins)
			standaloneBarDockControl1.AllowTransparency = True
			AddHandler dashboardViewer.ConfigureDataConnection, AddressOf dashboardViewer_ConfigureDataConnection
		End Sub

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
				If currentDashboardStream IsNot Nothing Then
					currentDashboardStream.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		Private Sub RefreshDashboard()
			Try
				Dim ms As MemoryStream = DashboardDemosUtils.GetDashboardStream(dashboardStorageConnectionString, dashboardId)
				If ms IsNot Nothing Then
					If currentDashboardStream IsNot Nothing Then
						currentDashboardStream.Dispose()
					End If
					currentDashboardStream = ms
				End If
				If currentDashboardStream IsNot Nothing Then
					dashboardViewer.LoadDashboard (currentDashboardStream)
					dashboardViewer.Dashboard.Title.Visible = False
				End If
			Catch e As Exception
				XtraMessageBox.Show(If(e.InnerException IsNot Nothing, e.InnerException.Message, e.Message), "Finance Dashboard Demo", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End Sub
		Private Sub dashboardViewer_ConfigureDataConnection(ByVal sender As Object, ByVal e As DashboardConfigureDataConnectionEventArgs)
			If e.ConnectionName = "FinanceDemoConnection" Then
				Dim connectionParameters As New CustomStringConnectionParameters(financialDemoConnectionString)
				e.ConnectionParameters = connectionParameters
			End If
		End Sub
		Private Sub FinanceDashboardDemo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			dashboardStorageConnectionString = DashboardDemosUtils.DashboardStorageConnectionString
			financialDemoConnectionString = DashboardDemosUtils.FinancialDemoConnectionString
			corporateDemoConnectionString =DashboardDemosUtils.CorporateDemoConnectionString
			If (Not String.IsNullOrEmpty(dashboardStorageConnectionString)) Then
				If DashboardDemosUtils.CreateDatabasesWin(dashboardStorageConnectionString, financialDemoConnectionString, corporateDemoConnectionString) Then
					RefreshDashboard()
					barItemRefresh.Enabled = True
					barItemExport.Enabled = True
					barItemParameters.Enabled = True
				End If
			Else
				XtraMessageBox.Show("This demo requires SQL Server Express installed to automatically create a sample database. Alternatively, you can manually specify a connection string to the server where the database should be created. You can do this in the connections.config file.")
			End If
		End Sub
		Private Sub barItemPrint_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barItemPrint.ItemClick
			dashboardViewer.ShowPrintPreview()
		End Sub
		Private Sub barItemExportToPdf_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barItemExportToPdf.ItemClick
			Using sd As New SaveFileDialog()
				sd.Filter = "Pdf files|*.pdf"
				If sd.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
					dashboardViewer.ExportToPdf(sd.FileName)
				End If
			End Using
		End Sub
		Private Sub barItemExportToImage_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barItemExportToImage.ItemClick
			Using sd As New SaveFileDialog()
				sd.Filter = "PNG files|*.png"
				If sd.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
					dashboardViewer.ExportToImage(sd.FileName)
				End If
			End Using
		End Sub
		Private Sub barItemRefresh_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barItemRefresh.ItemClick
			RefreshDashboard()
		End Sub
		Private Sub barItemParameters_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barItemParameters.ItemClick
			dashboardViewer.ShowDashboardParametersForm()
		End Sub
	End Class
End Namespace
