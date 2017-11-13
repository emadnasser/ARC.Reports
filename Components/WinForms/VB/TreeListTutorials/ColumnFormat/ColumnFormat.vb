Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for ColumnFormat.
	''' </summary>
	Public Partial Class ColumnFormat
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			InitData()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
		'<treeList1>
		Private Sub InitData()
			FillData()
			CreateColumn(treeList1, "Currency format", "Payment", 0, DevExpress.Utils.FormatType.Numeric, "c")
			CreateColumn(treeList1, "Hexadecimal format", "Lenght", 1, DevExpress.Utils.FormatType.Numeric, "x")
			CreateColumn(treeList1, "LongDate format", "PurchaseDate", 2, DevExpress.Utils.FormatType.DateTime, "D")
			CreateColumn(treeList1, "Custom Format", "Number", 3, DevExpress.Utils.FormatType.Custom, "B2")
			treeList1.BestFitColumns()
		End Sub

		Private Sub CreateColumn(ByVal tl As TreeList, ByVal caption As String, ByVal field As String, ByVal visibleindex As Integer, ByVal formatType As DevExpress.Utils.FormatType, ByVal formatString As String)
			Dim col As DevExpress.XtraTreeList.Columns.TreeListColumn = tl.Columns.Add()
			col.Caption = caption
			col.FieldName = field
			col.VisibleIndex = visibleindex
			col.Format.FormatType = formatType
			If formatType = DevExpress.Utils.FormatType.Custom Then
				col.Format.Format = New BaseFormatter()
			End If
			col.Format.FormatString = formatString
		End Sub
		'</treeList1>

		Private Sub FillData()
			Dim records As ColumnFormatRecord() = New ColumnFormatRecord(4){}
            records(0) = New ColumnFormatRecord(32.35, 100000, DateTime.Parse("5/3/1999", System.Globalization.CultureInfo.InvariantCulture), 10)
            records(1) = New ColumnFormatRecord(20, 65535, DateTime.Parse("10/7/2001", System.Globalization.CultureInfo.InvariantCulture), 65)
			records(2) = New ColumnFormatRecord(100.99, 9999999999, DateTime.Now, 100)
            records(3) = New ColumnFormatRecord(250.5, 10, DateTime.Parse("12/1/2003", System.Globalization.CultureInfo.InvariantCulture), 20)
            records(4) = New ColumnFormatRecord(15, 0, DateTime.Parse("7/7/2002", System.Globalization.CultureInfo.InvariantCulture), 4)

			treeList1.DataSource = records
		End Sub

		Private Sub ColumnFormat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			treeList1.BestFitColumns()
		End Sub
	End Class
End Namespace
