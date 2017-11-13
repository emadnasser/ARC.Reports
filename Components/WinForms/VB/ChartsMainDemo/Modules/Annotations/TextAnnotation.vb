Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports System
Imports System.Drawing

Namespace DevExpress.XtraCharts.Demos.Annotations
	Partial Public Class TextAnnotationDemo
		Inherits AnnotationDemoBase
		Private minAnnotation As TextAnnotation
		Private maxAnnotation As TextAnnotation

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub SetAnnotationLines(ByVal annotation As TextAnnotation, ByVal textEdit As MemoExEdit)
			If annotation IsNot Nothing Then
				Dim oldLines() As String = annotation.Lines
				Try
					annotation.Lines = textEdit.Lines
				Catch
					textEdit.Lines = oldLines
					XtraMessageBox.Show(LookAndFeel.ActiveLookAndFeel, "Font size should be greater than 0.", "Argument Exception")
				End Try
			End If
		End Sub
		Private Sub meeMaxText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles meeMaxText.TextChanged
				SetAnnotationLines(maxAnnotation, meeMaxText)
		End Sub
		Private Sub meeMinText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles meeMinText.TextChanged
				SetAnnotationLines(minAnnotation, meeMinText)
		End Sub
		Protected Overrides Sub AddAnnotation(ByVal point As SeriesPoint, ByVal isMaximum As Boolean)
			Dim annotation As TextAnnotation = point.Annotations.AddTextAnnotation()
			If isMaximum Then
				annotation.Name = "Maximum"
				If meeMaxText IsNot Nothing Then
					annotation.Lines = maxAnnotation.Lines
				Else
					annotation.Text = "This is a <b><size=+3>maximum</size></b> point."
				End If
				maxAnnotation = annotation
			Else
				annotation.Name = "Minimum"
				If meeMinText IsNot Nothing Then
					annotation.Lines = minAnnotation.Lines
				Else
					annotation.Text = "This is a <b><size=+3>minimum</size></b> point."
				End If
				minAnnotation = annotation
			End If
		End Sub
	End Class
End Namespace
