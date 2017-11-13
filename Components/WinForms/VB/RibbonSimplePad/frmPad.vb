Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad
    ''' <summary>
    ''' Summary description for frmPad.
    ''' </summary>
    Partial Public Class frmPad
        Inherits DevExpress.XtraEditors.XtraForm
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("AppIcon.ico", GetType(frmMain).Assembly)
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub

        Private modified_Renamed As Boolean = False
        Private newDocument_Renamed As Boolean = True
        Private docName_Renamed As String = ""

        Public ReadOnly Property RTBMain() As RichTextBox
            Get
                Return richTextBox1
            End Get
        End Property

        Public Property DocName() As String
            Get
                Return docName_Renamed
            End Get
            Set(value As String)
                Me.docName_Renamed = value
                Me.Text = DocName
            End Set
        End Property
        Public Property Modified() As Boolean
            Get
                Return modified_Renamed
            End Get
            Set(value As Boolean)
                If value <> modified_Renamed Then
                    modified_Renamed = value
                    If Modified Then
                        Me.Text = DocName + ("*")
                    Else
                        Me.Text = DocName + ("")
                    End If
                    If Not MdiParent Is Nothing Then
                        CType(MdiParent, frmMain).UpdateText()
                    End If
                End If
            End Set
        End Property
        Public ReadOnly Property NewDocument() As Boolean
            Get
                Return Me.newDocument_Renamed
            End Get
        End Property
        Public Sub LoadDocument(ByVal fileName As String)
            Me.newDocument_Renamed = False
            Try
                RTBMain.LoadFile(fileName)
            Catch
                XtraMessageBox.Show("Sorry, this file cannot be opened.", "Ribbon Simple Pad")
            End Try
            Me.DocName = fileName
        End Sub

        Public Function SaveAs(ByVal path As String) As String
            Dim dlg As SaveFileDialog = New SaveFileDialog()
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
            dlg.Title = "Save As"
            If path <> String.Empty Then
                dlg.InitialDirectory = path
            End If
            If dlg.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                RTBMain.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText)
                Me.DocName = dlg.FileName
                Me.newDocument_Renamed = False
                Me.Modified = False
                Return Me.DocName
            End If
            Return String.Empty
        End Function

        Private Function SaveQuestion() As Boolean
            If Modified Then
                Select Case DevExpress.XtraEditors.XtraMessageBox.Show("Do you want to save the changes you made to " & DocName & "?", "SimplePad Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                    Case Windows.Forms.DialogResult.Cancel
                        Return False
                    Case Windows.Forms.DialogResult.Yes
                        SaveAs(String.Empty)
                End Select
            End If
            Return True
        End Function

        Private Sub frmPad_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
            e.Cancel = Not SaveQuestion()
        End Sub

        Private Sub richTextBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles richTextBox1.MouseUp
            If RTBMain.ClientRectangle.Contains(e.X, e.Y) Then
                If (e.Button And Windows.Forms.MouseButtons.Right) <> 0 Then
                    RaiseShowPopupMenu()
                ElseIf (e.Button And Windows.Forms.MouseButtons.Left) <> 0 Then
                    RaiseShowMiniToolbar()
                End If
            End If
        End Sub

        Public Event ShowPopupMenu As EventHandler
        Public Event ShowMiniToolbar As EventHandler
        Private Sub RaiseShowPopupMenu()
            If Not ShowPopupMenuEvent Is Nothing Then
                RaiseEvent ShowPopupMenu(RTBMain, EventArgs.Empty)
            End If
        End Sub
        Private Sub RaiseShowMiniToolbar()
            If Not ShowPopupMenuEvent Is Nothing Then
                RaiseEvent ShowMiniToolbar(RTBMain, EventArgs.Empty)
            End If
        End Sub
    End Class
End Namespace
