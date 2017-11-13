Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils.Menu
Imports DevExpress.Data.Filtering

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class ExcelFiltering
        Inherits TutorialControl

        Public Overrides ReadOnly Property ExportView() As BaseView
            Get
                Return bandedGridView1
            End Get
        End Property
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            VehiclesData.InitOrdersData(connectionString, gridControl1, 10000, 400)
            VehiclesData.InitColumnViewEditors(bandedGridView1)
        End Sub
        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
            InitVehiclesData()
            bandedGridView1.ActiveFilterCriteria = New GroupOperator(GroupOperatorType.Or, _
                New FunctionOperator(FunctionOperatorType.IsOutlookIntervalYesterday, New OperandProperty("SalesDate")), _
                New FunctionOperator(FunctionOperatorType.IsOutlookIntervalToday, New OperandProperty("SalesDate")))
        End Sub
#Region "GenerateReport"
        Public Overrides ReadOnly Property AllowGenerateReport() As Boolean
            Get
                Return False
            End Get
        End Property
#End Region
    End Class
End Namespace
