Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraSpreadsheet.Demos
	Public Class SpreadSheetTutorialControlBase
		Inherits DevExpress.DXperience.Demos.TutorialControlBase
		Private defaultCulture_Renamed As New CultureInfo("en-US")

		Public Overrides Property AutoMergeRibbon() As Boolean
			Get
				Return True
			End Get
			Set(ByVal value As Boolean)
			End Set
		End Property
		Public ReadOnly Property DefaultCulture() As CultureInfo
			Get
				Return defaultCulture_Renamed
			End Get
		End Property
	End Class

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
		Public Shared Function LoadImageByName(ByVal name As String) As Bitmap
			Dim stream As Stream = GetType(frmMain).Assembly.GetManifestResourceStream("Modules." & name)
			If stream Is Nothing Then
				stream = GetType(frmMain).Assembly.GetManifestResourceStream(name)
			End If
			If stream IsNot Nothing Then
				Return CType(DevExpress.Data.Utils.ImageTool.ImageFromStream(stream), Bitmap)
			End If
			Return Nothing
		End Function
		'public static void SetConnectionString(System.Data.OleDb.OleDbConnection oleDbConnection, string path) {
		'    oleDbConnection.ConnectionString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source={0};Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False", path);
		'}
		Public Shared Sub SetDatabasePath()
			Const dbName As String = "nwind.mdb"
			Const pathToDbTag As String = "|pathToDb|"
			Dim path As String = GetRelativePath(dbName)
			If String.IsNullOrEmpty(path) Then
				Return
			End If
			Dim connectionString As String = TryCast(My.Settings.Default("nwindConnectionString"), String)
			If String.IsNullOrEmpty(connectionString) Then
				Return
			End If
			connectionString = connectionString.Replace(pathToDbTag, path)
			My.Settings.Default("nwindConnectionString") = connectionString
		End Sub

		Public Shared Function GetLanguageString() As String
			Dim result As String = DemoHelper.GetLanguageString(GetType(frmMain).Assembly)
			If result = "CS" Then
				result = "C#"
			End If
			Return result
		End Function
	End Class
	Public Class DemoMenuManager
		Public Shared Sub SetMenuManager(ByVal controls As Control.ControlCollection, ByVal menuManager As IDXMenuManager)
			Dim count As Integer = controls.Count
			For i As Integer = 0 To count - 1
				Dim control As Control = controls(i)
				Dim baseEdit As BaseEdit = TryCast(control, BaseEdit)
				If baseEdit IsNot Nothing Then
					baseEdit.MenuManager = menuManager
				End If

				SetMenuManager(control.Controls, menuManager)
			Next i
		End Sub
	End Class
End Namespace
