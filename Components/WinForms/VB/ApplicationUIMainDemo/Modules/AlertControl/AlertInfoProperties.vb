Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.Utils

Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class AlertInfoProperties
        Inherits XtraUserControl
        Public Sub New()
            InitializeComponent()
        End Sub
        Private _caption, _text, _captionHtml, _textHtml, _hotTrackedTextHtml As String
        Public Sub InitValues(ByVal caption As String, ByVal text As String, ByVal captionHtml As String, ByVal textHtml As String, ByVal hotTrackedTextHtml As String)
            Me._caption = caption
            Me._captionHtml = captionHtml
            Me._text = text
            Me._textHtml = textHtml
            Me._hotTrackedTextHtml = hotTrackedTextHtml
        End Sub

        Public ReadOnly Property Caption() As String
            Get
                Return txtCaption.Text
            End Get
        End Property
        Public ReadOnly Property TextInfo() As String
            Get
                Return txtText.Text
            End Get
        End Property
        Public ReadOnly Property HotTrackedText() As String
            Get
                Return txtHotTrackedText.Text
            End Get
        End Property
        Public ReadOnly Property Image() As Image
            Get
                If ceShowAnimatedImage.Checked Then
                    Return ResourceImageHelper.CreateImageFromResources("Alarm-Clock.gif", GetType(AlertInfoProperties).Assembly)
                End If
                If icbImage.SelectedIndex > 4 Then
                    Return Nothing
                End If
                Return imageCollection1.Images(icbImage.SelectedIndex)
            End Get
        End Property

        Private allowHtml As Boolean = False
        Private initValues_Renamed As Boolean = False
        Friend Sub UpdateInfo(ByVal allowHtml As Boolean)
            initValues_Renamed = True
            Me.allowHtml = allowHtml
            If allowHtml Then
                txtCaption.Text = _captionHtml
                txtText.Text = _textHtml
                txtHotTrackedText.Text = _hotTrackedTextHtml
                txtHotTrackedText.Visible = True
                lcHotTrackedText.Visible = True
            Else
                txtCaption.Text = _caption
                txtText.Text = _text
                txtHotTrackedText.Text = ""
                txtHotTrackedText.Visible = False
                lcHotTrackedText.Visible = False
            End If
            initValues_Renamed = False
        End Sub

        Private Sub txtCaption_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCaption.EditValueChanged
            If initValues_Renamed Then
                Return
            End If
            If allowHtml Then
                _captionHtml = txtCaption.Text
            Else
                _caption = txtCaption.Text
            End If
        End Sub

        Private Sub txtText_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtText.EditValueChanged
            If initValues_Renamed Then
                Return
            End If
            If allowHtml Then
                _textHtml = txtText.Text
            Else
                _text = txtText.Text
            End If
        End Sub

        Private Sub txtSelectedText_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtHotTrackedText.EditValueChanged
            If initValues_Renamed Then
                Return
            End If
            If allowHtml Then
                _hotTrackedTextHtml = txtHotTrackedText.Text
            End If
        End Sub

        Private Sub ceShowAnimatedImage_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowAnimatedImage.CheckedChanged
            icbImage.Enabled = Not ceShowAnimatedImage.Checked
        End Sub
    End Class
End Namespace
