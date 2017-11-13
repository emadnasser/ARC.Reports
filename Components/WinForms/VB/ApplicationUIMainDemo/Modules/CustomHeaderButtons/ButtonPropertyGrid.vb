Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class ButtonPropertyGrid
		Inherits XtraUserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Property SelectObject() As Object
			Get
				Return xtraPropertyGrid1.PropertyGrid.SelectedObject
			End Get
			Set(ByVal value As Object)
				xtraPropertyGrid1.PropertyGrid.SelectedObject = value
			End Set
		End Property
		Public Sub RefreshPropertyGrid()
			xtraPropertyGrid1.PropertyGrid.Refresh()
		End Sub
	End Class
End Namespace
