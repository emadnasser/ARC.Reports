Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraTab
Imports DevExpress.XtraEditors
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridEditorsExternalRepository.
    ''' </summary>
    Partial Public Class GridEditorsExternalRepository
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
        Private fieldName As String = "ModelTrademark"


#Region "Init"
        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Cars.xml")
            If DBFileName <> "" Then
                Dim dataSet As DataSet = New DataSet()
                dataSet.ReadXml(DBFileName)
                gridControl1.DataSource = dataSet.Tables(0).DefaultView
            End If
        End Sub

        Private Sub InitViewLayout()
            Dim LayoutFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Layouts\cars_AdvBandedView.xml")
            If LayoutFileName <> "" Then
                advBandedGridView1.RestoreLayoutFromXml(LayoutFileName, Nothing)
                InitEditors()
            End If
        End Sub
#End Region
        Private Sub GridEditorsExternalRepository_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
            InitViewLayout()
            InitTabEditors()
        End Sub
        '<gridControl1>
        Private Sub InitEditors()
            Dim itemPictureEdit As RepositoryItemPictureEdit = New RepositoryItemPictureEdit()
            Dim itemRadioGroup As RepositoryItemRadioGroup = New RepositoryItemRadioGroup()
            Dim itemSpinEdit As RepositoryItemSpinEdit = New RepositoryItemSpinEdit()
            Dim itemCalcEdit As RepositoryItemCalcEdit = New RepositoryItemCalcEdit()
            '</gridControl1>
            Dim itemImageComboBox As RepositoryItemImageComboBox = New RepositoryItemImageComboBox()
            Dim itemTextEdit As RepositoryItemTextEdit = New RepositoryItemTextEdit()
            Dim itemCheckEdit As RepositoryItemCheckEdit = New RepositoryItemCheckEdit()
            Dim itemDateEdit As RepositoryItemDateEdit = New RepositoryItemDateEdit()
            itemSpinEdit.IsFloatValue = False
            itemPictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            itemImageComboBox.Items.AddRange(New Object() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Sports", "SPORTS", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Saloon", "SALOON", 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Truck", "TRUCK", 2)})
            itemImageComboBox.SmallImages = imageList1
            itemRadioGroup.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Yes", "Yes"), New DevExpress.XtraEditors.Controls.RadioGroupItem("No", "No")})
            '<gridControl1>
            'Assign an external editor repository to the grid. 
            Me.gridControl1.ExternalRepository = persistentRepository1
            Me.persistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {itemPictureEdit, itemRadioGroup, itemSpinEdit, itemCalcEdit, itemImageComboBox, itemTextEdit, itemCheckEdit, itemDateEdit})
            advBandedGridView1.Columns("Trademark").ColumnEdit = itemTextEdit
            advBandedGridView1.Columns("Model").ColumnEdit = itemTextEdit
            advBandedGridView1.Columns("Category").ColumnEdit = itemImageComboBox
            '</gridControl1>
            advBandedGridView1.Columns("Price").ColumnEdit = itemCalcEdit
            advBandedGridView1.Columns("Delivery Date").ColumnEdit = itemDateEdit
            advBandedGridView1.Columns("Is In Stock").ColumnEdit = itemCheckEdit
            advBandedGridView1.Columns("Picture").ColumnEdit = itemPictureEdit
            advBandedGridView1.Columns("HP").ColumnEdit = itemTextEdit
            advBandedGridView1.Columns("Cyl").ColumnEdit = itemSpinEdit
            advBandedGridView1.Columns("Liter").ColumnEdit = itemTextEdit
            advBandedGridView1.Columns("Transmiss Speed Count").ColumnEdit = itemSpinEdit
            advBandedGridView1.Columns("Transmiss Automatic").ColumnEdit = itemRadioGroup
            '<gridControl1>
        End Sub
        '</gridControl1>
#Region "Create Tabs"
        Private Sub CreateTabPage(ByVal col As DevExpress.XtraGrid.Columns.GridColumn)
            CreateTabPage(col.GetTextCaption(), col.ColumnEdit, Nothing)
        End Sub
        Private Sub CreateTabPage(ByVal caption As String, ByVal obj As Object, ByVal objs As Object())
            Dim page As XtraTabPage = New XtraTabPage()
            page.Text = caption
            Dim pg As XtraPropertyGrid = New XtraPropertyGrid()
            If Not obj Is Nothing Then
                pg.PropertyGrid.SelectedObject = obj
            Else
                pg.PropertyGrid.SelectedObjects = objs
            End If
            pg.Dock = DockStyle.Fill
            page.Controls.Add(pg)
            xtraTabControl1.TabPages.Add(page)
        End Sub
        Private Sub InitTabEditors()
            Dim objs As ArrayList = New ArrayList()
            For Each col As DevExpress.XtraGrid.Columns.GridColumn In advBandedGridView1.Columns
                If col.VisibleIndex <> -1 Then
                    CreateTabPage(col)
                    objs.Add(col.ColumnEdit)
                End If
            Next col
            CreateTabPage("All editors", Nothing, objs.ToArray())
        End Sub
#End Region
#Region "FocusedColumnChanged"
        Private Sub advBandedGridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles advBandedGridView1.FocusedColumnChanged
            For Each page As XtraTabPage In xtraTabControl1.TabPages
                If Not e.FocusedColumn Is Nothing Then
                    If page.Text = e.FocusedColumn.GetTextCaption() Then
                        xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.IndexOf(page)
                        gridControl1.Focus()
                        Exit For
                    End If
                End If
            Next page
        End Sub

        Private Sub xtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtraTabControl1.SelectedPageChanged
            For Each col As DevExpress.XtraGrid.Columns.GridColumn In advBandedGridView1.Columns
                If col.VisibleIndex <> -1 Then
                    If col.Caption = xtraTabControl1.SelectedTabPage.Text Then
                        advBandedGridView1.FocusedColumn = col
                        Exit For
                    End If
                End If
            Next col
        End Sub
#End Region

        Private Sub advBandedGridView1_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles advBandedGridView1.InvalidValueException
            If fieldName.IndexOf(advBandedGridView1.FocusedColumn.FieldName) >= 0 Then
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
            End If
        End Sub

        Private Sub advBandedGridView1_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles advBandedGridView1.ValidatingEditor
            If fieldName.IndexOf(advBandedGridView1.FocusedColumn.FieldName) >= 0 Then
                If XtraMessageBox.Show("Do you really want to modify the '" & advBandedGridView1.FocusedColumn.FieldName & "' value?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    e.Valid = False
                End If
            End If
        End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
