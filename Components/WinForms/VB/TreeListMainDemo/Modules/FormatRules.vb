Namespace DevExpress.XtraTreeList.Demos
    Public Class FormatRules
        Inherits DevExpress.XtraTreeList.Demos.TutorialControl
        Public Overrides ReadOnly Property ExportControl() As TreeList
            Get
                Return treeList1
            End Get
        End Property
        Public Sub New()
            InitializeComponent()
            treeList1.DataSource = SalesDataGenerator.CreateData()
            treeList1.ExpandAll()
        End Sub
        Private Sub treeList1_Load(sender As Object, e As EventArgs) Handles treeList1.Load
            treeList1.BestFitColumns()
        End Sub
    End Class
End Namespace

