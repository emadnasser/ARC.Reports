Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for FixedColumns.
    ''' </summary>
    Partial Public Class FixedColumns
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\FixedColumns.vb"
            TutorialInfo.WhatsThisXMLFile = "FixedColumns.xml"
            InitNWindData()
            InitEditing()
            InitColumns()
            InitFixedStyle()
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub

#Region "Init"
        Public Overrides ReadOnly Property ExportView() As DevExpress.XtraGrid.Views.Base.BaseView
            Get
                Return gridView1
            End Get
        End Property
        Private ReadOnly Property CurrentGridView() As GridView
            Get
                Return gridView1
            End Get
        End Property
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim dataSet As New DataSet()
            Dim oleDBAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Customers", connectionString)

            SetWaitDialogCaption(My.Resources.LoadingCustomers)
            oleDBAdapter.Fill(dataSet, "Customers")
            gridControl2.DataSource = dataSet.Tables("Customers")
        End Sub
        Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
            Dim dataSet As New DataSet()
            SetWaitDialogCaption(My.Resources.LoadingTables)
            dataSet.ReadXml(dataFileName)
            gridControl2.DataSource = dataSet.Tables("Customers")
        End Sub
        Private Sub InitEditing()
            numFixedLineWidth1.Value = CurrentGridView.FixedLineWidth
        End Sub
        Private Sub FixedColumns_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            gridControl2.ForceInitialize()
            CurrentGridView.ExpandAllGroups()

            '<gridControl2>
            '            
            '~The following properties are specified at design-time and listed here for demonstration purposes
            '~            
            '~colCompanyName.Fixed = FixedStyle.Left
            '            
            '</gridControl2>
        End Sub
        Private Sub InitColumns()
            icbColumn.Properties.SmallImages = gridView1.Images
            icbColumn.Properties.Sorted = True
            For Each col As GridColumn In gridView1.Columns
                If col.Visible Then
                    icbColumn.Properties.Items.Add(New ImageComboBoxItem(col.GetTextCaption(), col, col.ImageIndex))
                End If
            Next col
            icbColumn.EditValue = colCompanyName
        End Sub

        Private Sub InitFixedStyle()
            For Each style As FixedStyle In System.Enum.GetValues(GetType(FixedStyle))
                icbFixedStyle.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of FixedStyle).GetTitle(style), style, -1))
            Next style
        End Sub
#End Region
#Region "Editing"
        '<numFixedLineWidth1>
        Private Sub numFixedLineWidth1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numFixedLineWidth1.EditValueChanged
            CurrentGridView.FixedLineWidth = CInt(Fix(numFixedLineWidth1.Value))
        End Sub
        '</numFixedLineWidth1>
#End Region
#Region "Grid events"
        Private Sub gridView1_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles gridView1.PopupMenuShowing
            If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
                Dim menu As DevExpress.XtraGrid.Menu.GridViewColumnMenu = TryCast(e.Menu, DevExpress.XtraGrid.Menu.GridViewColumnMenu)
                menu.Items.Clear()
                If menu.Column IsNot Nothing Then
                    menu.Items.Add(CreateCheckItem(My.Resources.NotFixed, menu.Column, FixedStyle.None, imageList2.Images(0)))
                    menu.Items.Add(CreateCheckItem(My.Resources.FixedLeft, menu.Column, FixedStyle.Left, imageList2.Images(1)))
                    menu.Items.Add(CreateCheckItem(My.Resources.FixedRight, menu.Column, FixedStyle.Right, imageList2.Images(2)))
                End If
            End If
        End Sub
#End Region
#Region "New column menu"
        Private Function CreateCheckItem(ByVal caption As String, ByVal column As GridColumn, ByVal style As FixedStyle, ByVal image As Image) As DXMenuCheckItem
            Dim item As New DXMenuCheckItem(caption, column.Fixed = style, image, New EventHandler(AddressOf OnFixedClick))
            item.Tag = New MenuInfo(column, style)
            Return item
        End Function
        Private Sub OnFixedClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
            Dim info As MenuInfo = TryCast(item.Tag, MenuInfo)
            If info Is Nothing Then
                Return
            End If
            info.Column.Fixed = info.Style
            UpdateColumnFixed()
        End Sub
        Private Class MenuInfo
            Public Sub New(ByVal column As GridColumn, ByVal style As FixedStyle)
                Me.Column = column
                Me.Style = style
            End Sub
            Public Style As FixedStyle
            Public Column As GridColumn
        End Class
#End Region


        Private Sub icbColumn_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbColumn.SelectedIndexChanged
            UpdateColumnFixed()
        End Sub

        Private Sub UpdateColumnFixed()
            Dim col As GridColumn = TryCast(icbColumn.EditValue, GridColumn)
            If col Is Nothing Then
                Return
            End If
            icbFixedStyle.EditValue = col.Fixed
        End Sub
        '<icbFixedStyle>
        Private Sub icbFixedStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbFixedStyle.SelectedIndexChanged
            Dim col As GridColumn = TryCast(icbColumn.EditValue, GridColumn)
            If col Is Nothing Then
                Return
            End If
            col.Fixed = CType(icbFixedStyle.EditValue, FixedStyle)
        End Sub
        '</icbFixedStyle>
    End Class
End Namespace
