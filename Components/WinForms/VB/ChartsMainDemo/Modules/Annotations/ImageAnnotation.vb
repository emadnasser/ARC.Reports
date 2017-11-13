Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.Annotations
	Partial Public Class ImageAnnotationDemo
		Inherits AnnotationDemoBase
		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Overrides Sub AddAnnotation(ByVal point As SeriesPoint, ByVal isMaximum As Boolean)
			Dim annotation As ImageAnnotation = point.Annotations.AddImageAnnotation()
			If isMaximum Then
				annotation.Name = "Maximum"
				annotation.Image.Image = My.Resources.AnnotationMaximum
			Else
				annotation.Name = "Minimum"
				annotation.Image.Image = My.Resources.AnnotationMinimum
			End If
		End Sub
	End Class
End Namespace
