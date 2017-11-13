Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.Configuration

Namespace DevExpress.Web.Demos
	Public NotInheritable Class FileManagmentUtils
		Private Const AmazonAccessKeyIDSettingName As String = "FileManagerAmazonAccessKeyID"
		Private Const AmazonSecretAccessKeySettingName As String = "FileManagerAmazonSecretAccessKey"
		Private Const AzureAccessKeySettingName As String = "FileManagerAzureAccessKey"
		Private Const DropboxAccessTokenValueSettingName As String = "FileManagerDropboxAccessTokenValue"

		Private Const RootFolderVirtPath As String = "~/Content/FileManager/VirtualScrolling/Files"

		Private Shared filesCreationLocker As Object = New Object()
		Private Shared Property FilesCreated() As Boolean

		Private Sub New()
		End Sub
		Public Shared Function GetAmazonAccessKeyID() As String
			Return WebConfigurationManager.AppSettings(AmazonAccessKeyIDSettingName)
		End Function
		Public Shared Function GetAmazonSecretAccessKey() As String
			Return WebConfigurationManager.AppSettings(AmazonSecretAccessKeySettingName)
		End Function
		Public Shared Function GetAzureStorageAccountName() As String
			Return "aspxdemos"
		End Function
		Public Shared Function GetAzureAccessKey() As String
			Return WebConfigurationManager.AppSettings(AzureAccessKeySettingName)
		End Function
		Public Shared Function GetDropboxAccessTokenValue() As String
			Return WebConfigurationManager.AppSettings(DropboxAccessTokenValueSettingName)
		End Function

		Public Shared Sub EnsureDemoFilesCreated()
			If FilesCreated Then
				Return
			End If

			SyncLock FileManagmentUtils.filesCreationLocker
				If (Not FilesCreated) Then
					CreateFiles()
					FilesCreated = True
				End If
			End SyncLock
		End Sub

		Private Shared Sub CreateFiles()
			CreateFolderWithFiles("Projects", 1000, "Project {0}.txt")
			CreateFolderWithFiles("Reports", 100, "Report {0}.xls")
			CreateFolderWithFiles("Articles", 500, "Article {0}.rtf")
		End Sub
		Private Shared Sub CreateFolderWithFiles(ByVal keyFolderName As String, ByVal fileCount As Integer, ByVal fileNameTemplate As String)
			Dim rootFolderPath As String = HttpContext.Current.Server.MapPath(RootFolderVirtPath)
			Dim displayFolderName As String = String.Format("{0} ({1})", keyFolderName, fileCount)
			Dim folderPath As String = Path.Combine(rootFolderPath, displayFolderName)
			Directory.CreateDirectory(folderPath)
			For i As Integer = 1 To fileCount
				Dim fileName As String = String.Format(fileNameTemplate, i)
				Dim filePath As String = Path.Combine(folderPath, fileName)
				Using File.Create(filePath)
				End Using
			Next i
		End Sub
	End Class
End Namespace
