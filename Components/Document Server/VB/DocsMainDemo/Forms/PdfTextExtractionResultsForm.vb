Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.Docs.Demos
	Partial Public Class PdfTextExtractionResultsForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			Icon = ResourceImageHelper.CreateIconFromResources("MainDemo.ico", GetType(frmMain).Assembly)
			CenterToParent()
		End Sub
		Public Sub SetText(ByVal text As String)
			memoEdit.Text = text
		End Sub
	End Class
End Namespace
