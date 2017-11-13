Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for StyleConditionsForm.
	''' </summary>
	Public Partial Class StyleConditionsForm
		Inherits DevExpress.XtraEditors.XtraForm
		Private collection As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatConditionCollection = Nothing
		Public Sub New(ByVal collection As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatConditionCollection)
			Me.collection = collection
			InitializeComponent()
			Dim i As Integer = 0
			Do While i < collection.Count
				listBoxControl1.Items.Add(String.Format("Condition Item {0}", i))
				i += 1
			Loop
			listBoxControl1.SelectedIndex = 0
		End Sub

		Private Sub listBoxControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listBoxControl1.SelectedIndexChanged
            propertyGrid1.PropertyGrid.SelectedObject = collection(listBoxControl1.SelectedIndex)
		End Sub
	End Class
End Namespace
