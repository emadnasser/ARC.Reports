Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraTreeList.Nodes

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for NodeChecking.
	''' </summary>
	Partial Public Class NodeChecking
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			InitData()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub
		Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
			Get
				Return True
			End Get
		End Property
		Private Sub InitData()
            Dim xv As DevExpress.XtraTreeList.Design.XViews = New DevExpress.XtraTreeList.Design.XViews(treeList1)
            treeList1.SetNodeCheckState(treeList1.Nodes(0).Nodes(0), CheckState.Checked, True)
        End Sub
        '<chkAllowRecursive>
        Private Sub chkAllowRecursive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllowRecursive.CheckedChanged
            treeList1.OptionsBehavior.AllowRecursiveNodeChecking = chkAllowRecursive.Checked
        End Sub
        '</chkAllowRecursive>
        '<chkAllowIndeterminate>
        Private Sub chkAllowIndeterminate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllowIndeterminate.CheckedChanged
            treeList1.OptionsBehavior.AllowIndeterminateCheckState = chkAllowIndeterminate.Checked
        End Sub
        '</chkAllowIndeterminate>
    End Class
End Namespace
