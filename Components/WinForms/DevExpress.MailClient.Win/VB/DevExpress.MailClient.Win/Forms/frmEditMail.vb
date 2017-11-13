Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars

Namespace DevExpress.MailClient.Win
	Partial Public Class frmEditMail
		Inherits RibbonForm

		Private isMessageModified_Renamed As Boolean
        Private newMessage As Boolean = True
        Private messageFrom As String = String.Empty
        Private ReadOnly sourceMessage_Renamed As Message

		Public Sub New()
			InitializeComponent()
			DialogResult = DialogResult.Cancel
		End Sub
		Public Sub New(ByVal message As Message, ByVal newMessage As Boolean, ByVal caption As String)
			InitializeComponent()
			DictionaryHelper.InitDictionary(spellChecker1)
			Me.newMessage = newMessage
			DialogResult = DialogResult.Cancel
			Me.sourceMessage_Renamed = message
			edtSubject.Text = message.Subject
            TokenEditHelper.InitializeHistory(edtTo)
            edtTo.EditValue = TokenEditHelper.GetValue(message.From)
			richEditControl.HtmlText = message.Text
			Me.isMessageModified_Renamed = newMessage
			If String.IsNullOrEmpty(message.From) Then
				splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
			End If
			splitContainerControl1.Collapsed = newMessage
            ucMessageInfo1.Init(message, ribbonControl.Manager)
            Me.sendToEditSize = edtTo.Size
            Me.messageFrom = message.From
            If Not newMessage Then
                splitContainerControl1.Collapsed = LayoutOption.MailCollapsed
                lblTo.Text = String.Format("{0}:", caption)
                edtTo.Properties.ReadOnly = True
                edtSubject.Properties.ReadOnly = True
                richEditControl.ReadOnly = True
            End If
        End Sub
        Protected Overrides Sub OnLoad(e As System.EventArgs)
            MyBase.OnLoad(e)
        End Sub
		Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
			MyBase.OnClosing(e)
			If Not newMessage Then
				LayoutOption.MailCollapsed = splitContainerControl1.Collapsed
			End If
		End Sub
		Public ReadOnly Property SourceMessage() As Message
			Get
				Return sourceMessage_Renamed
			End Get
		End Property
		Public Property IsMessageModified() As Boolean
			Get
				Return isMessageModified_Renamed OrElse richEditControl.Modified
			End Get
			Set(ByVal value As Boolean)
				isMessageModified_Renamed = value
				richEditControl.Modified = value
			End Set
		End Property
		#Region "SaveMessage event"
		Private onSaveMessage As EventHandler
		Public Custom Event SaveMessage As EventHandler
			AddHandler(ByVal value As EventHandler)
				onSaveMessage = DirectCast(System.Delegate.Combine(onSaveMessage, value), EventHandler)
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				onSaveMessage = DirectCast(System.Delegate.Remove(onSaveMessage, value), EventHandler)
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
				If onSaveMessage IsNot Nothing Then
					For Each d As EventHandler In onSaveMessage.GetInvocationList()
						d.Invoke(sender, e)
					Next d
				End If
			End RaiseEvent
		End Event
		Protected Friend Overridable Sub RaiseSaveMessage()
			If onSaveMessage IsNot Nothing Then
				onSaveMessage(Me, EventArgs.Empty)
			End If
		End Sub
		#End Region

		Private Sub richEditControl_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.SelectionChanged
			tableToolsRibbonPageCategory1.Visible = richEditControl.IsSelectionInTable()
			floatingPictureToolsRibbonPageCategory1.Visible = richEditControl.IsFloatingObjectSelected
		End Sub
		Private Sub edtTo_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtTo.EditValueChanged
			isMessageModified_Renamed = True
		End Sub
        Private Sub edtTo_ValidateToken(ByVal sender As Object, ByVal e As TokenEditValidateTokenEventArgs) Handles edtTo.ValidateToken
            If (Not String.IsNullOrEmpty(Me.messageFrom)) AndAlso String.Equals(Me.messageFrom, e.Description, StringComparison.OrdinalIgnoreCase) Then
                e.IsValid = True
                Return
            End If
            e.IsValid = TextHelper.IsMailAddressValid(e.Description)
        End Sub
        Private Sub edtTo_BeforeShowPopupPanel(ByVal sender As Object, ByVal e As TokenEditBeforeShowPopupPanelEventArgs) Handles edtTo.BeforeShowPopupPanel
            Dim contact As Contact = TryCast(e.Value, Contact)
            Me.lblMail.Text = If((contact IsNot Nothing), contact.FullName.ToString(), e.Description)
            Me.lblDescription.Text = e.Description
            Me.picContact.Image = If((contact IsNot Nothing AndAlso contact.HasPhoto), contact.Photo, My.Resources.Unknown_user)
        End Sub
        Private Sub edtTo_TokenCustomDraw(ByVal sender As Object, ByVal e As TokenEditCustomDrawTokenGlyphEventArgs) Handles edtTo.CustomDrawTokenGlyph
            Dim image As Image = GetTagGlyphImage(e.Value)
            If image IsNot Nothing Then
                e.Cache.Paint.DrawImage(e.Graphics, image, e.GlyphBounds, New Rectangle(Point.Empty, image.Size), True)
            End If
            e.Handled = True
        End Sub
        Private Function GetTagGlyphImage(ByVal tag As Object) As Image
            Dim contact As Contact = TryCast(tag, Contact)
            If contact Is Nothing Then
                Return My.Resources.Owner
            End If
            Return contact.Icon
        End Function
        Private sendToEditSize As Size = Size.Empty
        Private Sub edtTo_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtTo.SizeChanged
            Dim newSize As Size = (CType(sender, TokenEdit)).Size
            panelControl.Height += (newSize.Height - sendToEditSize.Height)
            Me.sendToEditSize = newSize
        End Sub
        Private Sub edtSubject_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtSubject.EditValueChanged
            isMessageModified_Renamed = True
        End Sub
        Private Sub fileSaveItem1_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles fileSaveItem1.ItemClick
            ApplyChanges()
        End Sub
        'void frmEditMail_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
        '    if (e.KeyCode == Keys.Escape) {
        '        if (QueryClose() != DialogResult.Cancel)
        '            Close();
        '    }
        '}
        Private Sub richEditControl_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles richEditControl.KeyDown
            If (e.Modifiers And Keys.Control) <> 0 AndAlso e.KeyCode = Keys.S Then
                ApplyChanges()
                e.Handled = True
            End If
        End Sub

        Private Sub frmEditMail_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            Dim result As DialogResult = QueryClose()
            e.Cancel = result = DialogResult.Cancel
        End Sub
        Private Function QueryClose() As DialogResult
            If Not IsMessageModified Then
                Return DialogResult.Yes
            End If

            Dim result As DialogResult = XtraMessageBox.Show(Me, My.Resources.SaveQuestion, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
            Select Case result
                Case DialogResult.Cancel
                    Return DialogResult.Cancel
                Case DialogResult.No
                    Return DialogResult.No
                Case Else
                    ApplyChanges()
                    Return DialogResult.Yes
            End Select
        End Function
        Private Sub ApplyChanges()
            SourceMessage.Date = DateTime.Now
            SourceMessage.Text = richEditControl.HtmlText
            SourceMessage.SetPlainText(ObjectHelper.GetPlainText(richEditControl.Text.TrimStart()))
            SourceMessage.Subject = edtSubject.Text
            SourceMessage.From = edtTo.EditValue.ToString()
            IsMessageModified = False
            RaiseSaveMessage()
        End Sub
    End Class
End Namespace
