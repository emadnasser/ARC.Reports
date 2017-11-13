Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.XtraRichEdit.API.Layout
Imports DevExpress.XtraRichEdit.Utils
Imports System.Globalization
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraRichEdit.Demos
	#Region "DocumentProperties"
	Partial Public Class DocumentProperties
		Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
		Public Sub New()
			InitializeComponent()
			OpenXmlLoadHelper.Load("DocumentProperties.docx", richEditControl)
			Document.Fields.Update()
		End Sub

		#Region "Properties"
		Private ReadOnly Property Document() As Document
			Get
				Return richEditControl.Document
			End Get
		End Property
		#End Region

		Private Sub RichEditControl_DocumentPropertiesChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.DocumentPropertiesChanged
			Document.Fields.Update()
		End Sub
		Private Sub RichEditControl_CustomPropertiesChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.CustomPropertiesChanged
			Document.Fields.Update()
		End Sub
		Private Sub OnCalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs) Handles richEditControl.CalculateDocumentVariable
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
			Dim field As Field = Document.Fields.Create(richEditControl.Document.CaretPosition, code)
			field.Update()
			Document.EndUpdate()
		End Sub

		#Region "ItemClick"
		Private Sub OnCategoryItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			InsertField("DOCPROPERTY Category")
		End Sub
		Private Sub OnCreatedItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles barButtonItem2.ItemClick
			InsertField("CREATEDATE")
		End Sub
		Private Sub OnCreatorItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles barButtonItem3.ItemClick
			InsertField("AUTHOR")
		End Sub
		Private Sub OnDescriptionItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles barButtonItem4.ItemClick
			InsertField("COMMENTS")
		End Sub
		Private Sub OnKeywordsItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles barButtonItem5.ItemClick
			InsertField("KEYWORDS")
		End Sub
		Private Sub OnLastModifiedByItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles barButtonItem6.ItemClick
			InsertField("LASTSAVEDBY")
		End Sub
		Private Sub OnLastPrintedItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles barButtonItem7.ItemClick
			InsertField("PRINTDATE")
		End Sub
		Private Sub OnModifiedItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles barButtonItem8.ItemClick
			InsertField("SAVEDATE")
		End Sub
		Private Sub OnRevisionItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles barButtonItem9.ItemClick
			InsertField("REVNUM")
		End Sub
		Private Sub OnSubjectItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles barButtonItem10.ItemClick
			InsertField("SUBJECT")
		End Sub
		Private Sub OnTitleItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles barButtonItem11.ItemClick
			InsertField("TITLE")
		End Sub
		#End Region
	End Class
	#End Region
End Namespace
