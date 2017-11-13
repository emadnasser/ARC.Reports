Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraEditors

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class DocumentManagerNative
		Inherits TutorialControlBase
		Public Sub New()
			AutoMergeRibbon = True
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			AddDocument()
			AddDocument()
			AddDocument()
			AddDocument()
			AddDocument()
			nativeView.Controller.Cascade()
		End Sub
		Private Sub biAddDocumentClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biAddDocument.ItemClick
			AddDocument()
		End Sub
		Private i As Integer = 0
		Private Sub AddDocument()
			Dim child As XtraUserControl = New XtraUserControl()
			Dim settings As BaseDocumentSettings = New BaseDocumentSettings()
			settings.Caption = "Document" & (i).ToString()
			i += 1
			settings.Image = imageList1.Images(i Mod (imageList1.Images.Count - 1))
			BaseDocumentSettings.Attach(child, settings)
			child.Padding = New Padding(16)
			Dim label As LabelControl = New LabelControl()
			label.Text = DemosInfo.GetLoremIpsumText(i)
			label.AutoSizeMode = LabelAutoSizeMode.Vertical
			label.Parent = child
			label.Dock = DockStyle.Fill
			nativeView.AddDocument(child)
		End Sub
	End Class
End Namespace
