Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.Web
Imports DevExpress.Web.Demos
Imports DevExpress.Utils

Public Class UploadedFilesStorage
	Public Property Path() As String
	Public Property Key() As String
	Public Property LastUsageTime() As DateTime

	Public Property Files() As IList(Of UploadedFileInfo)
End Class

Public Class UploadedFileInfo
	Public Property UniqueFileName() As String
	Public Property OriginalFileName() As String
	Public Property FilePath() As String
	Public Property FileSize() As String
End Class

Partial Public Class UploadControl_UploadAndSubmit
	Inherits System.Web.UI.Page
	Protected Property SubmissionID() As String
		Get
			Return HiddenField.Get("SubmissionID").ToString()
		End Get
		Set(ByVal value As String)
			HiddenField.Set("SubmissionID", value)
		End Set
	End Property
	Private ReadOnly Property UploadedFilesStorage() As UploadedFilesStorage
		Get
			Return UploadControlHelper.GetUploadedFilesStorageByKey(SubmissionID)
		End Get
	End Property

	Protected Sub ProcessSubmit(ByVal description As String, ByVal fileInfos As List(Of UploadedFileInfo))
		DescriptionLabel.Value = Server.HtmlEncode(description)

		For Each fileInfo As UploadedFileInfo In fileInfos
			' process uploaded files here
			'byte[] fileContent = File.ReadAllBytes(fileInfo.FilePath);
		Next fileInfo

		SubmittedFilesListBox.DataSource = fileInfos
		SubmittedFilesListBox.DataBind()

		FormLayout.FindItemOrGroupByName("ResultGroup").Visible = True
	End Sub

	Protected Sub Page_PreLoad(ByVal sender As Object, ByVal e As EventArgs)
		UploadControlHelper.RemoveOldStorages()
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			SubmissionID = UploadControlHelper.GenerateUploadedFilesStorageKey()
			UploadControlHelper.AddUploadedFilesStorage(SubmissionID)
		End If

		FormLayout.FindItemOrGroupByName("ResultGroup").Visible = False
	End Sub

	Protected Sub DocumentsUploadControl_FileUploadComplete(ByVal sender As Object, ByVal e As DevExpress.Web.FileUploadCompleteEventArgs)
		Dim isSubmissionExpired As Boolean = False
		If UploadedFilesStorage Is Nothing Then
			isSubmissionExpired = True
			UploadControlHelper.AddUploadedFilesStorage(SubmissionID)
		End If
		Dim tempFileInfo As UploadedFileInfo = UploadControlHelper.AddUploadedFileInfo(SubmissionID, e.UploadedFile.FileName)

		e.UploadedFile.SaveAs(tempFileInfo.FilePath)

		If e.IsValid Then
			e.CallbackData = tempFileInfo.UniqueFileName & "|" & isSubmissionExpired
		End If
	End Sub

	Protected Sub SubmitButton_Click(ByVal sender As Object, ByVal e As EventArgs)
		ValidateInputData()

		Dim resultFileInfos As New List(Of UploadedFileInfo)()
		Dim description As String = DescriptionTextBox.Text
		Dim allFilesExist As Boolean = True

		If UploadedFilesStorage Is Nothing Then
			UploadedFilesTokenBox.Tokens = New TokenCollection()
		End If

		For Each fileName As String In UploadedFilesTokenBox.Tokens
			Dim demoFileInfo As UploadedFileInfo = UploadControlHelper.GetDemoFileInfo(SubmissionID, fileName)
			Dim fileInfo As New FileInfo(demoFileInfo.FilePath)

			If fileInfo.Exists Then
				demoFileInfo.FileSize = Utils.FormatSize(fileInfo.Length)
				resultFileInfos.Add(demoFileInfo)
			Else
				allFilesExist = False
			End If
		Next fileName

		If allFilesExist AndAlso resultFileInfos.Count > 0 Then
			ProcessSubmit(description, resultFileInfos)

			UploadControlHelper.RemoveUploadedFilesStorage(SubmissionID)

			ASPxEdit.ClearEditorsInContainer(FormLayout, True)
		Else
			UploadedFilesTokenBox.ErrorText = "Submit failed because files have been removed from the server due to the 5 minute timeout."
			UploadedFilesTokenBox.IsValid = False
		End If
	End Sub
	Private Sub ValidateInputData()
		Dim isInvalid As Boolean = String.IsNullOrEmpty(DescriptionTextBox.Text) OrElse UploadedFilesTokenBox.Tokens.Count = 0
		If isInvalid Then
			Throw New Exception("Invalid input data")
		End If
	End Sub
End Class

Public NotInheritable Class UploadControlHelper
	Private Const DisposeTimeout As Integer = 5
	Private Const FolderKey As String = "UploadDirectory"
	Private Const TempDirectory As String = "~/UploadControl/Temp/"
	Private Shared ReadOnly storageListLocker As Object = New Object()

	Private Sub New()
	End Sub
	Private Shared ReadOnly Property Context() As HttpContext
		Get
			Return HttpContext.Current
		End Get
	End Property
	Private Shared ReadOnly Property RootDirectory() As String
		Get
			Return Context.Request.MapPath(TempDirectory)
		End Get
	End Property

	Private Shared uploadedFilesStorageList_Renamed As IList(Of UploadedFilesStorage)
	Private Shared ReadOnly Property UploadedFilesStorageList() As IList(Of UploadedFilesStorage)
		Get
			Return uploadedFilesStorageList_Renamed
		End Get
	End Property

	Shared Sub New()
		uploadedFilesStorageList_Renamed = New List(Of UploadedFilesStorage)()
	End Sub

	Private Shared Function CreateTempDirectoryCore() As String
		Dim uploadDirectory As String = Path.Combine(RootDirectory, Path.GetRandomFileName())
		Directory.CreateDirectory(uploadDirectory)

		Return uploadDirectory
	End Function
	Public Shared Function GetUploadedFilesStorageByKey(ByVal key As String) As UploadedFilesStorage
		SyncLock storageListLocker
			Return GetUploadedFilesStorageByKeyUnsafe(key)
		End SyncLock
	End Function
	Private Shared Function GetUploadedFilesStorageByKeyUnsafe(ByVal key As String) As UploadedFilesStorage
		Dim storage As UploadedFilesStorage = UploadedFilesStorageList.Where(Function(i) i.Key = key).SingleOrDefault()
		If storage IsNot Nothing Then
			storage.LastUsageTime = DateTime.Now
		End If
		Return storage
	End Function
	Public Shared Function GenerateUploadedFilesStorageKey() As String
		Return Guid.NewGuid().ToString("N")
	End Function
	Public Shared Sub AddUploadedFilesStorage(ByVal key As String)
		SyncLock storageListLocker
			Dim storage As UploadedFilesStorage = New UploadedFilesStorage With {.Key = key, .Path = CreateTempDirectoryCore(), .LastUsageTime = DateTime.Now, .Files = New List(Of UploadedFileInfo)()}
			UploadedFilesStorageList.Add(storage)
		End SyncLock
	End Sub
	Public Shared Sub RemoveUploadedFilesStorage(ByVal key As String)
		SyncLock storageListLocker
			Dim storage As UploadedFilesStorage = GetUploadedFilesStorageByKeyUnsafe(key)
			If storage IsNot Nothing Then
				Directory.Delete(storage.Path, True)
				UploadedFilesStorageList.Remove(storage)
			End If
		End SyncLock
	End Sub
	Public Shared Sub RemoveOldStorages()
		If (Not Directory.Exists(RootDirectory)) Then
			Directory.CreateDirectory(RootDirectory)
		End If

		SyncLock storageListLocker
			Dim existingDirectories() As String = Directory.GetDirectories(RootDirectory)
			For Each directoryPath As String In existingDirectories
				Dim storage As UploadedFilesStorage = UploadedFilesStorageList.Where(Function(i) i.Path = directoryPath).SingleOrDefault()
				If storage Is Nothing OrElse (DateTime.Now - storage.LastUsageTime).TotalMinutes > DisposeTimeout Then
					Directory.Delete(directoryPath, True)
					If storage IsNot Nothing Then
						UploadedFilesStorageList.Remove(storage)
					End If
				End If
			Next directoryPath
		End SyncLock
	End Sub
	Public Shared Function AddUploadedFileInfo(ByVal key As String, ByVal originalFileName As String) As UploadedFileInfo
		Dim currentStorage As UploadedFilesStorage = GetUploadedFilesStorageByKey(key)
		Dim fileInfo As UploadedFileInfo = New UploadedFileInfo With {.FilePath = Path.Combine(currentStorage.Path, Path.GetRandomFileName()), .OriginalFileName = originalFileName, .UniqueFileName = GetUniqueFileName(currentStorage, originalFileName)}
		currentStorage.Files.Add(fileInfo)

		Return fileInfo
	End Function
	Public Shared Function GetDemoFileInfo(ByVal key As String, ByVal fileName As String) As UploadedFileInfo
		Dim currentStorage As UploadedFilesStorage = GetUploadedFilesStorageByKey(key)
		Return currentStorage.Files.Where(Function(i) i.UniqueFileName = fileName).SingleOrDefault()
	End Function
	Public Shared Function GetUniqueFileName(ByVal currentStorage As UploadedFilesStorage, ByVal fileName As String) As String
		Dim baseName As String = Path.GetFileNameWithoutExtension(fileName)
		Dim ext As String = Path.GetExtension(fileName)
		Dim index As Integer = 1

		Do While currentStorage.Files.Any(Function(i) i.UniqueFileName = fileName)
			fileName = String.Format("{0} ({1}){2}", baseName, index, ext)
			index += 1
		Loop

		Return fileName
	End Function
End Class
