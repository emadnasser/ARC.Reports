Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports DevExpress.XtraReports.Web

Partial Public Class ReportTypes_TableReport
	Inherits PageBase(Of XtraReportsDemos.TableReport.Report)
	Protected Sub documentViewer_CustomizeParameterEditors(ByVal sender As Object, ByVal e As CustomizeParameterEditorsEventArgs)
		Dim spinEdit = TryCast(e.Editor, ASPxSpinEdit)
		If spinEdit Is Nothing Then
			Return
		End If
		Select Case e.Parameter.Name
			Case "OrderIdParameter"
				SetSpinEditParametrs(spinEdit, 10248, 11077)
			Case "MaxRowCountParameter"
				SetSpinEditParametrs(spinEdit, 1, Integer.MaxValue)
		End Select
	End Sub

	Private Shared Sub SetSpinEditParametrs(ByVal spinEdit As ASPxSpinEdit, ByVal minValue As Integer, ByVal maxValue As Integer)
		spinEdit.MinValue = minValue
		spinEdit.MaxValue = maxValue
	End Sub
End Class
