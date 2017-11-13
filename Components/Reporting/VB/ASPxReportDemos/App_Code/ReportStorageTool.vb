Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Reflection
Imports DevExpress.XtraReports.Native
Imports DevExpress.XtraReports.UI

Public Class ReportStorageTool
	Implements IReportStorageTool
	Private ReadOnly [assembly] As System.Reflection.Assembly = GetType(XtraReportsDemos.ReportNames).Assembly

	Private Function IsValidUrl(ByVal url As String) As Boolean Implements IReportStorageTool.IsValidUrl
		Return [assembly].GetType(url, False, False) IsNot Nothing
	End Function

	Private Function GetData(ByVal url As String) As Byte() Implements IReportStorageTool.GetData
		Dim type = [assembly].GetType(url, False, False)
		If type Is Nothing Then
			Return Nothing
		End If
		Dim report = TryCast(Activator.CreateInstance(type), XtraReport)
		If report Is Nothing Then
			Return Nothing
		End If
		Using report
		Using stream = New MemoryStream()
			report.SaveLayoutToXml(stream)
			Return stream.ToArray()
		End Using
		End Using
	End Function

	Private Function CanSetData(ByVal url As String) As Boolean Implements IReportStorageTool.CanSetData
		Return False
	End Function

	Private Sub SetData(ByVal report As XtraReport, ByVal stream As Stream) Implements IReportStorageTool.SetData
		Throw New NotSupportedException()
	End Sub

	Private Sub SetData(ByVal report As XtraReport, ByVal url As String) Implements IReportStorageTool.SetData
		Throw New NotSupportedException()
	End Sub
End Class
