Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports DevExpress.XtraLayout.Demos.Modules

Namespace DevExpress.XtraLayout.Demos
	Partial Public Class LayoutPrinting
		Inherits DragDropLayoutControl

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
			If DBFileName <> "" Then
				Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
				Dim oleDBAdapter1 As New OleDbDataAdapter("SELECT * FROM Categories", con)
				Dim oleDBAdapter2 As New OleDbDataAdapter("SELECT * FROM Products", con)
				Dim oleDBAdapter3 As New OleDbDataAdapter("SELECT * FROM [Order Details]", con)
				Dim oleDBAdapter4 As New OleDbDataAdapter("SELECT * FROM Suppliers", con)

				oleDBAdapter1.Fill(dsCategories.Categories)
				oleDBAdapter2.Fill(dsCategories.Products)
				oleDBAdapter3.Fill(dsCategories.Order_Details)
				oleDBAdapter4.Fill(dsCategories.Suppliers)
			End If
		End Sub
		Private Sub LayoutPrinting_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			If Not DesignMode Then
				InitData()
			End If
		End Sub
	End Class
End Namespace
