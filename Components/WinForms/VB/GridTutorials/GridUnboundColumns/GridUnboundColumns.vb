Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridUnboundColumns.
    ''' </summary>
    Partial Public Class GridUnboundColumns
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

        Private array As ArrayList = Nothing
        Private Sub GridUnboundColumns_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Contacts.xml")
            If DBFileName <> "" Then
                Dim dataSet As DataSet = New DataSet()
                dataSet.ReadXml(DBFileName)
                array = New ArrayList()
                Dim i As Integer = 0
                Do While i < dataSet.Tables(0).DefaultView.Count
                    array.Add(Record.CreateRecord())
                    i += 1
                Loop
                gridControl1.DataSource = dataSet.Tables(0).DefaultView
            End If
        End Sub

        '<gridControl1>
        Private Sub bandedGridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles bandedGridView1.CustomUnboundColumnData
            If Object.ReferenceEquals(e.Column, bandedGridColumn1) Then
                Dim row As DataRowView = TryCast(e.Row, DataRowView)
                e.Value = String.Format("{0} {1}", row("FirstName"), row("LastName"))
                Return
            End If

            If array Is Nothing Then
                Return
            End If
            If e.ListSourceRowIndex >= array.Count Then
                Return
            End If
            Dim rec As Record = TryCast(array(e.ListSourceRowIndex), Record)
            If rec Is Nothing Then
                Return
            End If
            Select Case e.Column.UnboundType
                Case UnboundColumnType.DateTime
                    If e.IsGetData Then
                        e.Value = rec.DateAndTime
                    Else
                        rec.DateAndTime = CDate(e.Value)
                    End If
                Case UnboundColumnType.Integer
                    If e.IsGetData Then
                        e.Value = rec.Count
                    Else
                        rec.Count = CInt(Fix(e.Value))
                    End If
                Case UnboundColumnType.String
                    If e.IsGetData Then
                        e.Value = rec.Comment
                    Else
                        rec.Comment = e.Value.ToString()
                    End If
            End Select
        End Sub
        '</gridControl1>
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property

        Public Class Record
            Private fieldDateAndTime As DateTime
            Private count_Renamed As Integer
            Private comment_Renamed As String

            Private Shared rnd As Random = New Random()
            Public Shared Function CreateRecord() As Record
                Return New Record(DateTime.Now.AddDays(-rnd.Next(30)), rnd.Next(10) + 1, "Put your comments here...")
            End Function

            Public Sub New(ByVal fieldDateAndTime As DateTime, ByVal count_Renamed As Integer, ByVal comment_Renamed As String)
                Me.fieldDateAndTime = fieldDateAndTime
                Me.count_Renamed = count_Renamed
                Me.comment_Renamed = comment_Renamed
            End Sub

            Public Property Count() As Integer
                Get
                    Return count_Renamed
                End Get
                Set(ByVal value As Integer)
                    count_Renamed = value
                End Set
            End Property
            Public Property DateAndTime() As DateTime
                Get
                    Return fieldDateAndTime
                End Get
                Set(ByVal value As DateTime)
                    fieldDateAndTime = value
                End Set
            End Property
            Public Property Comment() As String
                Get
                    Return comment_Renamed
                End Get
                Set(ByVal value As String)
                    comment_Renamed = value
                End Set
            End Property
        End Class
    End Class
End Namespace
