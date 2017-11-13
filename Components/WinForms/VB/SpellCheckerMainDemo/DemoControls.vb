Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraSpellChecker.Demos
	Public Class SpellCheckerRibbonMenuManager
		Inherits RibbonMenuManager
		Public Sub New(ByVal form As RibbonMainForm)
			MyBase.New(form)
		End Sub
	End Class

	Public Class TutorialControl
		Inherits TutorialControlBase
		Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
			Dim richEdit As DevExpress.XtraRichEdit.RichEditControl = TryCast(ctrl, DevExpress.XtraRichEdit.RichEditControl)
			If richEdit IsNot Nothing Then
				richEdit.MenuManager = manager
			End If
			Dim be As BaseEdit = TryCast(ctrl, BaseEdit)
			If be IsNot Nothing Then
				be.MenuManager = manager
			End If
		End Sub
	End Class

	Public Class DemoUtils
		Public Shared Sub SetConnectionString(ByVal oleDbConnection As System.Data.OleDb.OleDbConnection, ByVal path As String)
			oleDbConnection.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source={0};Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False", path)
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
			path = Environment.CurrentDirectory
			s = "\"
			For i As Integer = 0 To 10
				If System.IO.File.Exists(path & s & name) Then
					Return (path & s & name)
				Else
					s &= "..\"
				End If
			Next i
			Return ""
		End Function
	End Class
End Namespace
