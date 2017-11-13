Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class ContextButtons
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            SetGalleryImageSize(300)
            InitializeAnimationTypeCombo()
        End Sub

        Private Sub InitializeAnimationTypeCombo()
            Me.repositoryItemImageComboBox1.Items.BeginUpdate()
            For Each animation As ContextAnimationType In System.Enum.GetValues(GetType(ContextAnimationType))
                Dim item As New ImageComboBoxItem(animation.ToString(), animation, -1)
                Me.repositoryItemImageComboBox1.Items.Add(item)
            Next animation
            Me.repositoryItemImageComboBox1.Items.EndUpdate()
            Me.barEditItem1.EditValue = ContextAnimationType.Default
        End Sub

        Private Sub item_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim item As BarCheckItem = CType(e.Item, BarCheckItem)
            If item.Checked Then
                Me.winExplorerView1.ContextButtonOptions.AnimationType = CType(item.Tag, ContextAnimationType)
            End If
        End Sub

        Private Sub SetGalleryImageSize(ByVal width As Integer)
            Me.winExplorerView1.OptionsViewStyles.ExtraLarge.ImageSize = New Size(width, CInt((width * 0.6)))
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitVehiclesData()
            InitGrid()
        End Sub

        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim tblModel As String = "Model", tblCategory As String = "Category", tblTrademark As String = "Trademark", tblBodyStyle As String = "BodyStyle", tblTransmissionType As String = "TransmissionType"
            Dim ds As New DataSet()

            FillTable(tblModel, String.Format("SELECT model.ID, model.Name, category.Name, trademark.Name, transmission.Name, bodyStyle.Name, model.InStock, model.Photo, model.Image, model.Description FROM {0} model, {1} category, {2} trademark, {3} transmission, {4} bodyStyle WHERE model.TrademarkID=trademark.ID AND model.CategoryID=category.ID AND model.[Transmission Type]=transmission.ID AND model.BodyStyleID=bodyStyle.ID AND model.Photo Is Not Null", tblModel, tblCategory, tblTrademark, tblTransmissionType, tblBodyStyle), connectionString, ds)

            SetGridDataSource(tblModel, ds, Me.gridControl1)
        End Sub

        Private Sub FillTable(ByVal table As String, ByVal query As String, ByVal connectionString As String, ByVal ds As DataSet)
            If query Is Nothing Then
                query = String.Format("SELECT * FROM {0}", table)
            End If
            Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter(query, connectionString)
            SetWaitDialogCaption(String.Format("Loading {0}...", table))
            oleDbDataAdapter.Fill(ds, table)
        End Sub

        Private Sub SetGridDataSource(ByVal table As String, ByVal ds As DataSet, ByVal grid As GridControl)
            Dim dvManager As New DataViewManager(ds)
            Dim dv As DataView = dvManager.CreateDataView(ds.Tables(table))
            grid.DataMember = Nothing
            grid.DataSource = dv
        End Sub

        Private Sub InitGrid()
            Me.winExplorerView1.Columns.Clear()
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "model.ID"})
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "model.Name"})
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Description"})
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Photo"})
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Image"})
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "InStock"})
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "category.Name"})
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "trademark.Name"})
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "transmission.Name"})
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "bodyStyle.Name"})

            'this.winExplorerView1.ColumnSet.TextColumn = this.winExplorerView1.Columns["model.Name"];
            Me.winExplorerView1.ColumnSet.DescriptionColumn = Me.winExplorerView1.Columns("Description")
            Me.winExplorerView1.ColumnSet.ExtraLargeImageColumn = Me.winExplorerView1.Columns("Photo")
            Me.winExplorerView1.ColumnSet.MediumImageColumn = Me.winExplorerView1.Columns("Image")
            Me.winExplorerView1.ColumnSet.CheckBoxColumn = Me.winExplorerView1.Columns("InStock")
            Me.winExplorerView1.ColumnSet.GroupColumn = Me.winExplorerView1.Columns("category.Name")
        End Sub

        Private Sub repositoryItemZoomTrackBar1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles repositoryItemZoomTrackBar2.EditValueChanged
            Dim value As Integer = DirectCast(sender, ZoomTrackBarControl).Value
            SetGalleryImageSize(value)
        End Sub

        Private checkedValues_Renamed As Dictionary(Of Integer, Boolean)
        Protected ReadOnly Property CheckedValues() As Dictionary(Of Integer, Boolean)
            Get
                If checkedValues_Renamed Is Nothing Then
                    checkedValues_Renamed = New Dictionary(Of Integer, Boolean)()
                End If
                Return checkedValues_Renamed
            End Get
        End Property
        Private ratingValues_Renamed As Dictionary(Of Integer, Integer)
        Protected ReadOnly Property RatingValues() As Dictionary(Of Integer, Integer)
            Get
                If ratingValues_Renamed Is Nothing Then
                    ratingValues_Renamed = New Dictionary(Of Integer, Integer)()
                End If
                Return ratingValues_Renamed
            End Get
        End Property
        Private Sub winExplorerView1_ContextButtonCustomize(ByVal sender As Object, ByVal e As Views.WinExplorer.WinExplorerViewContextButtonCustomizeEventArgs) Handles winExplorerView1.ContextButtonCustomize
            If e.Item.Name = "itemText" Then
                CType(e.Item, ContextButton).Caption = GetContextButtonCaption(e.RowHandle, Me.winExplorerView1.Columns("model.Name"), Me.winExplorerView1.Columns("trademark.Name"))
            ElseIf e.Item.Name = "itemCheck" Then
                If Not CheckedValues.ContainsKey(e.RowHandle) Then
                    CheckedValues.Add(e.RowHandle, e.RowHandle Mod 2 = 0)
                End If
                CType(e.Item, CheckContextButton).Checked = CheckedValues(e.RowHandle)
            ElseIf e.Item.Name = "itemRating" Then
                If Not RatingValues.ContainsKey(e.RowHandle) Then
                    RatingValues.Add(e.RowHandle, e.RowHandle Mod 6)
                End If
                CType(e.Item, RatingContextButton).Rating = RatingValues(e.RowHandle)
            End If
        End Sub
        Private Function GetContextButtonCaption(ByVal rowHandle As Integer, ByVal model As GridColumn, ByVal trademark As GridColumn) As String
            Dim caption As String = String.Empty
            If model IsNot Nothing Then
                caption = CStr(Me.winExplorerView1.GetRowCellValue(rowHandle, model))
            End If
            If caption IsNot Nothing AndAlso trademark IsNot Nothing AndAlso caption.Length < 20 Then
                caption = String.Format("{0} {1}", Me.winExplorerView1.GetRowCellValue(rowHandle, trademark), caption)
            End If

            Return caption
        End Function

        Private Sub winExplorerView1_ContextButtonClick(ByVal sender As Object, ByVal e As ContextItemClickEventArgs) Handles winExplorerView1.ContextButtonClick
            If e.Item.Name = "itemCheck" Then
                CheckedValues(CInt((e.DataItem))) = CType(e.Item, CheckContextButton).Checked
            ElseIf e.Item.Name = "itemRating" Then
                RatingValues(CInt((e.DataItem))) = CInt((CType(e.Item, RatingContextButton).Rating))
            ElseIf e.Item.Name = "itemDownload" Then
                MessageBox.Show("'Download' item clicked")
            ElseIf e.Item.Name = "itemRemove" Then
                MessageBox.Show("'Remove' item clicked")
            ElseIf e.Item.Name = "itemInfo" Then
                MessageBox.Show("'Info' item clicked")
            End If
        End Sub

        Private Sub repositoryItemImageComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles repositoryItemImageComboBox1.SelectedValueChanged
            Me.winExplorerView1.ContextButtonOptions.AnimationType = CType(CType(DirectCast(sender, ImageComboBoxEdit).SelectedItem, ImageComboBoxItem).Value, ContextAnimationType)
        End Sub
    End Class
End Namespace
