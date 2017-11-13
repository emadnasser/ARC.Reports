Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Web
Imports DevExpress.Spreadsheet
Imports DevExpress.Web.Office
Imports DevExpress.XtraSpreadsheet

Namespace DevExpress.Web.Demos
	Public NotInheritable Class DocumentIdGenerator
		Public Const CellValueChangedDocumentIdPrefix As String = "CellValueChangedDemo_"

		Private Sub New()
		End Sub
		Public Shared Function GenerateDocumentId() As String
			Return CellValueChangedDocumentIdPrefix & Guid.NewGuid().ToString()
		End Function
	End Class
End Namespace
