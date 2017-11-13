Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for RowFormat.
	''' </summary>
	Public Partial Class RowFormat
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
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
		'<vGridControl1>
		Private Sub RowFormat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
		End Sub

		Private Sub InitData()
			FillData()
			CreateRow(vGridControl1, "Currency format", "Payment", 0, DevExpress.Utils.FormatType.Numeric, "c")
			CreateRow(vGridControl1, "Hexadecimal format", "Length", 1, DevExpress.Utils.FormatType.Numeric, "x")
			CreateRow(vGridControl1, "LongDate format", "PurchaseDate", 2, DevExpress.Utils.FormatType.DateTime, "D")
			CreateRow(vGridControl1, "Custom Format", "Number", 3, DevExpress.Utils.FormatType.Custom, "B2")
			vGridControl1.RecordWidth = 150
		End Sub

		Private Sub CreateRow(ByVal vg As VGridControl, ByVal caption As String, ByVal field As String, ByVal visibleindex As Integer, ByVal formatType As DevExpress.Utils.FormatType, ByVal formatString As String)
			Dim row As DevExpress.XtraVerticalGrid.Rows.EditorRow = New DevExpress.XtraVerticalGrid.Rows.EditorRow(field)
			vg.Rows.Add(row)
			row.Properties.Caption = caption
			row.Height = 30
			row.Properties.Format.FormatType = formatType
			If formatType = DevExpress.Utils.FormatType.Custom Then
				row.Properties.Format.Format = New BaseFormatter()
			End If
			row.Properties.Format.FormatString = formatString
		End Sub
		'</vGridControl1>

		Private Sub FillData()
			Dim records As RowFormatRecord() = New RowFormatRecord(4){}
            records(0) = New RowFormatRecord(32.35, 100000, DateTime.Parse("5/3/1999", System.Globalization.CultureInfo.InvariantCulture), 10)
            records(1) = New RowFormatRecord(20, 65535, DateTime.Parse("10/7/2001", System.Globalization.CultureInfo.InvariantCulture), 65)
			records(2) = New RowFormatRecord(100.99, 9999999999, DateTime.Now, 100)
            records(3) = New RowFormatRecord(250.5, 10, DateTime.Parse("12/1/2003", System.Globalization.CultureInfo.InvariantCulture), 20)
            records(4) = New RowFormatRecord(15, 0, DateTime.Parse("7/7/2002", System.Globalization.CultureInfo.InvariantCulture), 4)

			vGridControl1.DataSource = records
		End Sub
	End Class
End Namespace
