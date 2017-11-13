Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking

Namespace DevExpress.ApplicationUI.Demos
	''' <summary>
	''' Summary description for BaseControl.
	''' </summary>
	Partial Public Class BaseControl
		Inherits DevExpress.XtraEditors.XtraUserControl
		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitForm call

		End Sub

		Private rnd As Random = New Random()
		Private Sub dockManager1_RegisterDockPanel(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking.DockPanelEventArgs) Handles dockManager1.RegisterDockPanel
			e.Panel.ImageIndex = rnd.Next(imageList1.Images.Count)
		End Sub

		Public ReadOnly Property Manager() As DockManager
			Get
				Return dockManager1
			End Get
		End Property
	End Class
End Namespace
