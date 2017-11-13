Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class SalesPerformanceWidgets
		Inherits TutorialControlBase
		Public Sub New()
			InitializeComponent()
		End Sub

		Private r As New Random()
		Private Sub widgetView1_QueryControl(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs) Handles widgetView1.QueryControl
			If e.Document.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget" Then
				Dim smallWidget = New ucCardWidget()
				smallWidget.Price = r.Next(100, 1000)
				smallWidget.PPrice = r.NextDouble() - r.NextDouble()
				smallWidget.Delta = r.Next(-50, 100) + r.NextDouble()
				e.Control = smallWidget
				Return
			End If
			If (Not String.IsNullOrEmpty(e.Document.ControlTypeName)) Then
				Dim control = TryCast(Activator.CreateInstance(Type.GetType(e.Document.ControlTypeName)), Control)
				e.Control = control
			End If
		End Sub
	End Class
End Namespace
