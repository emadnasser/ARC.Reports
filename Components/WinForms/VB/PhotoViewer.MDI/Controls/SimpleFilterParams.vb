Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraEditors

Namespace PhotoViewer
	Partial Public Class SimpleFilterParams
		Inherits XtraUserControl
		Private filterInfoCore As FilterInfo
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Overridable Function GetParams() As Object()
			Return New Object() { }
		End Function
		Public Property Filter() As FilterInfo
			Get
				Return filterInfoCore
			End Get
			Set(ByVal value As FilterInfo)
				filterInfoCore = value
			End Set
		End Property
		Private imageToFilterCore As Image
		Public Property ImageToFilter() As Image
			Get
				Return imageToFilterCore
			End Get
			Set(ByVal value As Image)
				If ImageToFilter Is value Then
					Return
				End If
				imageToFilterCore = value
				OnImageToFilterChanged()
			End Set
		End Property
		Private Sub OnImageToFilterChanged()
			Dim img As Image = TryCast(pictureEdit.Tag, Image)
			If img IsNot Nothing Then
				img.Dispose()
			End If
			pictureEdit.Tag = Nothing
			img = pictureEdit.Image
			pictureEdit.Image = Nothing
			If img IsNot Nothing Then
				img.Dispose()
			End If
			If ImageToFilter IsNot Nothing Then
				pictureEdit.Image = ThumbnailHelper.Default.CreateThumbnail(ImageToFilter, 128)
				UpdatePreview()
			End If
		End Sub
		Public Custom Event ApplyFilter As EventHandler
			AddHandler(ByVal value As EventHandler)
				AddHandler applyFilterButton.Click, value
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				RemoveHandler applyFilterButton.Click, value
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
			End RaiseEvent
		End Event
		Public Overridable Sub UpdatePreview()
            Dim oldImage As Image
            If pictureEdit.Tag Is Nothing Then oldImage = Nothing Else oldImage = pictureEdit.Image
            If pictureEdit.Tag Is Nothing Then
                pictureEdit.Tag = pictureEdit.Image
            End If
            If pictureEdit.Tag Is Nothing Then
                Return
            End If
            pictureEdit.Image = FilterHelper.ApplyFilter(Filter.Name, CType(pictureEdit.Tag, Image), GetParams())
            If oldImage IsNot Nothing Then
                oldImage.Dispose()
            End If
        End Sub
		Protected Overrides Sub OnParentChanged(ByVal e As EventArgs)
			MyBase.OnParentChanged(e)
			If Parent IsNot Nothing AndAlso Filter IsNot Nothing Then
				UpdatePreview()
			ElseIf Parent Is Nothing Then
				ImageToFilter = Nothing
			End If
		End Sub
	End Class
End Namespace
