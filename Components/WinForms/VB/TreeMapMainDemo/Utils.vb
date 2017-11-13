Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Drawing

Namespace DevExpress.XtraTreeMap.Demos
	Public NotInheritable Class Utils
		Private Sub New()
		End Sub
		Public Shared Function GetRelativePath(ByVal name As String) As String
			name = "Data\" & name
			Dim path As String = System.Windows.Forms.Application.StartupPath
			Dim s As String = "\"
			For i As Integer = 0 To 10
				If System.IO.File.Exists(path & s & name) Then
					Return (path & s & name)
				Else
					s &= "..\"
				End If
			Next i
			Return ""
		End Function
		Public Shared Function CreateDataSet(ByVal xmlFileName As String) As DataTable
			Dim filePath As String = Utils.GetRelativePath(xmlFileName)
			If (Not String.IsNullOrWhiteSpace(filePath)) Then
				Dim dataSet As New DataSet()
				dataSet.ReadXml(filePath)
				If dataSet.Tables.Count > 0 Then
					Return dataSet.Tables(0)
				End If
			End If
			Return Nothing
		End Function
		Public Shared ReadOnly SelectionPalette() As Color = { Color.FromArgb(170, 97, 150, 211), Color.FromArgb(170, 234, 127, 56), Color.FromArgb(170, 252, 195, 25), Color.FromArgb(170, 76, 107, 194), Color.FromArgb(170, 111, 174, 73), Color.FromArgb(170, 48, 91, 143), Color.FromArgb(170, 155, 76, 26), Color.FromArgb(170, 150, 117, 10), Color.FromArgb(170, 46, 66, 119), Color.FromArgb(170, 68, 105, 47), Color.FromArgb(170, 127, 171, 220), Color.FromArgb(170, 238, 153, 92), Color.FromArgb(170, 252, 208, 58), Color.FromArgb(170, 103, 129, 195) }
	End Class
End Namespace
