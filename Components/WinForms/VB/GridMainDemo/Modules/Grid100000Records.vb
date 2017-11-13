Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports System.Linq
Imports System.Collections.Generic
Imports System.Threading

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class Grid100000Records
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            CreateWaitDialog()
            InitializeComponent()
            CreateData()
        End Sub
        Private startTickCount, endTickCount As Integer

        Private ReadOnly Property OperationSeconds() As Double
            Get
                Return CDbl(endTickCount - startTickCount) / 1000
            End Get
        End Property
        Private Sub StartGroupingSorting(ByVal sender As Object, ByVal e As EventArgs)
            Me.startTickCount = System.Environment.TickCount
        End Sub
        Public Class Record
            Public Property Id() As Integer
            Public Property Text() As String
            Public Property Bool() As Boolean?
            Public Property [Date]() As Date?
            Public Property Currency() As Decimal?
        End Class
        Private Const RowCount As Integer = 100000
        Private Sub CreateData()
            SetWaitDialogCaption(My.Resources.CreatingData)
            Dim dateTime As Date = Date.Now
            Dim textBase As String = My.Resources.Text
            Dim random As New Random()
            Me.bindingSource1.DataSource = Enumerable.Range(0, RowCount).Select(Function(i) New Record() With {.Id = i + 1, .Text = textBase & " " & (i Mod 100 + 1).ToString(), .Bool = random.Next(1000) Mod 2 = 1, .Date = dateTime.AddDays(random.Next(100)), .Currency = random.Next(1000000) / 100D}).ToList()
        End Sub

        Private Sub gridView1_CalcPreviewText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventArgs) Handles gridView1.CalcPreviewText
            Dim row_Renamed As Record = CType(gridView1.GetRow(e.RowHandle), Record)
            If row_Renamed.Currency > 5000 Then
                e.PreviewText = String.Format(My.Resources.RecordDescription, row_Renamed.Id)
            End If
        End Sub
    End Class
End Namespace

