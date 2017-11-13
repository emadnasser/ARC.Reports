Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditExamples
	Public NotInheritable Class SpecialFeatires
		Private Sub New()
		End Sub
		Private Shared Sub CreateHyperlink(ByVal document As Document)
'			#Region "#Hyperlinks"
			document.AppendText("Main website: ")
			Dim range As DocumentRange = document.AppendText("DevExpress")
			document.Hyperlinks.Create(range)
			document.Hyperlinks(0).Target = "_blank"
			document.Hyperlinks(0).NavigateUri = "http://www.devexpress.com/"
'			#End Region ' #Hyperlinks
		End Sub
		Private Shared Sub CreateField(ByVal document As Document)
'			#Region "#Fields"
			document.Fields.Create(document.Range.Start, "DATE")
			document.Fields(0).Update()
'			#End Region ' #Fields
		End Sub
	End Class
End Namespace
