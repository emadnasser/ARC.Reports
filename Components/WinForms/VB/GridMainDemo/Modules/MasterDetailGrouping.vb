Imports System.Collections
Imports System.ComponentModel
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for MasterDetailGrouping.
    ''' </summary>
    Partial Public Class MasterDetailGrouping
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\MasterDetailGrouping.vb"
            TutorialInfo.WhatsThisXMLFile = "MasterDetailGrouping.xml"
            Me.gridControl2.LevelTree.Nodes(0).RelationName = My.Resources.Orders
            '<panelControl1>
            '~Specify the name of the child level whose grouping state is displayed in the joined group panel: 
            gridView1.ChildGridLevelName = My.Resources.Orders '~Set ChildGridLevelName to "Orders"
            '</panelControl1>
            InitNWindData()
            InitMasterDetailAppearance()
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub

        Protected Overrides ReadOnly Property PaintViews() As PaintView()
            Get
                Return New PaintView() {New PaintView(gridView1, "Winter"), New PaintView(gridView2, "Spring")}
            End Get
        End Property
#Region "Init"
        Private Sub MasterDetailGrouping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            OnButtonChecked(chOwner)
        End Sub
        Private ReadOnly Property CurrentGrid() As GridControl
            Get
                Return gridControl2
            End Get
        End Property
        Private ReadOnly Property CurrentView() As GridView
            Get
                Return gridView1
            End Get
        End Property
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim oleDBAdapter1 As New OleDbDataAdapter("SELECT * FROM Customers", connectionString)
            Dim oleDBAdapter2 As New OleDbDataAdapter("SELECT * FROM Orders", connectionString)

            SetWaitDialogCaption(My.Resources.LoadingCustomers)
            Dim dataSet As New DataSet()
            oleDBAdapter1.Fill(dataSet, "Customers")

            SetWaitDialogCaption(My.Resources.LoadingOrders)
            oleDBAdapter2.Fill(dataSet, "Orders")

            dataSet.Relations.Add(My.Resources.Orders, dataSet.Tables("Customers").Columns("CustomerID"), dataSet.Tables("Orders").Columns("CustomerID"))

            gridControl2.DataSource = dataSet.Tables("Customers")
        End Sub
        '<panelControl1>
        Private LevelName As String = My.Resources.Orders '~Returns "Orders"
        '</panelControl1>

        Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
            SetWaitDialogCaption(My.Resources.LoadingCustomers)
            Dim dataSet As New DataSet()
            dataSet.ReadXml(dataFileName)

            LevelName = "CustomersOrders"
            Me.gridControl2.LevelTree.Nodes(0).RelationName = LevelName
            Me.gridView1.ChildGridLevelName = LevelName
            Me.gridControl2.ShowOnlyPredefinedDetails = True
            Me.gridControl2.DataSource = dataSet.Tables("Customers")
        End Sub
        Private Sub InitMasterDetailAppearance()
            gridControl2.ForceInitialize()
            gridView1.BeginUpdate()
            gridView1.ExpandAllGroups()
            gridView1.FocusedRowHandle = 2
            gridView1.SetMasterRowExpanded(gridView1.FocusedRowHandle, True)
            gridView1.EndUpdate()
        End Sub
#End Region
#Region "Adjustment"
        Protected Overrides Sub OnSetCaption(ByVal fCaption As String)
            If fCaption = "" Then
                fCaption = GetCheckedCaption()
            End If
            Caption.Text = String.Format("{0} ({1})", TutorialName, fCaption)
        End Sub
        Private Function GetCheckedCaption() As String
            If chOwner.Checked Then
                Return chOwner.Tag.ToString()
            End If
            Return chJoined.Tag.ToString()
        End Function
        '<panelControl1>
        Private Sub SetShowChildrenInGroupPanel(ByVal show As Boolean)
            CurrentView.BeginUpdate()
            CurrentView.OptionsView.ShowChildrenInGroupPanel = show
            If CurrentGrid.LevelTree.Nodes(LevelName) IsNot Nothing Then
                CType(CurrentGrid.LevelTree.Nodes(LevelName).LevelTemplate, GridView).OptionsView.ShowGroupPanel = Not show
            End If
            For i As Integer = 0 To CurrentGrid.Views.Count - 1
                CType(CurrentGrid.Views(i), GridView).ExpandAllGroups()
            Next i
            CurrentView.EndUpdate()
        End Sub
        '</panelControl1>

#End Region
#Region "Grid events"
        Private Sub gridControl2_ViewRegistered(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.ViewOperationEventArgs) Handles gridControl2.ViewRegistered
            CType(e.View, DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups()
        End Sub
        Private Sub gridView_EndGrouping(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridView2.EndGrouping, gridView1.EndGrouping
            Dim gv As GridView = TryCast(sender, GridView)
            gv.ExpandAllGroups()
        End Sub
#End Region

        Private updateInfo As Boolean = False
        Private Sub ch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chJoined.CheckedChanged, chOwner.CheckedChanged
            If updateInfo Then
                Return
            End If
            OnButtonChecked(TryCast(sender, CheckButton))
        End Sub

        Private Sub OnButtonChecked(ByVal button As CheckButton)
            If button.Tag Is Nothing Then Return
            updateInfo = True
            chOwner.Checked = button Is chOwner
            chJoined.Checked = Not chOwner.Checked

            Dim caption As String = button.Tag.ToString()
            OnSetCaption(caption)
            SetShowChildrenInGroupPanel(button Is chJoined)
            CurrentGrid.Focus()
            updateInfo = False
        End Sub
    End Class
End Namespace
