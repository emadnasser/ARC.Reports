Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for RowHeight.
    ''' </summary>
    Partial Public Class RowHeight
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\RowHeight.vb"
            TutorialInfo.WhatsThisXMLFile = "RowHeight.xml"
            InitNWindData()
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub
        #Region "Init"
        Private Sub RowHeight_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitAutoHeight()
        End Sub
        Public Overrides ReadOnly Property ExportView() As DevExpress.XtraGrid.Views.Base.BaseView
            Get
                Return gridView1
            End Get
        End Property
        Private ReadOnly Property CurrentGrid() As GridControl
            Get
                Return gridControl1
            End Get
        End Property
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim ds As New DataSet()
            Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Employees", connectionString)

            SetWaitDialogCaption(My.Resources.LoadingEmployees)
            oleDbDataAdapter.Fill(ds, "Employees")

            CurrentGrid.DataSource = ds.Tables("Employees")
        End Sub
        Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
            Dim ds As New DataSet()
            SetWaitDialogCaption(My.Resources.LoadingTables)
            ds.ReadXml(dataFileName)

            CurrentGrid.DataSource = ds.Tables("Employees")
        End Sub
        Private Sub InitAutoHeight()
            If TypeOf CurrentGrid.MainView Is GridView Then
                cheAutoHeight.Checked = gridView1.OptionsView.RowAutoHeight
            Else
                cheAutoHeight.Checked = cardView1.OptionsBehavior.FieldAutoHeight
            End If
            cheMemo.Checked = repositoryItemMemoEdit1.LinesCount = 0
            chePicture.Checked = repositoryItemPictureEdit1.CustomHeight = 0
            InitEnabledAutoHeight()
        End Sub
        Private Sub InitEnabledAutoHeight()
            chePicture.Enabled = cheAutoHeight.Checked
            cheMemo.Enabled = chePicture.Enabled
        End Sub
        #End Region
        #Region "Editing"
        '<cheAutoHeight>
        Private Sub chbAutoHeight_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cheAutoHeight.CheckedChanged
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            If TypeOf CurrentGrid.MainView Is GridView Then
                gridView1.OptionsView.RowAutoHeight = ce.Checked
            Else
                cardView1.OptionsBehavior.FieldAutoHeight = ce.Checked
            End If
            '<skip>
            InitEnabledAutoHeight()
            '</skip>
        End Sub
        '</cheAutoHeight>
        '<cheMemo>
        Private Sub chbMemo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cheMemo.CheckedChanged
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            repositoryItemMemoEdit1.LinesCount = If(ce.Checked, 0, 1)
        End Sub
        '</cheMemo>
        '<chePicture>
        Private Sub chbPicture_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chePicture.CheckedChanged
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            repositoryItemPictureEdit1.CustomHeight = If(ce.Checked, 0, 40)
            gridView1.TopRowIndex = 0
        End Sub
        '</chePicture>
        Private ReadOnly Property ActiveViewCaption() As String
            Get
                Return If(CurrentGrid.MainView Is gridView1, My.Resources.GridView, My.Resources.CardView)
            End Get
        End Property
        Private ReadOnly Property SwitchButtonCaption() As String
            Get
                Return If(CurrentGrid.MainView Is gridView1, My.Resources.ShowCardView, My.Resources.ShowGridView)
            End Get
        End Property

        '<sbSwitching>
        Private Sub sbSwitching_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbSwitching.Click
            '<skip>
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            '</skip>
            If CurrentGrid.MainView Is cardView1 Then
                CurrentGrid.MainView = gridView1
            Else
                CurrentGrid.MainView = cardView1
            End If
            '<skip>
            InitAutoHeight()
            CurrentGrid.Focus()
            CurrentGrid.MainView.LayoutChanged()
            Cursor.Current = currentCursor
            RibbonMenuManager.AllowExport(CurrentGrid.MainView)
            OnSetCaption("")
            '</skip>
        End Sub
        '</sbSwitching>
        Protected Overrides Sub OnSetCaption(ByVal fCaption As String)
            fCaption = ActiveViewCaption
            sbSwitching.Text = SwitchButtonCaption
            Caption.Text = String.Format("{0} ({1})", TutorialName, fCaption)
        End Sub
        #End Region
    End Class
End Namespace
