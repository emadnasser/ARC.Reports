Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.IO
Imports System.Windows.Forms
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports DevExpress.DXperience.Demos

Namespace DevExpress.Docs.Demos
	''' <summary>
	''' Summary description for DemoUtils.
	''' </summary>
	Public Class DemoUtils
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
		Public Shared Function GetRelativeDirectoryPath(ByVal name As String) As String
			name = "Data\" & name
			Dim path As String = System.Windows.Forms.Application.StartupPath
			Dim s As String = "\"
			For i As Integer = 0 To 10
				If System.IO.Directory.Exists(path & s & name) Then
					Return (path & s & name)
				Else
					s &= "..\"
				End If
			Next i
			Return ""
		End Function
		Public Shared Sub SetConnectionString(ByVal oleDbConnection As System.Data.OleDb.OleDbConnection, ByVal path As String)
			oleDbConnection.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source={0};Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False", path)
		End Sub
		Public Shared Sub PreviewDocument(ByVal fileName As String)
			Dim extensionRegistryPathBase As String = "HKEY_CLASSES_ROOT\"
			Dim info As New FileInfo(fileName)
			Dim extensionRegistryPath = String.Format("{0}{1}", extensionRegistryPathBase, info.Extension)
			Dim value As String = TryCast(Registry.GetValue(extensionRegistryPath, String.Empty, String.Empty), String)
			Dim execSwitch As String = If((String.IsNullOrEmpty(value)), "/select", "/p")
			System.Diagnostics.Process.Start("explorer.exe", String.Format("{0}, {1}", execSwitch, fileName))
		End Sub

		Public Shared Function GetLanguageString() As String
			Dim result As String = DemoHelper.GetLanguageString(GetType(frmMain).Assembly)
			If result = "CS" Then
				result = "C#"
			End If
			Return result
		End Function
	End Class
End Namespace
