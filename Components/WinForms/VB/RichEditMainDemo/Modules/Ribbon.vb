Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports System.Globalization
Imports DevExpress.XtraSpellChecker
Imports DevExpress.XtraSpellChecker.Native
Imports DevExpress.XtraSpellChecker.Parser
Imports DevExpress.XtraRichEdit.SpellChecker
Imports DevExpress.XtraRichEdit.Services

Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class RibbonModule
		Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
		Private userService As UserService
		Public Sub New()
			InitializeComponent()
			RigesterUserListService()
            OpenXmlLoadHelper.Load("MovieRentals.docx", richEditControl)
            CType(New RichEditDemoExceptionsHandler(richEditControl), RichEditDemoExceptionsHandler).Install()
		End Sub

		Public Overrides ReadOnly Property PrintingRichEditControl() As RichEditControl
			Get
				Return richEditControl
			End Get
		End Property

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
            richEditControl.Focus()
            ribbonControl1.SelectedPage = HomeRibbonPage1
		End Sub

		Private Sub RibbonModule_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			If DesignMode Then
				Return
			End If

			SpellCheckerHelper.AddDictionaries(sharedDictionaryStorage1)
		End Sub

		Private Sub richEditControl_StartHeaderFooterEditing(ByVal sender As Object, ByVal e As HeaderFooterEditingEventArgs) Handles richEditControl.StartHeaderFooterEditing
			headerFooterToolsRibbonPageCategory1.Visible = True
			ribbonControl1.SelectedPage = headerFooterToolsDesignRibbonPage1
		End Sub

		Private Sub richEditControl_FinishHeaderFooterEditing(ByVal sender As Object, ByVal e As HeaderFooterEditingEventArgs) Handles richEditControl.FinishHeaderFooterEditing
            headerFooterToolsRibbonPageCategory1.Visible = False
        End Sub

		Private Sub richEditControl_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.SelectionChanged
            tableToolsRibbonPageCategory1.Visible = richEditControl.IsSelectionInTable()
            FloatingPictureToolsRibbonPageCategory1.Visible = richEditControl.IsFloatingObjectSelected
        End Sub
		Private Sub RigesterUserListService()
			Me.richEditControl.RemoveService(GetType(IUserListService))
			Me.userService = New UserService()
			Me.userService.Users.Add("lawyer@somecompany.com")
			Me.userService.Users.Add("projectmanager@somecompany.com")
			Me.userService.Users.Add("senior@somecompany.com")
			Me.userService.Users.Add("novice@somecompany.com")
			Me.richEditControl.AddService(GetType(IUserListService), Me.userService)
		End Sub
	End Class
End Namespace
