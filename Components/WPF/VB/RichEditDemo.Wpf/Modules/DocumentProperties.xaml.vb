Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Xpf.Editors
Imports DevExpress.XtraRichEdit
Imports System.Globalization

Namespace RichEditDemo
    Partial Public Class DocumentProperties
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            OpenXmlLoadHelper.Load("DocumentProperties.docx", richEdit)
            Document.Fields.Update()
        End Sub

        #Region "Properties"
        Private ReadOnly Property Document() As Document
            Get
                Return richEdit.Document
            End Get
        End Property
        #End Region

        Private Sub OnDocumentPropertiesChanged(ByVal sender As Object, ByVal e As EventArgs)
            Document.Fields.Update()
        End Sub
        Private Sub OnCustomPropertiesChanged(ByVal sender As Object, ByVal e As EventArgs)
            Document.Fields.Update()
        End Sub
        Private Sub OnCalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs)
            If e.Arguments.Count = 0 OrElse e.VariableName <> "CustomProperty" Then
                Return
            End If

            Dim name As String = e.Arguments(0).Value
            Dim customProperty As Object = Document.CustomProperties(name)
            If customProperty IsNot Nothing Then
                e.Value = customProperty.ToString()
            End If
            e.Handled = True
        End Sub
        Private Sub InsertField(ByVal code As String)
            Document.BeginUpdate()
            Dim field As Field = Document.Fields.Create(richEdit.Document.CaretPosition, code)
            field.Update()
            Document.EndUpdate()
        End Sub

        #Region "ItemClick"
        Private Sub OnCategoryItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            InsertField("DOCPROPERTY Category")
        End Sub
        Private Sub OnCreatedItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            InsertField("CREATEDATE")
        End Sub
        Private Sub OnCreatorItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            InsertField("AUTHOR")
        End Sub
        Private Sub OnDescriptionItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            InsertField("COMMENTS")
        End Sub
        Private Sub OnKeywordsItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            InsertField("KEYWORDS")
        End Sub
        Private Sub OnLastModifiedByItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            InsertField("LASTSAVEDBY")
        End Sub
        Private Sub OnLastPrintedItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            InsertField("PRINTDATE")
        End Sub
        Private Sub OnModifiedItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            InsertField("SAVEDATE")
        End Sub
        Private Sub OnRevisionItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            InsertField("REVNUM")
        End Sub
        Private Sub OnSubjectItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            InsertField("SUBJECT")
        End Sub
        Private Sub OnTitleItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            InsertField("TITLE")
        End Sub
        #End Region
    End Class
End Namespace
