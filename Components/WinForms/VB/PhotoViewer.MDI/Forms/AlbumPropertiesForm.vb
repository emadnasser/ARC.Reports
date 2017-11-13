Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports PhotoViewer.Data

Namespace PhotoViewer
	Partial Public Class AlbumPropertiesForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub
		Private controller As PhotoViewerDataController
		Public Sub New(ByVal controller As PhotoViewerDataController)
			Me.New()
			Me.controller = controller
		End Sub
		Private isEditExistingAlbumMode_Renamed As Boolean
		Public Property IsEditExistingAlbumMode() As Boolean
			Get
				Return isEditExistingAlbumMode_Renamed
			End Get
			Set(ByVal value As Boolean)
				isEditExistingAlbumMode_Renamed = value
			End Set
		End Property
		Private Sub NewAlbumForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			albumDate_Renamed.DateTime = DateTime.Now
		End Sub
		Private Sub okBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles okBtn.Click
			If CheckAlbumProperties() Then
				DialogResult = System.Windows.Forms.DialogResult.OK
				Close()
			End If
		End Sub
		Protected Overridable Function CheckAlbumProperties() As Boolean
			Dim albumName As String = albumNameEdit.Text.Trim()
            Dim messageCaption As String
            If IsEditExistingAlbumMode Then messageCaption = "Edit Album" Else messageCaption = "New Album"
            If String.IsNullOrEmpty(albumName) Then
                XtraMessageBox.Show(Me, "Error: please type album name.", messageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            For Each album As AlbumData In controller.GetAlbums()
                If album.Name = albumName AndAlso (Not IsEditExistingAlbumMode) Then
                    XtraMessageBox.Show(Me, "Error: album with the name '" & albumNameEdit.Text & "' already exists in albums collection. Please type another name.", messageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Next album
            Return True
        End Function
		Public Property AlbumName() As String
			Get
				Return albumNameEdit.Text
			End Get
			Set(ByVal value As String)
				albumNameEdit.Text = value
			End Set
		End Property
		Public Property AlbumDate() As DateTime
			Get
				Return albumDate_Renamed.DateTime
			End Get
			Set(ByVal value As DateTime)
				albumDate_Renamed.DateTime = value
			End Set
		End Property
		Public Property AlbumDescription() As String
			Get
				Return albumDescription_Renamed.Text
			End Get
			Set(ByVal value As String)
				albumDescription_Renamed.Text = value
			End Set
		End Property

		Public Shared Sub EditAlbum(ByVal controller As PhotoViewerDataController, ByVal album As AlbumData, ByVal owner As Form)
			If album Is Nothing OrElse controller Is Nothing Then
				Return
			End If
			Dim form As AlbumPropertiesForm = New AlbumPropertiesForm(controller)
			form.Text = "Edit album properties"
			form.Owner = owner
			form.AlbumName = album.Name
			form.AlbumDate = album.Date
			form.AlbumDescription = album.Description
			form.IsEditExistingAlbumMode = True
			If form.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				album.Name = form.AlbumName
				album.Date = form.AlbumDate
				album.Description = form.AlbumDescription
				controller.RaiseDataChanged(album)
			End If
		End Sub
	End Class
End Namespace
