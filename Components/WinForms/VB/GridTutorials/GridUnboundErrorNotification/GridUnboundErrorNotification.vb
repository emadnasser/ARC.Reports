Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridUnboundErrorNotification.
    ''' </summary>
    Partial Public Class GridUnboundErrorNotification
        Inherits TutorialControl
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub

        Private Sub GridUnboundErrorNotification_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
            ValidateData()
        End Sub

        Private Sub InitData()
            Dim dates As ProjectNotes = New ProjectNotes()
            dates.Add(New NoteInfo(231, 4, 1, 2006))
            dates.Add(New NoteInfo(232, 6, 3, 2006))
            dates.Add(New NoteInfo(233, 24, 15, 2006))
            dates.Add(New NoteInfo(234, 17, 8, 2005))
            dates.Add(New NoteInfo(237, 29, 2, 2005))
            dates.Add(New NoteInfo(238, 30, 2, 2004))
            gridControl1.DataSource = dates
        End Sub

        '<gridControl1>
        Private Function IsValidDate(ByVal day As Integer, ByVal month As Integer, ByVal year As Integer) As String
            If month < 1 OrElse month > 12 Then
                Return "Month"
            End If
            If day < 1 OrElse day > DateTime.DaysInMonth(year, month) Then
                Return "Day"
            End If
            If year < 1980 OrElse year > 2010 Then
                Return "Year"
            End If
            Return ""
        End Function

        Private Sub ValidateData()
            Dim notes As ProjectNotes = TryCast(gridControl1.DataSource, ProjectNotes)
            For Each nInfo As NoteInfo In notes
                Dim valid As String = IsValidDate(nInfo.Day, nInfo.Month, nInfo.Year)
                nInfo.ClearErrors()
                If valid <> "" Then
                    nInfo.NoteError = "Check the date"
                    nInfo.SetColumnError(valid, "Invalid " & valid)
                End If
            Next nInfo
        End Sub
        '</gridControl1>

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
            ValidateData()
        End Sub

        '<gridControl1>
        Private Sub gridView1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gridView1.ValidateRow
            ValidateData()
        End Sub
        '</gridControl1>
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
