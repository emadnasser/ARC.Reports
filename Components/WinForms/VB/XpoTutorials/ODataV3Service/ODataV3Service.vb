Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo.DB
Imports DevExpress.Data.Filtering
Imports System.Globalization
Imports DevExpress.Xpo.DB.Helpers
Imports DevExpress.Xpo.Demos
Imports System.ServiceModel
Imports System.Threading
Imports DevExpress.Xpo.Metadata
Imports DevExpress.DemoData.Core
Imports System.Diagnostics
Imports DevExpress.Data.WcfLinq
Imports System.IO
Imports DevExpress.Xpo.Demos.ODataV3

Namespace DevExpress.Xpo.Demos
	Partial Public Class ODataV3Service
        Inherits TutorialControl
		Private serviceUri As Uri
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub sbEmployees_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbEmployees.Click
			Dim context As New NorthwindEntities(serviceUri)
			Dim dataSource As New WcfInstantFeedbackSource(Function(args) AnonymousMethod1(args, context))
			gclODataV3ServiceMain.DataSource = dataSource
		End Sub
		
        Private Function AnonymousMethod1(ByVal args As GetSourceEventArgs, ByVal context As NorthwindEntities) As Boolean
            args.KeyExpression = "CustomerID"
            args.Query = context.Customers
            args.AreSourceRowsThreadSafe = True
            Return True
        End Function

        Private Sub sbStartService_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbStartService.Click
            Dim serviceFile As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "VB\XpoODataService\XpoDemoService.svc")
            If String.IsNullOrEmpty(serviceFile) Then
                Return
            End If
            Dim servicePath As String = Path.GetDirectoryName(serviceFile)
            Dim url As String = WebDevServerHelper.PrepareDemoPathForProcessing(servicePath, servicePath & ".ur1", False)
            serviceUri = New Uri(url & "XpoDemoService.svc")
            sbEmployees.Enabled = True
            sbViewMetadata.Enabled = True
            sbStartService.Enabled = False
        End Sub

		Private Sub sbViewMetadata_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbViewMetadata.Click
			Process.Start(serviceUri.OriginalString & "/$metadata")
		End Sub
	End Class

End Namespace

