Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Snap.Extensions.UI
Imports DevExpress.XtraRichEdit.UI

Namespace SnapDemos.Modules
	Partial Public Class BaseTutorial
		Inherits SnapTutorialControlBase
		Public Sub New()
			InitializeComponent()
			CType(New SnapDemoExceptionsHandler(snapControl1), SnapDemoExceptionsHandler).Install()
		End Sub
		Protected Overrides ReadOnly Property RibbonControl() As RibbonControl
			Get
				Return ribbonControl1
			End Get
		End Property
		Protected Overrides ReadOnly Property GalleryChangeTableStyleItem() As GalleryChangeTableStyleItem
			Get
				Return galleryChangeTableStyleItem1
			End Get
		End Property
		Protected Overrides ReadOnly Property GalleryChangeTableCellStyleItem() As GalleryChangeTableCellStyleItem
			Get
				Return galleryChangeTableCellStyleItem1
			End Get
		End Property
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If Me.snapDocumentManager1 IsNot Nothing Then
				Me.snapDocumentManager1.Dispose()
				Me.snapDocumentManager1 = Nothing
			End If
			MyBase.Dispose(disposing)
		End Sub
	End Class
End Namespace
