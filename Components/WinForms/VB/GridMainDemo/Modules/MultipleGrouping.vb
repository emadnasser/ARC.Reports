Imports System.Collections
Imports System.ComponentModel

Namespace DevExpress.XtraGrid.Demos
	''' <summary>
	''' Summary description for MultipleGrouping.
	''' </summary>
	Partial Public Class MultipleGrouping
		Inherits TutorialControl

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\MultipleGrouping.vb;VB\GridMainDemo\Modules\Tasks.vb"
			TutorialInfo.WhatsThisXMLFile = "MultipleGrouping.xml"
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub


		'<gridControl1>
		'<sbGroup>
		Private gc As GroupingControllerTasksWithCategories
		'</sbGroup>

		Private Sub MultipleGrouping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			gc = New GroupingControllerTasksWithCategories(gridControl1)
			AddHandler gc.AfterGrouping, AddressOf gc_AfterGrouping
			InitButtonCaption()
		End Sub
		'</gridControl1>

		Private Sub InitButtonCaption()
			sbGroup.Text = If(gc.IsCategoryGrouping, My.Resources.UngroupCategory, My.Resources.GroupCategory)
		End Sub

		'<sbGroup>
		Private Sub sbGroup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGroup.Click
			If gc.CategoryColumn Is Nothing Then
				sbGroup.Enabled = False
				Return
			End If
			If gc.CategoryColumn.GroupIndex = -1 Then
				gc.CategoryColumn.Group()
			Else
				gc.CategoryColumn.UnGroup()
			End If
		End Sub
		'</sbGroup>


		Private Sub gc_AfterGrouping(ByVal sender As Object, ByVal e As EventArgs)
			InitButtonCaption()
		End Sub


	End Class
End Namespace
