Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraRichEdit.UI
Imports DevExpress.Snap.Extensions.UI

Namespace SnapDemos.Modules
	Public Class SnapTutorialControlBase
		Inherits TutorialControlBase

		Public Sub New()
			Dim dbPath As String = FilesHelper.FindingFileName(AppDomain.CurrentDomain.BaseDirectory, "Data\temperatureStatistics.mdb", False)
			If (Not String.IsNullOrEmpty(dbPath)) Then
				Dim directory As String = System.IO.Path.GetDirectoryName(dbPath)
				AppDomain.CurrentDomain.SetData("DataDirectory", directory)
			End If
		End Sub

		Protected Overridable ReadOnly Property RibbonControl() As RibbonControl
			Get
				Return Nothing
			End Get
		End Property
		Protected Overridable ReadOnly Property GalleryChangeTableStyleItem() As GalleryChangeTableStyleItem
			Get
				Return Nothing
			End Get
		End Property
		Protected Overridable ReadOnly Property GalleryChangeTableCellStyleItem() As GalleryChangeTableCellStyleItem
			Get
				Return Nothing
			End Get
		End Property

		Public Function FindFilePathByName(ByVal fileName As String) As String
			Return FilesHelper.FindingFileName(AppDomain.CurrentDomain.BaseDirectory, String.Format("Data\{0}.snx", fileName), False)
		End Function
		Public Overrides Property AutoMergeRibbon() As Boolean
			Get
				Return True
			End Get
			Set(ByVal value As Boolean)
			End Set
		End Property
	End Class
End Namespace
