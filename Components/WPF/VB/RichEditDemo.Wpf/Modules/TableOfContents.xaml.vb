Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Utils
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.Office.Services

Imports System.Data
Imports DevExpress.DemoData.Models
Imports DevExpress.DemoData

Namespace RichEditDemo
    Partial Public Class TableOfContents
        Inherits RichEditDemoModule

        Private Property NWind() As NWindDataLoader
        Private ds As Object
        Private isFirstLoad As Boolean

        Public Sub New()
            InitializeComponent()
            ribbon.SelectedPage = pageReferences
            isFirstLoad = True

            OpenXmlLoadHelper.Load("TableOfContents.docx", sourceRichEditControl)
            NWind = TryCast(Resources("NWindDataLoader"), NWindDataLoader)
            Me.ds = NWindContext.Create().Employees.ToList()

            Dim uriService As IUriStreamService = DirectCast(sourceRichEditControl.GetService(GetType(IUriStreamService)), IUriStreamService)
            uriService.RegisterProvider(New DBUriStreamProviderBase(Of DevExpress.DemoData.Models.Employee)(NWindContext.Create().Employees.ToList(), Function(es, id) es.First(Function(e) e.EmployeeID = id).Photo))
        End Sub

        Private Sub sourceRichEditControl_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            SetFocus(sourceRichEditControl)
            If isFirstLoad Then
                sourceRichEditControl.ApplyTemplate()
                sourceRichEditControl.Options.MailMerge.DataSource = ds
                sourceRichEditControl.Options.MailMerge.ViewMergedData = True

                MergeToNewDocument()
                isFirstLoad = False
                targetRichEditControl.Document.CaretPosition = targetRichEditControl.Document.CreatePosition(0)
            End If
        End Sub
        Private Sub mergeToNewDocument_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            MergeToNewDocument()
        End Sub
        Private Sub MergeToNewDocument()
            targetRichEditControl.ApplyTemplate()

            Dim options As MailMergeOptions = sourceRichEditControl.CreateMailMergeOptions()
            options.MergeMode = MergeMode.NewSection
            options.LastRecordIndex = 5
            sourceRichEditControl.MailMerge(options, targetRichEditControl.Document)
            Dim targetDocument As Document = targetRichEditControl.Document

            InsertContentHeading(targetDocument)

            Dim field As Field = targetDocument.Fields.Create(targetDocument.Paragraphs(1).Range.Start, "TOC \h")
            targetDocument.InsertSection(field.Range.End)
            field.Update()

            Dim paragraphStyle As ParagraphStyle = targetDocument.ParagraphStyles("TOC 1")
            If paragraphStyle IsNot Nothing Then
                paragraphStyle.Bold = True
            End If

            resultingDocumentTabItem.IsEnabled = True
            tabControl.SelectedItem = resultingDocumentTabItem
        End Sub
        Private Sub InsertContentHeading(ByVal targetDocument As Document)
            Dim hRange As DocumentRange = targetDocument.InsertText(targetDocument.Range.Start, "Contents" & ControlChars.CrLf)
            Dim charProperties As CharacterProperties = targetDocument.BeginUpdateCharacters(hRange)
            charProperties.FontSize = 16
            charProperties.ForeColor = DXColor.Blue
            targetDocument.EndUpdateCharacters(charProperties)
            targetDocument.Paragraphs(0).Style = targetDocument.ParagraphStyles(0)
            targetDocument.Paragraphs(0).Alignment = ParagraphAlignment.Center
        End Sub
        Private Sub tabControl_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Core.TabControlSelectionChangedEventArgs)
            If tabControl Is Nothing OrElse richEditControlProvider Is Nothing Then
                Return
            End If

            Dim isSelectedSourceControl As Boolean = Object.ReferenceEquals(tabControl.SelectedItem, templateTabItem)
            pageMailings.IsVisible = isSelectedSourceControl
            pageReferences.IsVisible = Not isSelectedSourceControl
            If isSelectedSourceControl Then
                ribbon.SelectedPage = pageMailings
                targetRichEditControl.BarManager = Nothing
                sourceRichEditControl.BarManager = barManager1
                targetRichEditControl.Ribbon = Nothing
                sourceRichEditControl.Ribbon = ribbon
                richEditControlProvider.RichEditControl = sourceRichEditControl
            Else
                ribbon.SelectedPage = pageReferences
                sourceRichEditControl.BarManager = Nothing
                targetRichEditControl.BarManager = barManager1
                sourceRichEditControl.Ribbon = Nothing
                targetRichEditControl.Ribbon = ribbon
                richEditControlProvider.RichEditControl = targetRichEditControl

            End If
        End Sub
        Public Shared Function GetEmployeeData() As Object
            Dim path As String = DemoUtils.GetRelativePath("TOC_Employees.xml")
            Dim EmployeeDataDS As New System.Data.DataSet()
            EmployeeDataDS.ReadXml(path)
            Return EmployeeDataDS.Tables(1)
        End Function
    End Class
End Namespace
