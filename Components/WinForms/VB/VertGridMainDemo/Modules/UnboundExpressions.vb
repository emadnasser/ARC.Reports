Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraVerticalGrid.Design
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.Data
Imports DevExpress.XtraVerticalGrid.Events

Namespace DevExpress.XtraVerticalGrid.Demos
    Partial Public Class UnboundExpressions
        Inherits TutorialControl

        Private Const NewRow As String = "New", TableGrid As String = "[Order Details]", TableLookUp As String = "Products"

        Public Sub New()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\VertGridMainDemo\Modules\UnboundExpressions.vb"
            TutorialInfo.WhatsThisXMLFile = "UnboundExpressions.xml"
            InitNWindData()
            '<vGridControl1>
            '
            '~Note: the following properties are set at design time and listed here only for demonstration purposes.
            '~
            '~rowTotal.Properties.UnboundExpression = "(1 - [Discount]) * [Quantity] * [UnitPrice]"
            '~rowTotal.Properties.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
            '~rowTotal.Properties.ShowUnboundExpressionMenu = True
            '~
            '~rowTotalAmount.Properties.UnboundExpression = "[Quantity] * [UnitPrice] - [rowTotal0]"
            '~rowTotalAmount.Properties.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
            '~rowTotalAmount.Properties.ShowUnboundExpressionMenu = True
            '
            '</vGridControl1>


        End Sub
        Public Overrides ReadOnly Property ExportControl() As VGridControlBase
            Get
                Return Me.vGridControl1
            End Get
        End Property

        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim ds As New DataSet()
            Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & TableGrid, connectionString)
            SetWaitDialogCaption("Loading Order Details...")
            oleDbDataAdapter.Fill(ds, TableGrid)
            oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & TableLookUp, connectionString)
            SetWaitDialogCaption("Loading Products...")
            oleDbDataAdapter.Fill(ds, TableLookUp)

            vGridControl1.DataSource = ds.Tables(TableGrid)
            repositoryItemLookUpEdit1.DataSource = ds.Tables(TableLookUp)
        End Sub

        '<addNewRow>
        Private Sub addNewRow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles addNewRow.Click
            Dim row As New EditorRow()
            row.Tag = NewRow
            row.Properties.UnboundType = UnboundColumnType.Object
            row.Properties.ShowUnboundExpressionMenu = True
            Me.vGridControl1.Rows(1).ChildRows.Add(row)
            Me.vGridControl1.ShowUnboundExpressionEditor(row.Properties)
        End Sub
        '</addNewRow>

        Private Sub vGridControl1_RowChanged(ByVal sender As Object, ByVal e As RowChangedEventArgs) Handles vGridControl1.RowChanged
            If e.ChangeType = RowChangeTypeEnum.UnboundExpression AndAlso Object.Equals(e.Row.Tag, NewRow) Then
                e.Row.Properties.Caption = e.Row.Properties.UnboundExpression
            End If
        End Sub
    End Class
End Namespace
