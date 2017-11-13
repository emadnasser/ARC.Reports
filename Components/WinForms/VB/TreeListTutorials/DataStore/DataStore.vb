Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for DataStore.
	''' </summary>
	Public Partial Class DataStore
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			treeList1.ExpandAll()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub
	End Class
End Namespace
