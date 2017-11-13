Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class UnboundExpression
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\UnboundExpression.vb"
            TutorialInfo.WhatsThisXMLFile = "UnboundExpression.xml"
            '<gridControl1>
            '
            '~Note: the following properties are set at design time and listed here only for demonstration purposes.
            '~
            '~Discount Amount column:
            '~gridColumn7.OptionsColumn.AllowEdit = False
            '~gridColumn7.ShowUnboundExpressionMenu = True
            '~gridColumn7.UnboundExpression = "[UnitPrice] * [Quantity] - [Total]"
            '~gridColumn7.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
            '~
            '~Total column:
            '~gridColumn6.OptionsColumn.AllowEdit = False
            '~gridColumn6.ShowUnboundExpressionMenu = True
            '~gridColumn6.UnboundExpression = "[UnitPrice] * [Quantity] * (1 - [Discount])"
            '~gridColumn6.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
            '
            '</gridControl1>
        End Sub

        Private Sub UnboundExpression_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            InitNWindData()
            InitCombo()
            gridView1.ExpandAllGroups()
        End Sub

        Private Sub InitCombo()
            For Each column As GridColumn In gridView1.Columns
                If column.ShowUnboundExpressionMenu Then
                    imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem(column.GetTextCaption(), column, column.ImageIndex))
                End If
            Next column
            imageComboBoxEdit1.SelectedIndex = 0
        End Sub

        Private tblGrid As String = "[Order Details]"
        Private tblLookUp As String = "Products"
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim ds As New DataSet()
            Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblGrid, connectionString)
            SetWaitDialogCaption(My.Resources.LoadingOrderDetails)
            oleDbDataAdapter.Fill(ds, tblGrid)
            oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblLookUp, connectionString)
            SetWaitDialogCaption(My.Resources.LoadingProducts)
            oleDbDataAdapter.Fill(ds, tblLookUp)

            gridControl1.DataSource = ds.Tables(tblGrid)
            repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
        End Sub

        '<simpleButton1>
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            Dim column As GridColumn = TryCast(imageComboBoxEdit1.EditValue, GridColumn)
            If column Is Nothing Then
                Return
            End If
            gridView1.ShowUnboundExpressionEditor(column)
        End Sub
        '</simpleButton1>
    End Class
End Namespace
