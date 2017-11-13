Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Data
Imports System.Collections.Generic
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Office.Services

Namespace DevExpress.XtraRichEdit.Demos
#Region "TableOfContentsModule"
    Partial Public Class TableOfContentsModule
        Inherits MergeModuleBase
        Private employees As System.Data.DataTable

        Public Sub New()
            InitializeComponent()
            Me.employees = GetEmployeeDataFromXml()
            Me.dataNavigator.DataSource = employees
            Me.sourceRichEditControl_Renamed.Options.MailMerge.DataSource = employees
            OpenXmlLoadHelper.Load("TableOfContents.docx", sourceRichEditControl_Renamed)
            CType(New RichEditDemoExceptionsHandler(sourceRichEditControl_Renamed), RichEditDemoExceptionsHandler).Install()
            Dim uriService As IUriStreamService = DirectCast(sourceRichEditControl_Renamed.GetService(GetType(IUriStreamService)), IUriStreamService)
            uriService.RegisterProvider(New PhotoUriStreamProvider(employees, "Photo"))
        End Sub

        Public Overrides ReadOnly Property PrintingRichEditControl() As RichEditControl
            Get
                Return targetRichEditControl
            End Get
        End Property

        Private Sub sourceRichEditControl_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs) Handles sourceRichEditControl_Renamed.DocumentLoaded
            Me.sourceRichEditControl_Renamed.Document.Fields.Update()
            MergeToNewDocument()
        End Sub

        Private Sub mergeToNewDocument_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mergeToNewDocumentItem1.ItemClick
            MergeToNewDocument()
        End Sub

        Protected Overrides Sub MergeToNewDocument()
            Dim options As MailMergeOptions = sourceRichEditControl_Renamed.CreateMailMergeOptions()
            options.MergeMode = MergeMode.NewSection
            options.LastRecordIndex = 5
            sourceRichEditControl_Renamed.MailMerge(options, targetRichEditControl.Document)
            Dim targetDocument As Document = targetRichEditControl.Document

            InsertContentHeading(targetDocument)

            Dim field As Field = targetDocument.Fields.Create(targetDocument.Paragraphs(1).Range.Start, "TOC \h")
            targetDocument.InsertSection(field.Range.End)
            field.Update()

            Dim paragraphStyle As ParagraphStyle = targetDocument.ParagraphStyles("TOC 1")
            If paragraphStyle IsNot Nothing Then
                paragraphStyle.Bold = True
            End If

            resultingDocumentTabPage.PageEnabled = True
            tabControl.SelectedTabPage = resultingDocumentTabPage
        End Sub
        Private Sub tabControl_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tabControl.SelectedPageChanged
            Dim richEditControl As RichEditControl = CType(tabControl.SelectedTabPage.Tag, RichEditControl)
            richEditBarController1.RichEditControl = richEditControl
            Dim isSelectedSourceControl As Boolean = Object.ReferenceEquals(richEditControl, sourceRichEditControl_Renamed)
            insertMergeFieldItem1.Enabled = isSelectedSourceControl
            toggleViewMergedDataItem1.Enabled = isSelectedSourceControl
            mergeToNewDocumentPageGroup1.Visible = isSelectedSourceControl
            tableOfContentsRibbonPageGroup1.Visible = Not isSelectedSourceControl
        End Sub
        Private Sub InsertContentHeading(ByVal targetDocument As Document)
            Dim hRange As DocumentRange = targetDocument.InsertText(targetDocument.Range.Start, "Contents" & Constants.vbCrLf)
            Dim charProperties As CharacterProperties = targetDocument.BeginUpdateCharacters(hRange)
            charProperties.FontSize = 16
            charProperties.ForeColor = System.Drawing.Color.SteelBlue
            targetDocument.EndUpdateCharacters(charProperties)
            targetDocument.Paragraphs(0).Style = targetDocument.ParagraphStyles(0)
            targetDocument.Paragraphs(0).Alignment = ParagraphAlignment.Center
        End Sub
    End Class
#End Region
    Public Class PhotoUriStreamProvider
        Implements IUriStreamProvider
        Shared ReadOnly prefix As String = "dbimg://"

        Private m_ds As Object
        Private columnName As String

        Public Sub New(ds As Object, columnName As String)
            Me.m_ds = ds
            Me.columnName = columnName
        End Sub

        Public ReadOnly Property Ds() As Object
            Get
                Return m_ds
            End Get
        End Property

#Region "IUriStreamProvider Members"
        Private Function IUriStreamProvider_GetStream(uri As String) As Stream Implements IUriStreamProvider.GetStream
            uri = uri.Trim()
            If Not uri.StartsWith(prefix) Then
                Return Nothing
            End If
            Dim strId As String = uri.Substring(prefix.Length).Trim()
            Dim id As Integer
            If Not Integer.TryParse(strId, id) Then
                Return Nothing
            End If
            Dim bytes As Byte() = GetImageBytes(id)
            If bytes Is Nothing Then
                Return Nothing
            End If
            Return New MemoryStream(bytes)
        End Function
#End Region
        Private Function GetImageBytes(id As Integer) As Byte()
            Dim table As DataTable = DirectCast(Me.m_ds, DataTable)
            Dim row As DataRow = table.Rows.Find(id)
            If row Is Nothing Then
                Return Nothing
            End If
            Return TryCast(row(columnName), Byte())
        End Function
    End Class
End Namespace
