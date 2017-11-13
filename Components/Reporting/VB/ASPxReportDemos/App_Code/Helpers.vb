Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Reflection
Imports System.Web
Imports DevExpress.XtraReports.UI

Public NotInheritable Class Helper
	Private Sub New()
	End Sub
	Public Shared Function GetReportPath(ByVal report As XtraReport, ByVal ext As String) As String
		Dim reportName As String = report.Name
		If String.IsNullOrEmpty(reportName) Then
			reportName = report.GetType().Name
		End If
		Dim directoryName As String = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
		Return Path.Combine(directoryName, String.Format("{0}.{1}", reportName, ext))
	End Function

	Public Shared Sub SetConnectionString(ByVal oleDbConnection As System.Data.OleDb.OleDbConnection, ByVal path As String)
		oleDbConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path
	End Sub

	Public Shared Function GetRelativePath(ByVal name As String) As String
		Return HttpContext.Current.Request.MapPath("~/App_Data/" & name)
	End Function

	Public Shared Function GetRelativeStyleSheetPath(ByVal styleSheetPath As String) As String
		Return GetRelativePath(styleSheetPath.Substring(styleSheetPath.LastIndexOf("\"c) + 1))
	End Function

	Private Shared ReadOnly Property IsIE6() As Boolean
		Get
			Dim browser As HttpBrowserCapabilities = HttpContext.Current.Request.Browser
			Return String.Equals(browser.Browser, "ie", StringComparison.InvariantCultureIgnoreCase) AndAlso browser.Version = "6.0"
		End Get
	End Property

	Public Shared Function GetPageBorderCSSLink() As String
		Return String.Format("<link rel=""stylesheet"" type=""text/css"" href=""{0}/Content/PageBorders/styles{1}.css"" />", HttpContext.Current.Request.ApplicationPath,If(IsIE6, "_ie6", String.Empty))
	End Function
End Class
