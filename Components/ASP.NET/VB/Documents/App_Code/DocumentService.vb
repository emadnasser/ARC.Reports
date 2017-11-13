Imports System
Imports System.Collections.Generic
Imports System.Collections.Concurrent
Imports System.Linq
Imports System.IO
Imports System.Web
Imports System.Web.UI
Imports DevExpress.Web.Office
Imports DevExpress.Web.Internal
Imports DevExpress.XtraRichEdit
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSpreadsheet.Services
Imports DevExpress.XtraSpreadsheet.Services.Implementation

Public Enum DocumentCommandResult
    OK
    DocumentAlreadyExists
    NotSupportedFormat
End Enum

Public Class DocumentService
    Inherits ServiceBase

    Private Const CurrentDocumentContextKey As String = "CurrentDocument_3D809529-9F6B-4E61-B87F-F7FAA67B6870"
    Private Const CurrentDocumentReadOnlyContextKey As String = "CurrentDocumentReadOnly_87FC142F-4739-4CAF-B9CF-8849FA8E7850"
    Private Shared ReadOnly Property Context() As HttpContext
        Get
            Return HttpContext.Current
        End Get
    End Property

    Private ReadOnly Property DataService() As DataService
        Get
            Return DocumentsApp.Data
        End Get
    End Property
    Private ReadOnly Property FileSystemService() As FileSystemService
        Get
            Return DocumentsApp.FileSystem
        End Get
    End Property

    Private Property Managers() As List(Of DocumentManagerBase)
    Private Property SpreadsheetDocumentManager() As SpreadsheetDocumentManager
    Private Property RichEditDocumentManager() As RichEditDocumentManager

    Private ReadOnly Property RequestFilePath() As String
        Get
            Dim filePath As String = Context.Request.QueryString("path")
            If String.IsNullOrWhiteSpace(filePath) Then
                HttpContext.Current.Response.Redirect("~")
            End If
            Return filePath
        End Get
    End Property
    Private ReadOnly Property RequestFileType() As String
        Get
            Return Context.Request.QueryString("type")
        End Get
    End Property
    Private ReadOnly Property RequestDataSource() As String
        Get
            Dim dataSource As String = Context.Request.QueryString("src")
            If String.IsNullOrWhiteSpace(dataSource) Then
                Return "All"
            End If
            Return dataSource
        End Get
    End Property
    Private ReadOnly Property IsCreateNewDocumentRequest() As Boolean
        Get
            Return Not String.IsNullOrEmpty(RequestFileType)
        End Get
    End Property

    Private documentLocker As New Object()
    Private Property LockedDocumentRegistry() As ConcurrentDictionary(Of Long, User)

    Public Property CurrentDocument() As Item
        Get
            If Not Context.Items.Contains(CurrentDocumentContextKey) Then
                Context.Items(CurrentDocumentContextKey) = GetCurrentDocument()
            End If
            Return TryCast(Context.Items(CurrentDocumentContextKey), Item)
        End Get
        Set(ByVal value As Item)
            Context.Items(CurrentDocumentContextKey) = value
        End Set
    End Property
    Public Property CurrentDocumentReadOnly() As Boolean
        Get
            If Not Context.Items.Contains(CurrentDocumentReadOnlyContextKey) Then
                Context.Items(CurrentDocumentReadOnlyContextKey) = True
            End If
            Return CBool(Context.Items(CurrentDocumentReadOnlyContextKey))
        End Get
        Set(ByVal value As Boolean)
            Context.Items(CurrentDocumentReadOnlyContextKey) = value
        End Set
    End Property
    Public ReadOnly Property CurrentRichEditDocumentFormat() As DevExpress.XtraRichEdit.DocumentFormat
        Get
            Return GetRichEditDocumentFormat(CurrentDocument)
        End Get
    End Property
    Public ReadOnly Property CurrentSpreadsheetDocumentFormat() As DevExpress.Spreadsheet.DocumentFormat
        Get
            Return GetSpreadsheetDocumentFormat(CurrentDocument)
        End Get
    End Property

    Public Sub New(ByVal app As DocumentsApp)
        MyBase.New(app)
        RichEditDocumentManager = New RichEditDocumentManager(app)
        SpreadsheetDocumentManager = New SpreadsheetDocumentManager(app)

        Managers = New List(Of DocumentManagerBase)()
        Managers.Add(RichEditDocumentManager)
        Managers.Add(SpreadsheetDocumentManager)
        Managers.Add(New UnsupportedDocumentManager(app))

        LockedDocumentRegistry = New ConcurrentDictionary(Of Long, User)()
    End Sub

    Public Overridable Function GetDocumentIdForEditor(ByVal document As Item) As String
        Return document.Id.ToString()
    End Function
    Public Function IsRichEditDocument(ByVal documentItem As Item) As Boolean
        Return RichEditDocumentManager.CanProcess(documentItem)
    End Function
    Public Function IsSpreadsheetDocument(ByVal documentItem As Item) As Boolean
        Return SpreadsheetDocumentManager.CanProcess(documentItem)
    End Function
    Public Function IsDocumentEditingAllowed(ByVal documentItem As Item) As Boolean
        Return IsRichEditDocument(documentItem) OrElse IsSpreadsheetDocument(documentItem)
    End Function
    Public Function GetRichEditDocumentFormat(ByVal document As Item) As DevExpress.XtraRichEdit.DocumentFormat
        Return RichEditDocumentManager.GetFormat(document)
    End Function
    Public Function GetSpreadsheetDocumentFormat(ByVal document As Item) As DevExpress.Spreadsheet.DocumentFormat
        Return SpreadsheetDocumentManager.GetFormat(document)
    End Function
    Public Function GetDocumentEditorRequestUrl(ByVal itemPath As String) As String
        Return GetDocumentEditorRequestUrl(itemPath, RequestDataSource)
    End Function
    Public Function GetDocumentEditorRequestUrl(ByVal itemPath As String, ByVal dataSource As String) As String
        Return String.Format("~/Document.aspx?path={0}&src={1}", Context.Server.UrlEncode(itemPath), dataSource)
    End Function
    Public Sub ProcessDocumentRequest(ByVal page As Page)
        If IsCreateNewDocumentRequest Then
            CreateNewDocument(RequestFilePath, RequestFileType)
        End If
        If CurrentDocument Is Nothing OrElse CurrentDocument.IsFolder Then
            Throw New Exception("Invalid file item.")
        End If

        Dim documentManager As DocumentManagerBase = GetDocumentManagerForDocument(CurrentDocument)
        If IsCreateNewDocumentRequest Then
            documentManager.ProcessNewDocument(CurrentDocument, page)
        Else
            documentManager.ProcessEditDocument(CurrentDocument, page)
        End If
    End Sub
    Public Function CreatePrintableComponent(ByVal documentItem As Item) As DevExpress.XtraPrinting.IPrintable
        Dim documentManager As DocumentManagerBase = GetDocumentManagerForDocument(documentItem)
        Return documentManager.CreatePrintableComponent(documentItem)
    End Function
    Public Function GetIconName(ByVal documentItem As Item) As String
        Dim documentManager As DocumentManagerBase = GetDocumentManagerForDocument(documentItem)
        Return documentManager.IconName
    End Function
    Public Function GetDefaultNameForCurrentDocument() As String
        Dim documentManager As DocumentManagerBase = GetDocumentManagerForDocument(CurrentDocument)
        Return documentManager.DefaultDocumentName
    End Function
    Public Function TryLockDocument(ByVal item As Item, ByVal user As User) As Boolean
        SyncLock documentLocker
            Dim lockOwner As User = GetDocumentLockOwner(item)
            If lockOwner IsNot Nothing Then
                If user.Id <> lockOwner.Id Then
                    Return False
                End If
            Else
                LockedDocumentRegistry.AddOrUpdate(item.Id, user, Function(itemId, oldUser) user)
            End If
            Return True
        End SyncLock
    End Function
    Public Function GetDocumentLockOwner(ByVal item As Item) As User
        Dim lockOwner As User = Nothing
        If LockedDocumentRegistry.TryGetValue(item.Id, lockOwner) Then
            Return lockOwner
        End If
        Return Nothing
    End Function
    Public Sub RemoveAllLocksForUser(ByVal user As User)
        Dim idList As List(Of Long) = LockedDocumentRegistry.Where(Function(entry) entry.Value.Id = user.Id).Select(Function(entry) entry.Key).ToList()

        For Each itemId As Long In idList
            Dim lockOwner As User = Nothing
            LockedDocumentRegistry.TryRemove(itemId, lockOwner)
        Next itemId
    End Sub
    Public Function TrySaveAsNewDocument(ByVal documentName As String, <System.Runtime.InteropServices.Out()> ByRef newDocumentUrl As String) As DocumentCommandResult
        newDocumentUrl = Nothing
        Dim newDocument As New Item() With {.Name = documentName, .IsFolder = False}
        If Not IsDocumentEditingAllowed(newDocument) Then
            Return DocumentCommandResult.NotSupportedFormat
        End If

        Dim document As Item = GetDocumentInCurrentFolder(documentName)
        If document IsNot Nothing Then
            Return DocumentCommandResult.DocumentAlreadyExists
        End If

        newDocument.Owner = DocumentsApp.User.CurrentUser
        newDocument.ParentItem = CurrentDocument.ParentItem
        newDocument.CreationTime = Date.UtcNow
        newDocument.LastAccessTime = Date.UtcNow
        newDocument.LastWriteTime = Date.UtcNow

        Dim newDocumentData() As Byte
        Dim sourceDocIdForEditor As String = GetDocumentIdForEditor(CurrentDocument)
        Dim sourceDocInfo As IDocumentInfo = DocumentManager.FindDocument(sourceDocIdForEditor)
        If IsRichEditDocument(CurrentDocument) Then
            Dim richEditDocInfo As RichEditDocumentInfo = TryCast(sourceDocInfo, RichEditDocumentInfo)
            Dim richEditFormat As DevExpress.XtraRichEdit.DocumentFormat = GetRichEditDocumentFormat(newDocument)
            newDocumentData = richEditDocInfo.SaveCopy(richEditFormat)
        ElseIf IsSpreadsheetDocument(CurrentDocument) Then
            Dim spreadsheetDocInfo As SpreadsheetDocumentInfo = TryCast(sourceDocInfo, SpreadsheetDocumentInfo)
            Dim spreadsheetFormat As DevExpress.Spreadsheet.DocumentFormat = GetSpreadsheetDocumentFormat(newDocument)
            newDocumentData = spreadsheetDocInfo.SaveCopy(spreadsheetFormat)
        Else
            Throw New Exception("Incorrect document format.")
        End If
        newDocument.Content = DataService.CreateBinaryContent(newDocumentData)

        DataService.AddItem(newDocument)
        DataService.SaveChanges()
        Dim newDocumentPath As String = GetPathForDocumentInCurrentFolder(documentName)
        newDocumentUrl = GetDocumentEditorRequestUrl(newDocumentPath)
        Return DocumentCommandResult.OK
    End Function
    Public Overridable Sub EnableDocumentAutoSave()
        AddHandler DocumentManager.AutoSaving, AddressOf DocumentManager_AutoSaving
    End Sub
    Public Sub SaveAllDocuments()
        Dim documents As List(Of IDocumentInfo) = DocumentManager.GetAllDocuments().ToList()
        For Each documentInfo As IDocumentInfo In documents
            Try
                SaveDocument(documentInfo, True)
            Catch
            End Try
        Next documentInfo
    End Sub
    Public Function GetPathForDocumentInCurrentFolder(ByVal documentName As String) As String
        Dim currentFolderPath As String = If(IsCreateNewDocumentRequest, RequestFilePath, Path.GetDirectoryName(RequestFilePath))
        Return Path.Combine(currentFolderPath, documentName)
    End Function

    Private Function GetDocumentManagerForDocument(ByVal documentItem As Item) As DocumentManagerBase
        Return Managers.First(Function(manager) manager.CanProcess(documentItem))
    End Function
    Private Function GetCurrentDocument() As Item
        Return FileSystemService.GetFileFromSource(RequestFilePath, RequestDataSource)
    End Function
    Private Function GetDocumentInCurrentFolder(ByVal documentName As String) As Item
        Dim newDocumentPath As String = GetPathForDocumentInCurrentFolder(documentName)
        Return FileSystemService.GetFileFromSource(newDocumentPath, RequestDataSource)
    End Function

    Private Sub CreateNewDocument(ByVal folderPath As String, ByVal docType As String)
        If String.IsNullOrEmpty(folderPath) Then
            folderPath = "Files"
        End If

        Dim documentName As String
        If docType = "richtext" Then
            documentName = "Document.rtf"
        ElseIf docType = "worksheet" Then
            documentName = "Worksheet.xlsx"
        Else
            Throw New Exception("Incorrect document type.")
        End If

        Dim newDocument As Item = FileSystemService.CreateNewFileItem(folderPath, documentName)
        CurrentDocument = newDocument
    End Sub

    Private Shared Sub DocumentManager_AutoSaving(ByVal documentInfo As IDocumentInfo, ByVal e As DocumentSavingEventArgs)
        DocumentsApp.Instance.Document.OnDocumentAutoSaving(documentInfo, e)
    End Sub
    Private Sub OnDocumentAutoSaving(ByVal documentInfo As IDocumentInfo, ByVal e As DocumentSavingEventArgs)
        Try
            SaveDocument(documentInfo, False)
        Finally
            e.Handled = True
            DataService.CloseUnitOfWork()
        End Try
    End Sub
    Private Sub SaveDocument(ByVal documentInfo As IDocumentInfo, ByVal checkModificationTime As Boolean)
        Dim itemId As Long = ParseDocumentIdFromEditor(documentInfo.DocumentId)
        Dim docItem As Item = DataService.FindItemById(itemId)
        If docItem Is Nothing OrElse checkModificationTime AndAlso documentInfo.LastModifyTime < docItem.LastWriteTime Then
            Return
        End If

        Dim content() As Byte = Nothing
        If IsRichEditDocument(docItem) Then
            Dim richEditDocument As RichEditDocumentInfo = DirectCast(documentInfo, RichEditDocumentInfo)
            content = richEditDocument.SaveCopy(RichEditDocumentManager.GetFormat(docItem))
        ElseIf IsSpreadsheetDocument(docItem) Then
            Dim spreadsheetDocument As SpreadsheetDocumentInfo = DirectCast(documentInfo, SpreadsheetDocumentInfo)
            content = spreadsheetDocument.SaveCopy(SpreadsheetDocumentManager.GetFormat(docItem))
        Else
            Throw New Exception("Incorrect document format.")
        End If

        docItem.UpdateContent(content)
        DataService.SaveChanges()
    End Sub
    Protected Overridable Function ParseDocumentIdFromEditor(ByVal editorDocId As String) As Long
        Return Long.Parse(editorDocId)
    End Function
End Class

Public MustInherit Class DocumentManagerBase
    Private privateDocumentsApp As DocumentsApp
    Protected Property DocumentsApp() As DocumentsApp
        Get
            Return privateDocumentsApp
        End Get
        Private Set(ByVal value As DocumentsApp)
            privateDocumentsApp = value
        End Set
    End Property

    Public Sub New(ByVal app As DocumentsApp)
        DocumentsApp = app
    End Sub

    Private privateIconName As String
    Public Property IconName() As String
        Get
            Return privateIconName
        End Get
        Protected Set(ByVal value As String)
            privateIconName = value
        End Set
    End Property
    Private privateDefaultDocumentName As String
    Public Property DefaultDocumentName() As String
        Get
            Return privateDefaultDocumentName
        End Get
        Protected Set(ByVal value As String)
            privateDefaultDocumentName = value
        End Set
    End Property

    Public Overridable Function CanProcess(ByVal fileItem As Item) As Boolean
        Throw New NotImplementedException()
    End Function
    Public Overridable Sub ProcessNewDocument(ByVal fileItem As Item, ByVal page As Page)
        Throw New NotImplementedException()
    End Sub
    Public Overridable Sub ProcessEditDocument(ByVal fileItem As Item, ByVal page As Page)
        Throw New NotImplementedException()
    End Sub
    Public Overridable Function CreatePrintableComponent(ByVal fileItem As Item) As DevExpress.XtraPrinting.IPrintable
        Return Nothing
    End Function
End Class

Public MustInherit Class StandardDocumentManagerBase(Of TFormat)
    Inherits DocumentManagerBase

    Private privateFormatRegistry As Dictionary(Of String, TFormat)
    Protected Property FormatRegistry() As Dictionary(Of String, TFormat)
        Get
            Return privateFormatRegistry
        End Get
        Private Set(ByVal value As Dictionary(Of String, TFormat))
            privateFormatRegistry = value
        End Set
    End Property
    Protected Property EditorUrl() As String

    Protected Sub New(ByVal app As DocumentsApp)
        MyBase.New(app)
        FormatRegistry = New Dictionary(Of String, TFormat)()
    End Sub

    Public Overrides Function CanProcess(ByVal fileItem As Item) As Boolean
        Dim extension As String = Path.GetExtension(fileItem.Name)
        Return FormatRegistry.ContainsKey(extension)
    End Function
    Public Overrides Sub ProcessNewDocument(ByVal fileItem As Item, ByVal page As Page)
        Dim newDocumentPath As String = DocumentsApp.Document.GetPathForDocumentInCurrentFolder(fileItem.Name)
        Dim newDocumentUrl As String = DocumentsApp.Document.GetDocumentEditorRequestUrl(newDocumentPath)
        HttpContext.Current.Response.Redirect(newDocumentUrl)
    End Sub
    Public Overrides Sub ProcessEditDocument(ByVal fileItem As Item, ByVal page As Page)
        DocumentsApp.Document.CurrentDocumentReadOnly = Not DocumentsApp.TryLockDocument(fileItem)
        HttpContext.Current.Server.Transfer(EditorUrl)
    End Sub
    Public Function GetFormat(ByVal fileItem As Item) As TFormat
        Dim extension As String = Path.GetExtension(fileItem.Name)
        Dim format As TFormat = Nothing
        If FormatRegistry.TryGetValue(extension, format) Then
            Return format
        End If
        Throw New Exception("Extension is not supported.")
    End Function
End Class

Public Class RichEditDocumentManager
    Inherits StandardDocumentManagerBase(Of DevExpress.XtraRichEdit.DocumentFormat)

    Public Sub New(ByVal app As DocumentsApp)
        MyBase.New(app)
        FormatRegistry.Add(".rtf", DevExpress.XtraRichEdit.DocumentFormat.Rtf)
        FormatRegistry.Add(".doc", DevExpress.XtraRichEdit.DocumentFormat.Doc)
        FormatRegistry.Add(".docx", DevExpress.XtraRichEdit.DocumentFormat.OpenXml)
        FormatRegistry.Add(".txt", DevExpress.XtraRichEdit.DocumentFormat.PlainText)

        EditorUrl = "RichTextEdit.aspx"
        IconName = "RTF.png"
        DefaultDocumentName = "Document1.rtf"
    End Sub
    Public Overrides Function CreatePrintableComponent(ByVal fileItem As Item) As DevExpress.XtraPrinting.IPrintable
        Dim docServer As New RichEditDocumentServer()
        Dim contentStream As Stream = DocumentsApp.Data.ReadFileContent(fileItem)
        docServer.LoadDocument(contentStream, GetFormat(fileItem))
        Return docServer
    End Function
End Class

Public Class SpreadsheetDocumentManager
    Inherits StandardDocumentManagerBase(Of DevExpress.Spreadsheet.DocumentFormat)

    Public Sub New(ByVal app As DocumentsApp)
        MyBase.New(app)
        FormatRegistry.Add(".xlsx", DevExpress.Spreadsheet.DocumentFormat.Xlsx)

        EditorUrl = "SpreadsheetEdit.aspx"
        IconName = "Spreadsheet.png"
        DefaultDocumentName = "Worksheet1.xlsx"
    End Sub
    Public Overrides Function CreatePrintableComponent(ByVal fileItem As Item) As DevExpress.XtraPrinting.IPrintable
        Dim workbook As IWorkbook = New Workbook()
        workbook.AddService(GetType(IChartControllerFactoryService), New ChartControllerFactoryService())
        workbook.AddService(GetType(IChartImageService), New ChartImageService())
        Dim contentStream As Stream = DocumentsApp.Data.ReadFileContent(fileItem)
        workbook.LoadDocument(contentStream, GetFormat(fileItem))
        Return workbook
    End Function
End Class

Public Class UnsupportedDocumentManager
    Inherits DocumentManagerBase

    Public Sub New(ByVal app As DocumentsApp)
        MyBase.New(app)
    End Sub
    Public Overrides Function CanProcess(ByVal fileItem As Item) As Boolean
        Return True
    End Function
    Public Overrides Sub ProcessEditDocument(ByVal fileItem As Item, ByVal page As Page)
        Dim contentStream As Stream = DocumentsApp.Data.ReadFileContent(fileItem)
        Dim fileName As String = Path.GetFileNameWithoutExtension(fileItem.Name)
        Dim fileExt As String = Path.GetExtension(fileItem.Name)
        WriteStreamToResponse(page, contentStream, fileName, fileExt)
    End Sub
    Private Sub WriteStreamToResponse(ByVal page As Page, ByVal stream As Stream, ByVal fileName As String, ByVal fileExt As String)
        HttpUtils.WriteFileToResponse(page, stream, fileName, True, fileExt, HttpUtils.GetContentType(fileExt), True)
    End Sub
End Class
