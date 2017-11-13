Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridColumnFormat.
    ''' </summary>
    Partial Public Class GridColumnFormat
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

        '<gridControl1>
        Private Sub GridColumnFormat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            CreateGridColumn(gridView1, "Payment (Currency format)", "Payment", 0, DevExpress.Utils.FormatType.Numeric, "c")
            CreateGridColumn(gridView1, "Lenght (Exponential format)", "Lenght", 1, DevExpress.Utils.FormatType.Numeric, "e")
            CreateGridColumn(gridView1, "Lenght (Hexadecimal format)", "Lenght", 2, DevExpress.Utils.FormatType.Numeric, "x")
            CreateGridColumn(gridView1, "PurchaseDate (LongDate format)", "PurchaseDate", 3, DevExpress.Utils.FormatType.DateTime, "D")
            CreateGridColumn(gridView1, "Custom Format", "Number", 4, DevExpress.Utils.FormatType.Custom, "B2")
            InitData()
            gridView1.BestFitColumns()
        End Sub
        Private Sub CreateGridColumn(ByVal cv As DevExpress.XtraGrid.Views.Base.ColumnView, ByVal caption As String, ByVal field As String, ByVal visibleindex As Integer, ByVal formatType As DevExpress.Utils.FormatType, ByVal formatString As String)
            Dim gc As DevExpress.XtraGrid.Columns.GridColumn = cv.Columns.Add()
            gc.Caption = caption
            gc.FieldName = field
            gc.VisibleIndex = visibleindex
            gc.DisplayFormat.FormatType = formatType
            If formatType = DevExpress.Utils.FormatType.Custom Then
                gc.DisplayFormat.Format = New BaseFormatter()
            End If
            gc.DisplayFormat.FormatString = formatString
        End Sub
        '</gridControl1>

        Private Sub InitData()
            Dim records As ColumnFormatRecord() = New ColumnFormatRecord(4) {}
            records(0) = New ColumnFormatRecord(32.35, 100000, DateTime.Parse("5/3/2003", System.Globalization.CultureInfo.InvariantCulture), 10)
            records(1) = New ColumnFormatRecord(20, 65535, DateTime.Parse("10/7/2002", System.Globalization.CultureInfo.InvariantCulture), 65)
            records(2) = New ColumnFormatRecord(100.99, 9999999999, DateTime.Now, 100)
            records(3) = New ColumnFormatRecord(250.5, 10, DateTime.Parse("12/1/2001", System.Globalization.CultureInfo.InvariantCulture), 20)
            records(4) = New ColumnFormatRecord(15, 0, DateTime.Parse("4/4/2003", System.Globalization.CultureInfo.InvariantCulture), 4)

            gridControl1.DataSource = records
        End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
